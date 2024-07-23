using System.CodeDom;
using CodeGenerators.Builders;
using CodeGenerators.CodeDom;
using CodeGenerators.Errors;
using CodeGenerators.Models;
using Microsoft.AspNetCore.Builder;

namespace CodeGenerators.Applications;

public class FastEndpointAppGenerator
{
    private readonly ILogger _logger = Log.ForContext<FastEndpointAppGenerator>();
    
    private string templateName = "ProjectFile.csproj";
    private CodeDomSourceGenerator _generator = new();
    private ClassBuilder _builder = new();

    /// <summary>
    /// Generate the main application project for a FastEndpoints web API.
    /// </summary>
    /// <param name="solutionName"></param>
    /// <param name="outputLocation"></param>
    /// <param name="skipWrite"></param>
    /// <returns></returns>
    public Result<SolutionModel> GenerateApiSolution(string solutionName, string outputLocation, bool writeFiles = false)
    {
        var slnBuilder = new SolutionGenerator(Log.Logger);
        
        // For now, we just use the solution name as a project name and path.
        var projectName = $"{solutionName}.Api";
        var apiNamespace = projectName;
        
        var progResult = GenerateProgramClass(projectName);
        if (progResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(progResult);
            return Err<SolutionModel>($"Failed to build main method: {msg}");
        }
        var progModel = progResult.Unwrap();
        
        var request = BuildRequestDto(apiNamespace);
        var response = BuildResponseDto(apiNamespace);
        var endpoint = BuildEndpoint(apiNamespace);
        
        var projectModel = new ProjectModel(projectName, templateName, [progModel, endpoint, request, response]);//, request, response]);
        projectModel.PackageReferences.Add(new PackageReferenceModel("FastEndpoints", "5.27.0.12-beta"));
        projectModel.PackageReferences.Add(new PackageReferenceModel("Microsoft.AspNetCore.OpenApi", "8.0.7"));
        projectModel.PackageReferences.Add(new PackageReferenceModel("Swashbuckle.AspNetCore", "6.4.0"));
        
        var slnModel = new SolutionModel(solutionName, [projectModel]);

        var slnResult = slnBuilder.GenerateSolution(slnModel, outputLocation, writeFiles);

        return slnResult;
    }

    private Result<CodeArtifactModel> GenerateProgramClass(string apiNamespace)
    {
        _logger.Verbose("Starting {GenerateOperation}", nameof(GenerateProgramClass));
        
        var model = new CodeArtifactModel("Program", apiNamespace);
        var main = BuildMainMethod();
        model.Members.Add(main);
        
        var programClass = _builder.BuildTypeForClass(model);

        var ns = new CodeNamespace(apiNamespace);
        ns.Types.Add(programClass);
        var code = _generator.GenerateCodeForType(programClass, apiNamespace, usings: ["Microsoft.AspNetCore.Builder", "FastEndpoints"]);

        _logger.Debug("Finished {GenerateOperation} with code {GeneratedCode}", nameof(GenerateProgramClass), code);
        
        return code;
    }
    
    private CodeMemberMethod BuildMainMethod()
    {
        _logger.Verbose("Starting BuildOperation {BuildOperation}", nameof(BuildMainMethod));
        var builderVarName = "builder";
        var appVarName = "app";
        
        var builderDec = BuildWebAppBuilderDec(builderVarName);
        var addFastEndpoints = CodeElements.InvokeServiceCollectionMethod(builderVarName,"AddFastEndpoints");
        
        var appDec = BuildAppVarDec(appVarName, builderVarName);
        var useFastEndpoints = CodeElements.GetMethodInvocation(appVarName, "UseFastEndpoints", []);
        var run = CodeElements.GetMethodInvocation(appVarName, "Run", []);

        ParameterModel[] parameters = [new ParameterModel(typeof(string[]), "args")];
        var statements = new CodeStatementCollection { builderDec, addFastEndpoints, appDec, useFastEndpoints, run };
        
        var main = _builder.BuildMethodDec("Main", parameters, statements, MemberAttributes.Static | MemberAttributes.Public);
        
        _logger.Debug("Finished BuildOperation {BuildOperation} with code {GeneratedCode}", nameof(BuildMainMethod), main);

        return main;
    }

    private CodeArtifactModel BuildEndpoint(string epNamespace)
    {
        _logger.Verbose("Starting BuildOperation {BuildOperation}", nameof(BuildEndpoint));

        var endpoint = EndpointBuilder.BuildEndpointClass("MyEndpoint", "MyRequest", "MyResponse");
        var code = _generator.GenerateCodeForType(endpoint, epNamespace);
        
        _logger.Debug("Finished BuildOperation {BuildOperation} with code {GeneratedCode}", nameof(BuildEndpoint), code);

        return code;
    }

    private CodeArtifactModel BuildResponseDto(string dtoNamespace)
    {
        _logger.Verbose("Starting BuildOperation {BuildOperation}", nameof(BuildResponseDto));

        var model = new CodeArtifactModel("MyResponse", dtoNamespace);
        model.Members.AddRange(CodeElements.BuildPropertyDec(new PropertyModel(typeof(string), "FullName")));
        model.Members.AddRange(CodeElements.BuildPropertyDec(new PropertyModel(typeof(bool), "IsOver18")));
        var dto = _builder.BuildTypeForClass(model);
        var code = _generator.GenerateCodeForType(dto, dtoNamespace);
        
        _logger.Debug("Finished BuildOperation {BuildOperation} with code {GeneratedCode}", nameof(BuildResponseDto), code);

        return code;
    }
    
    private CodeArtifactModel BuildRequestDto(string dtoNamespace)
    {
        _logger.Verbose("Starting BuildOperation {BuildOperation}", nameof(BuildRequestDto));

        var model = new CodeArtifactModel("MyRequest", dtoNamespace);
        model.Members.AddRange(CodeElements.BuildPropertyDec( new PropertyModel(typeof(string), "FirstName")));
        model.Members.AddRange(CodeElements.BuildPropertyDec(new PropertyModel(typeof(string), "LastName")));
        model.Members.AddRange(CodeElements.BuildPropertyDec(new PropertyModel(typeof(int), "Age")));
        var dto = _builder.BuildTypeForClass(model);
        var code = _generator.GenerateCodeForType(dto, dtoNamespace);
        
        _logger.Debug("Finished BuildOperation {BuildOperation} with code {GeneratedCode}", nameof(BuildRequestDto), code);
        return code;
    }
    
    /// <summary>
    /// Builds a statement for <c>WebApplicationBuilder builder;;</c>, but with variable names from parameters.
    /// </summary>
    private static CodeVariableDeclarationStatement BuildWebAppBuilderDec(string builderName)
    {
        var valueExp = CodeElements.BuildMethodCallExpression(typeof(WebApplication), "CreateBuilder", []);
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplicationBuilder), builderName, valueExp);
        return dec;
    }
    
    /// <summary>
    /// Builds a statement for <c>WebApplication app = builder.Build();</c>, but with variable names from parameters.
    /// </summary>
    private static CodeVariableDeclarationStatement BuildAppVarDec(string appVarName, string builderVarName)
    {
        var builderExp = new CodeVariableReferenceExpression(builderVarName);
        var valueExp = CodeElements.BuildMethodCallExpression(builderExp, "Build", []);
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplication), appVarName, valueExp);
        return dec;
    }
}