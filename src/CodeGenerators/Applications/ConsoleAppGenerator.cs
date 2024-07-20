using System.Diagnostics;
using CodeGenerators.CodeElements;
using ILogger = Serilog.ILogger;
namespace CodeGenerators.Applications;

public class ConsoleAppGenerator
{
    private readonly ILogger _logger = Log.ForContext<ConsoleAppGenerator>();
    private readonly CSharpCodeGenerator _generator = new();
    
    public bool BuildHelloWorldApp(string outputDirectory)
    {
        var projectName = "HelloWorld";
        var appNamespace = projectName;

        // For now, we just use the project name as a solution name and path.
        var solutionName = projectName;
        
        // TASKB: Passes projectName for namespace. Not documented.
        var classBuilder = new ClassBuilder();
        var generator = new CSharpCodeGenerator();
        
        var progClass = classBuilder.BuildProgramClass(projectName);
        var progModel = generator.GenerateCodeForClass(progClass, appNamespace);

        var projectModel = new ProjectModel(projectName, [progModel]);
        
        var slnBuilder = new SolutionGenerator();
        var slnModel = new SolutionModel(solutionName, [projectModel]);
        
        var result = slnBuilder.GenerateSolution(slnModel, outputDirectory, [projectModel]);
        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var error);
            Debug.Assert(error != null, nameof(error) + " != null");
            _logger.Error("Failed to scaffold console app: {ErrorMessage}", hasErr ? error.Message : "Unable to read error message from result");
        }
        
        return result.IsOk;
    }

    // TASKT: Factor into ClassBuilder

}