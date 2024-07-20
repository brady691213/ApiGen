using System.CodeDom;
using CodeGenerators.CodeDom;
using CodeGenerators.Errors;
using CodeGenerators.Templates;

namespace CodeGenerators.Applications;

public class FastEndpointAppGenerator
{
    private readonly ILogger _logger = Log.ForContext<FastEndpointAppGenerator>();

    private ClassGenerator _classGenerator = new();
    
    /// <summary>
    /// Generate the main application for a FastEndpoints web API.
    /// </summary>
    /// <param name="solutionName"></param>
    /// <returns></returns>
    public Result<GenerationTaskInfo> GenerateApp(string solutionName, string outputLocation)
    {
        // var genInfo = new GenerationTaskInfo(Diags.GetCurrentMethod(), outputLocation);
        //
        // // For now, we just use the solution name as a project name and path.
        // var projectName = solutionName;
        // var apiNamespace = projectName;
        //
        // var progSource = BuildProgramClass(apiNamespace);
        // var programModel = new CodeFileModel("Program.cs", progSource);
        //
        // var dto = BuildRequestDto();
        // var dtoModel = new CodeFileModel("Request.cs", dto);
        //
        // var projectModel = new ProjectModel(projectName, [programModel, dtoModel]);
        //
        // return new NotFinishedError("Not fully implemented.");
        return new NotFinishedError("Not finished");
    }

    private CodeFileModel BuildProgramClass()
    {
        var builderVarName = "builder";
        CodeVariableDeclarationStatement builderDec;
        CodePropertyReferenceExpression servicesExp;
    
        var model = new ClassModel("Program");

        builderDec = CodeElementBuilder.WebAppBuilderVariable(builderVarName);

        var services = CodeElementBuilder.GetServicesExpression(builderVarName);

        var addFastEndpoints = CodeElementBuilder.InvokeServicesExtension("AddFastEndpointsx");
        
        var appDec = CodeDom.CodeElementBuilder.BuilderInvokeBuild("app");
        
        var statements = new CodeStatementCollection { builderDec, addFastEndpoints, appDec };
        
        var main = _classGenerator.BuildMethod("Main", [], statements, MemberAttributes.Abstract);
        
        var programClass = _classGenerator.GenerateClass(model);
    }
    
    

    private void BuildMainMethod()
    {
        var argParam = new ParameterModel(typeof(string[]), "args");

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