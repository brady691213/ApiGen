using System.CodeDom;
using CodeGenerators.Builders;
using CodeGenerators.CodeDom;
using CodeGenerators.Errors;
using CodeGenerators.Models;

namespace CodeGenerators.Applications;

public class FastEndpointAppGenerator
{
    private string templateName = "FeProjectFile.csproj";
    private readonly ILogger _logger = Log.ForContext<FastEndpointAppGenerator>();

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
        var projectName = solutionName;
        
        var progResult = BuildProgramClass();
        if (progResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(progResult);
            return Err<SolutionModel>($"Failed to build main method: {msg}");
        }
        var progModel = progResult.Unwrap();
        
        var request = BuildRequestDto();
        
        var projectModel = new ProjectModel(projectName, templateName, [progModel, request]);
        projectModel.PackageReferences.Add(new PackageReferenceModel("FastEndpoints", "5.27.0.12-beta"));
        projectModel.PackageReferences.Add(new PackageReferenceModel("Microsoft.AspNetCore.OpenApi", "8.0.7"));
        projectModel.PackageReferences.Add(new PackageReferenceModel("Swashbuckle.AspNetCore", "6.4.0"));

        
        var slnModel = new SolutionModel(solutionName, [projectModel]);

        var slnResult = slnBuilder.GenerateSolution(slnModel, outputLocation, writeFiles);

        return slnResult;
    }

    private Result<CodeFileModel> BuildProgramClass()
    {
        var model = new ClassModel("Program");
        var main = BuildMainMethod();
        
        model.Members.Add(main);
        
        var programClass = _builder.BuildTypeForClass(model);

        var ns = new CodeNamespace();
        ns.Types.Add(programClass);
        var code = _generator.GenerateCodeForType(programClass, usings: ["FastEndpoints"]);

        return code;
    }
    
    private CodeMemberMethod BuildMainMethod()
    {
        var builderVarName = "builder";
        var appVarName = "app";
        
        var builderDec = CodeElements.WebAppBuilderDec(builderVarName);
        var addFastEndpoints = CodeElements.InvokeServiceCollectionMethod(builderVarName,"AddFastEndpoints");
        
        var appDec = CodeDom.CodeElements.WebAppDec(appVarName);
        var useFastEndpoints = CodeElements.GetMethodInvocation(appVarName, "UseFastEndpointssx");
        var run = CodeElements.GetMethodInvocation(appVarName, "Run");

        ParameterModel[] parameters = [new ParameterModel(typeof(string[]), "args")];
        var statements = new CodeStatementCollection { builderDec, addFastEndpoints, appDec, useFastEndpoints, run };
        
        var main = _builder.BuildMethodDec("Main", parameters, statements, MemberAttributes.Static | MemberAttributes.Public);

        return main;
    }
    
    private CodeFileModel BuildRequestDto()
    {
        var code = """
                   public class MyRequest
                   {
                       public string FirstName { get; set; }
                       public string LastName { get; set; }
                       public int Age { get; set; }
                   }
                   """;
        return new CodeFileModel("MyRequest", code);
    }
}