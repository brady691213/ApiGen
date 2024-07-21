using System.CodeDom;
using System.Xml.Xsl;
using CodeGenerators.CodeDom;
using CodeGenerators.CodeElements;
using CodeGenerators.Errors;
using CodeGenerators.Templates;

namespace CodeGenerators.Applications;

public class FastEndpointAppGenerator
{
    private readonly ILogger _logger = Log.ForContext<FastEndpointAppGenerator>();
    
    private const string SolutionName = "HelloWorld";
    private const string ProjectName = SolutionName;
    private const string RootNamespace = ProjectName;

    private CSharpCodeGenerator _codeGenerator = new();
    private ClassGenerator _classGenerator = new();
    
    /// <summary>
    /// Generate the main application for a FastEndpoints web API.
    /// </summary>
    /// <param name="solutionName"></param>
    /// <returns></returns>
    public Result<GenerationTaskInfo> GenerateApiSolution(string solutionName, string outputLocation, bool skipWrite = true)
    {
        var slnBuilder = new SolutionGenerator();
        
        var genInfo = new GenerationTaskInfo(Diags.GetCurrentMethod(), outputLocation);
        
        // For now, we just use the solution name as a project name and path.
        var projectName = solutionName;
        var apiNamespace = projectName;
        
        var progModel = BuildProgramClass();
        
        var dto = BuildRequestDto();
        var dtoModel = new CodeFileModel("Request.cs", dto);
        
        var projectModel = new ProjectModel(projectName, [progModel, dtoModel]);
        var slnModel = new SolutionModel(SolutionName, [projectModel]);

        var slnResult = slnBuilder.GenerateSolution(slnModel, outputLocation, skipWrite);

        return slnResult;
    }

    private CodeFileModel BuildProgramClass()
    {
        var model = new ClassModel("Program");
        var main = BuildMainMethod();
        
        model.Members.Add(main);
        
        var programClass = _classGenerator.GenerateClass(model);

        var ns = new CodeNamespace();
        ns.Types.Add(programClass);
        var code = _codeGenerator.GenerateCodeForType(programClass, RootNamespace);

        return code;
    }
    
    private CodeMemberMethod BuildMainMethod()
    {
        var builderVarName = "builder";
        var appVarName = "app";
        
        var argParam = new ParameterModel(typeof(string[]), "args");
        var builderDec = CodeElementBuilder.WebAppBuilderDec(builderVarName);
        var addFastEndpoints = CodeElementBuilder.InvokeServicesExtension(builderVarName,"AddFastEndpoints");
        var appDec = CodeDom.CodeElementBuilder.WebAppBuilderDec(builderVarName);
        var useFastEndpoints = CodeElementBuilder.InvokeAppMethod(appVarName, "UseFastEndpointssx");
        var run = CodeElementBuilder.InvokeAppMethod(appVarName, "Run");

        ParameterModel[] parameters = [new ParameterModel(typeof(string[]), "args")];
        var statements = new CodeStatementCollection { builderDec, addFastEndpoints, appDec, useFastEndpoints, run };
        
        var main = _classGenerator.BuildMethod("Main", parameters, statements, MemberAttributes.Abstract | MemberAttributes.Public);

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