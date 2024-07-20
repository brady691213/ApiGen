using System.Diagnostics;
using CodeGenerators.CodeElements;
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
    public bool BuildHelloWorldApp(string outputDirectory)
    {
        var programModel = GenerateProgramModel();
        var projectModel = new ProjectModel(ProjectName, [programModel]);
        
        var slnBuilder = new SolutionGenerator();
        var slnModel = new SolutionModel(SolutionName, [projectModel]);
        var result = slnBuilder.GenerateSolution(slnModel, outputDirectory, [projectModel]);
        
        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var error);
            Debug.Assert(error != null, nameof(error) + " != null");
            _logger.Error("Failed to scaffold console app: {ErrorMessage}", hasErr ? error.Message : "Unable to read error message from result");
        }
        
        return result.IsOk;
    }


    private CodeFileModel GenerateProgramModel()
    {
        var model = new ClassModel("Program");
        var progClass = _classBuilder.GenerateClass(model);
        var code = _generator.GenerateCodeForType(progClass, RootNamespace);
        // TASKT: Remove 'by a tool' comments using regex: `\/\/.*[\s\S]*?\/\/.*`
        return code;
    }
}