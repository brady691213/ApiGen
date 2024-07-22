using System.CodeDom;
using System.Xml.Xsl;
using CodeGenerators.Builders;
using CodeGenerators.CodeDom;
using CodeGenerators.Errors;
using CodeGenerators.Models;
using CodeGenerators.Templates;

namespace CodeGenerators.Applications;

public class FastEndpointAppGenerator
{
    private readonly ILogger _logger = Log.ForContext<FastEndpointAppGenerator>();
    
    private const string SolutionName = "HelloWorld";
    private const string ProjectName = SolutionName;
    private const string RootNamespace = ProjectName;

    private CodeDomSourceGenerator _generator = new();
    private ClassBuilder _builder = new();
    
    /// <summary>
    /// Generate the main application project for a FastEndpoints web API.
    /// </summary>
    /// <param name="solutionName"></param>
    /// <returns></returns>
    public Result<SolutionModel> GenerateApiSolution(string solutionName, string outputLocation, bool skipWrite = true)
    {
        var slnBuilder = new SolutionGenerator(Log.Logger);
        
        // For now, we just use the solution name as a project name and path.
        var projectName = solutionName;
        var apiNamespace = projectName;
        
        var progResult = BuildProgramClass();
        if (progResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(progResult);
            return Err<SolutionModel>($"Failed to build main method: {msg}");
        }
        var mainMethod = progResult.Unwrap();
        var progModel = progResult.Unwrap();
        
        var dto = BuildRequestDto();
        var dtoModel = new CodeFileModel("Request.cs", dto);
        
        var projectModel = new ProjectModel(projectName, [progModel, dtoModel]);
        var slnModel = new SolutionModel(SolutionName, [projectModel]);

        var slnResult = slnBuilder.GenerateSolution(slnModel, outputLocation, skipWrite);

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
        var code = _generator.GenerateCodeForType(programClass, RootNamespace);

        return code;
    }
    
    private CodeMemberMethod BuildMainMethod()
    {
        var builderVarName = "builder";
        var appVarName = "app";
        
        var argParam = new ParameterModel(typeof(string[]), "args");
        var builderDec = CodeElements.WebAppBuilderDec(builderVarName);
        var addFastEndpoints = CodeElements.InvokeServiceCollectionMethod(builderVarName,"AddFastEndpoints");
        var appDec = CodeDom.CodeElements.WebAppBuilderDec(builderVarName);
        var useFastEndpoints = CodeElements.GetMethodInvocation(appVarName, "UseFastEndpointssx");
        var run = CodeElements.GetMethodInvocation(appVarName, "Run");

        ParameterModel[] parameters = [new ParameterModel(typeof(string[]), "args")];
        var statements = new CodeStatementCollection { builderDec, addFastEndpoints, appDec, useFastEndpoints, run };
        
        var main = _builder.BuildMethodDec("Main", parameters, statements, MemberAttributes.Static | MemberAttributes.Public);

        return main;
    }
    
    private string BuildRequestDto()
    {
        var code = """
                   public class MyRequest
                   {
                       public string FirstName { get; set; }
                       public string LastName { get; set; }
                       public int Age { get; set; }
                   }
                   """;
        return code;
    }
}