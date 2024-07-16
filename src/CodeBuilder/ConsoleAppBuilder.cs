using System.CodeDom;

namespace CodeBuilder;

public class ConsoleAppBuilder : ClassBuilder
{
    public void BuildHelloWorldApp(string outputPath)
    {
        var projectName = "HelloWorld";

        // For now, we just use the project name as a solution name and path.
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

        var code = BuildProgramClass();
        var projectModel = new ProjectModel(projectName);
        
        var projectBuilder = new ProjectBuilder();
        var projectFileText = projectBuilder.BuildProjectDefinition(projectModel);        
        File.WriteAllText($"{projectPath}/{projectName}.csproj", projectFileText);
        
        var slnBuilder = new SolutionBuilder();
        var slnDef = slnBuilder.BuilSolutionDefintion([projectModel]);
        File.WriteAllText(solutionPath, slnDef);
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
}