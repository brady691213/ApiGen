using System.CodeDom;
using System.Diagnostics;
using System.Reflection;
using CodeGenerators.Builders;
using CodeGenerators.CodeDom;
using CodeGenerators.Models;
using ILogger = Serilog.ILogger;

namespace CodeGenerators.Applications;

public class ConsoleAppGenerator
{
    private const string SolutionName = "HelloWorld";
    private const string ProjectName = SolutionName;
    private const string RootNamespace = ProjectName;

    private readonly ILogger _logger = Log.ForContext<ConsoleAppGenerator>();

    private readonly ClassBuilder _classBuilder = new();
    private readonly CodeDomSourceGenerator _generator = new();

    /// <summary>
    /// Build a console application that prints "Hello, World!" from the `Main` entry point in class `Program`.
    /// </summary>
    public bool BuildHelloWorldApp(string outputDirectory, bool dryRun = false)
    {
        var programModel = GenerateProgramClass();
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
    
    // TASKT: Factor out into shared, more generic. Only leave HelloWorld here.
    private CodeFileModel GenerateProgramClass()
    {
        var classModel = new ClassModel("Program");

        var helloStatement = BuildHelloWorldStatement();
        var main = BuildMainMethod([helloStatement]);
        classModel.Members.Add(main);
        
        var programClassType = _classBuilder.BuildTypeForClass(classModel);

        var codeNamespace = new CodeNamespace();
        codeNamespace.Types.Add(programClassType);
        var fileModel = _generator.GenerateCodeForType(programClassType, RootNamespace);

        return fileModel;
    }

    /// <summary>
    /// Builds a <see cref="CodeMemberMethod"/> that defines a <c>Main</c> entry point method for an application.
    /// </summary>
    private CodeMemberMethod BuildMainMethod(CodeStatementCollection statements)
    {
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