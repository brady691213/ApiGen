using System.Diagnostics;
using ILogger = Serilog.ILogger;
namespace CodeScaffolder;

public class ConsoleAppBuilder
{
    private readonly ILogger _logger = Log.ForContext<ConsoleAppBuilder>();
    
    public bool BuildHelloWorldApp(string outputDirectory)
    {
        var projectName = "HelloWorld";

        // For now, we just use the project name as a solution name and path.
        var solutionName = projectName;
        var solutionDirectory = $"{outputDirectory}/{solutionName}";
        
        var progSource = BuildProgramClass(projectName);
        var progModel = new CodeFileModel("Program.cs", progSource);

        var projectModel = new ProjectModel(projectName, [progModel]);
        var projectBuilder = new ProjectBuilder();
        //projectBuilder.ScaffoldProject(projectModel, sourceLocation);        
        
        var slnBuilder = new SolutionBuilder();
        var slnModel = new SolutionModel(solutionName, [projectModel]);
        
        var result = slnBuilder.ScaffoldSolution(slnModel, outputDirectory, [projectModel]);
        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var error);
            Debug.Assert(error != null, nameof(error) + " != null");
            _logger.Error("Failed to scaffold console app: {ErrorMessage}", hasErr ? error.Message : "Unable to read error message from result");
        }
        
        return result.IsOk;
    }

    // TASKT: Factor into ClassBuilder
    private string BuildProgramClass(string @namespace)
    {
        var classBuilder = new ClassBuilder();

        var rootNamespace = classBuilder.BuildNamespace(@namespace);
        var programClass = classBuilder.BuildClass("Program");
        var mainMethod = classBuilder.BuildMainMethod();
        
        programClass.Members.Add(mainMethod);
        rootNamespace.Types.Add(programClass);

        var code = classBuilder.GenerateCSharpCode([rootNamespace]);
        return code;
    }
}