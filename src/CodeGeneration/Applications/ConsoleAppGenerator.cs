using System.Diagnostics;
using CodeGenerators.Builders;
using CodeGenerators.CodeDom;
using CodeGenerators.Errors;
using CodeGenerators.Models;
using ILogger = Serilog.ILogger;

namespace CodeGenerators.Applications;

public class ConsoleAppGenerator()
{
    private static readonly ILogger Logger = Log.ForContext<ConsoleAppGenerator>();

    private readonly string _templateName = "ProjectFile.csproj";
    private readonly ClassBuilder _classBuilder = new();

    /// <summary>
    /// Build a console application that prints "Hello, World!" from the `Main` entry point in class `Program`.
    /// </summary>
    public Result<SolutionModel> GenerateConsoleAppSolution(string solutionName, string outputDirectory, bool writeFiles = false)
    {
        var projectName = $"{solutionName}.Console";
        var programResult = GenerateProgramClass(projectName);
        if (programResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(programResult);
            return Err<SolutionModel>($"Failed to generate Program class: {msg}");
        }
        var programModel = programResult.Unwrap();
        
        var projectModel = new ProjectModel($"{solutionName}.Console", _templateName, [programModel]);

        var solutionGenerator = new SolutionGenerator(Logger);
        var solutionModel = new SolutionModel(solutionName, [projectModel]);
        var result = solutionGenerator.GenerateSolution(solutionModel, outputDirectory, writeFiles);

        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var error);
            Debug.Assert(error != null, nameof(error) + " != null");
            Logger.Error("Failed to generate Hello World app: {ErrorMessage}", error.Message);
            return error;
        }

        return solutionModel;
    }
    
    private Result<CodeArtifactModel> GenerateProgramClass(string mainNamespace, bool printHello = false)
    {
        Logger.Verbose("Starting {GenerateOperation}", nameof(GenerateProgramClass));

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

        Logger.Debug("Finished {GenerateOperation} with code {GeneratedCode}", nameof(GenerateProgramClass), fileModel.Content);
        
        return fileModel;
    }
}