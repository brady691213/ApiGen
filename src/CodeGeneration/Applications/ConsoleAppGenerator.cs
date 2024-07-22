using System.CodeDom;
using System.Diagnostics;
using CodeGenerators.Builders;
using CodeGenerators.CodeDom;
using CodeGenerators.Errors;
using CodeGenerators.Models;
using ILogger = Serilog.ILogger;

namespace CodeGenerators.Applications;

public class ConsoleAppGenerator(ILogger logger)
{
    private readonly ClassBuilder _classBuilder = new();

    /// <summary>
    /// Build a console application that prints "Hello, World!" from the `Main` entry point in class `Program`.
    /// </summary>
    public Result<SolutionModel> GenerateHelloWorldSolution(string outputDirectory, bool dryRun = false)
    {
        var solutionName = "HelloWorld";
        var programResult = GenerateProgramClass(solutionName);
        if (programResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(programResult);
            return Err<SolutionModel>($"Failed to generate Program class: {msg}");
        }
        var programModel = programResult.Unwrap();
        
        var projectModel = new ProjectModel($"{solutionName}.Console");

        var solutionGenerator = new SolutionGenerator(logger);
        var solutionModel = new SolutionModel(solutionName, [projectModel]);
        var result = solutionGenerator.GenerateSolution(solutionModel, outputDirectory, dryRun);

        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var error);
            Debug.Assert(error != null, nameof(error) + " != null");
            logger.Error("Failed to generate Hello World app: {ErrorMessage}", error.Message);
            return error;
        }

        return solutionModel;
    }
    
    private Result<CodeFileModel> GenerateProgramClass(string mainNamespace)
    {
        var classModel = new ClassModel("Program");

        var helloStatement = BuildHelloWorldStatement();
        var mainResult = BuildMainMethod([helloStatement]);
        if (mainResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(mainResult);
            return Err<CodeFileModel>($"Failed to build main method: {msg}");
        }
        var mainMethod = mainResult.Unwrap();
        
        classModel.Members.Add(mainMethod);

        var programDec = _classBuilder.BuildTypeForClass(classModel);

        var codeNamespace = new CodeNamespace();
        codeNamespace.Types.Add(programDec);

        var generator = new CodeDomSourceGenerator();
        var fileModel = generator.GenerateCodeForType(programDec, mainNamespace);

        return fileModel;
    }

    /// <summary>
    /// Builds a <see cref="CodeMemberMethod"/> that defines a <c>Main</c> entry point method for an application.
    /// </summary>
    private Result<CodeMemberMethod> BuildMainMethod(CodeStatementCollection statements)
    {
        // TASKT: Call from app builder not from BuildProgramClass
        ParameterModel[] parameters = [new ParameterModel(typeof(string[]), "args")];
        var main = _classBuilder.BuildMethodDec("Main", parameters, statements, MemberAttributes.Static | MemberAttributes.Public);
        return main;
    }
    
    /// <summary>
    /// Builds a <see cref="CodeMethodInvokeExpression"/> that defines the following code:
    /// <code>
    /// System.Console.WriteLine("Hello, world!");
    /// </code>
    /// </summary>
    private CodeMethodInvokeExpression BuildHelloWorldStatement()
    {
        var argsParam = new ParameterModel(typeof(string[]), "args");
        var stmt = _classBuilder.BuildMethodCall(typeof(Console), "WriteLine", [argsParam]);
        var statement = CodeElements.BuildMethodCallExpression(
            typeof(Console), 
            "WriteLine",
            [new CodePrimitiveExpression("Hello, world")]);
        return statement;
    }
}