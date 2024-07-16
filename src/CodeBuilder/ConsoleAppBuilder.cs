using System.CodeDom;

namespace CodeBuilder;

public class ConsoleAppBuilder : ClassBuilder
{
    public void BuildHelloWorldApp(string outputPath)
    {
        var projectName = "HelloWorld";
        var code = BuildProgramClass();
        var projectDef = BuildProjectDefinition();

        // TASKT: Just for now we use the project as a solution name and path.
        var solutionName = projectName;
        var solutionPath = $"{outputPath}/{solutionName}";
        var projectPath = $"{solutionPath}/src/{projectName}";

        if (Directory.Exists(solutionPath))
        {
            throw new InvalidOperationException(
                $"Solution path {solutionPath} already exists. `{nameof(outputPath)}` must specify a new directory.");
        }

        Directory.CreateDirectory(solutionPath);
        Directory.CreateDirectory($"{solutionPath}/src");
        Directory.CreateDirectory($"{solutionPath}/src/{projectName}");

        File.WriteAllText($"{projectPath}/{projectName}.csproj", projectDef);
    }

    private string BuildProgramClass()
    {
        var mainMethod = new CodeMemberMethod
        {
            Name = "Main",
            Attributes = MemberAttributes.Static | MemberAttributes.Public
        };
        mainMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string[]), "args"));
        mainMethod.Statements.Add(new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression("System.Console"),
            "WriteLine",
            new CodePrimitiveExpression("Hello world")));
        ProgramClass.Members.Add(mainMethod);

        var code = GenerateCSharpCode();
        return code;
    }

    private string BuildProjectDefinition()
    {
        var projectBuilder = new ProjectBuilder();
        return projectBuilder.BuildProjectFile("0.0.1", "net9.0");
    }
}