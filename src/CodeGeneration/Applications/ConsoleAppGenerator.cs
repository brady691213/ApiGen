using System.Diagnostics;
using CodeGenerators.Builders;
using CodeGenerators.CodeDom;
using CodeGenerators.Errors;
using CodeGenerators.Models;
using ILogger = Serilog.ILogger;

namespace CodeGenerators.Applications;

public class ConsoleAppGenerator()
{
    private readonly ILogger _logger = Log.ForContext<FastEndpointAppGenerator>();

    private readonly string _templateName = "ProjectFile.csproj";
    private readonly ClassBuilder _classBuilder = new();

    /// <summary>
    /// Build a console application that prints "Hello, World!" from the `Main` entry point in class `Program`.
    /// </summary>
    public Result<SolutionModel> GenerateHelloWorldSolution(string solutionName, string outputDirectory, bool dryRun = false)
    {
        var programResult = GenerateProgramClass(solutionName);
        if (programResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(programResult);
            return Err<SolutionModel>($"Failed to generate Program class: {msg}");
        }
        var programModel = programResult.Unwrap();
        
        var projectModel = new ProjectModel($"{solutionName}.Console", _templateName, [programModel]);

        var solutionGenerator = new SolutionGenerator(_logger);
        var solutionModel = new SolutionModel(solutionName, [projectModel]);
        var result = solutionGenerator.GenerateSolution(solutionModel, outputDirectory, dryRun);

        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var error);
            Debug.Assert(error != null, nameof(error) + " != null");
            _logger.Error("Failed to generate Hello World app: {ErrorMessage}", error.Message);
            return error;
        }

        return solutionModel;
    }
    
    private Result<CodeArtifactModel> GenerateProgramClass(string mainNamespace)
    {
        var classModel = new CodeArtifactModel("Program", mainNamespace);

        var mainResult = ConsoleAppMethods.BuildMainMethod();
        if (mainResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(mainResult);
            return Err<CodeArtifactModel>($"Failed to build main method: {msg}");
        }
        var mainMethod = mainResult.Unwrap();
        
        classModel.Members.Add(mainMethod);

        var programDec = _classBuilder.BuildTypeForClass(classModel);

        var codeNamespace = Namespaces.BuildCodeNamespace(mainNamespace);
        codeNamespace.Types.Add(programDec);

        var generator = new CodeDomSourceGenerator();
        var fileModel = generator.GenerateCodeForType(programDec, mainNamespace);

        return fileModel;
    }
}