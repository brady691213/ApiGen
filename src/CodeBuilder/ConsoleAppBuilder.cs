using System.CodeDom;

namespace CodeBuilder;

public class ConsoleAppBuilder : ClassBuilder
{
    public void BuildHelloWorldApp(string outputPath)
    {
        var code = BuildProgramClass();
        var project = BuildProjectDefinition();
        
        var projPath = $""        
        
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