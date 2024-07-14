using System.CodeDom;
using System.Reflection;

namespace CodeBuilder;

public class ConsoleAppBuilder: CodeBuilder
{
    public ConsoleAppBuilder()
    {
        var mainClass = new CodeTypeDeclaration("Program");
        mainClass.IsClass = true;
        mainClass.TypeAttributes = TypeAttributes.Public;

        AddEntryPoint(mainClass);
    }
    
    public void AddEntryPoint(CodeTypeDeclaration entryPointClass)
    {
        CodeEntryPointMethod main = new CodeEntryPointMethod();

        var hello = new CodePrimitiveExpression("Hello world");

        main.Statements.Add(new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression("System.Console"),
            "WriteLine", hello));
        entryPointClass.Members.Add(main);
    }
}