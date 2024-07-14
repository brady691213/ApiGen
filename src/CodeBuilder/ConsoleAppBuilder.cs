using System.CodeDom;
using System.Reflection;

namespace CodeBuilder;

public class ConsoleAppBuilder : ClassBuilder
{
    public string BuildHelloWorldApp()
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