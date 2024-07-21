using System.CodeDom;
using System.Diagnostics;
using System.Reflection;
using CodeGenerators.CodeDom;
using ILogger = Serilog.ILogger;

namespace CodeGenerators.Applications;

public class ConsoleAppGenerator
{
    private const string SolutionName = "HelloWorld";
    private const string ProjectName = SolutionName;
    private const string RootNamespace = ProjectName;

    private readonly ILogger _logger = Log.ForContext<ConsoleAppGenerator>();

    private readonly ClassGenerator _classBuilder = new();
    private readonly CSharpCodeGenerator _generator = new();

    /// <summary>
    /// Build a console application that prints "Hello, World!" from the `Main` entry point in class `Program`.
    /// </summary>
    public bool BuildHelloWorldApp(string outputDirectory, bool dryRun = false)
    {
        var programModel = GenerateProgramFile();
        var projectModel = new ProjectModel(ProjectName, [programModel]);

        var slnGenerator = new SolutionGenerator();
        var slnModel = new SolutionModel(SolutionName, [projectModel]);
        var result = slnGenerator.GenerateSolution(slnModel, outputDirectory, dryRun);

        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var error);
            Debug.Assert(error != null, nameof(error) + " != null");
            _logger.Error("Failed to scaffold console app: {ErrorMessage}",
                hasErr ? error.Message : "Unable to read error message from result");
        }

        return result.IsOk;
    }
    
    private CodeFileModel GenerateProgramFile()
    {
        var helloWorld = GenerateHelloWorldStatement();
        ParameterModel[] parameters = [new ParameterModel(typeof(string[]), "args")];
        var main = _classBuilder.BuildMethod("Main", parameters, [helloWorld], MemberAttributes.Static | MemberAttributes.Public);
        var classModel = new ClassModel("Program");
        classModel.Members.Add(main);
        var programClassType = _classBuilder.GenerateClass(classModel);

        var codeNamespace = new CodeNamespace();
        codeNamespace.Types.Add(programClassType);
        var fileModel = _generator.GenerateCodeForType(programClassType, RootNamespace);

        return fileModel;
    }
    
    private CodeMethodInvokeExpression GenerateHelloWorldStatement()
    {
        var helloStatement = CodeDom.CodeElements.BuildMethodCallExpression(typeof(Console), "WriteLine",
            [new CodePrimitiveExpression("Hello world")]);
        return helloStatement;
        
        // var xs = new CodeTypeReferenceExpression("System.Console"),
        //     "WriteLine", toStringInvoke));        
    }
}