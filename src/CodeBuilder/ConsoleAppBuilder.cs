using System.CodeDom;
using System.Reflection;

namespace CodeBuilder;

public class ConsoleAppBuilder : CodeBuilder
{
    public string BuildHelloWorldApp()
    {
        var rootNamespace = new CodeNamespace("HelloWorldApp");
        rootNamespace.Imports.Add(new CodeNamespaceImport("System"));
        var programClass = BuildProgramClass();
        
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
        
        programClass.Members.Add(mainMethod);
        rootNamespace.Types.Add(programClass);
        CompileUnit.Namespaces.Add(rootNamespace);

        var code = GenerateCSharpCode();
        return code;
    }

    private CodeTypeDeclaration BuildProgramClass()
    {
        var programClass = new CodeTypeDeclaration("Program");
        programClass.IsClass = true;
        programClass.TypeAttributes = TypeAttributes.Public;
        return programClass;
    }

    // Create the Main method
    private CodeMemberMethod BuildMain()
    {
        var main = new CodeMemberMethod
        {
            Name = "Main",
            Attributes = MemberAttributes.Static | MemberAttributes.Public,
            ReturnType = new CodeTypeReference(typeof(void))
        };
        return main;
    }

    private void AddEntryPoint(CodeTypeDeclaration entryPointClass)
    {
        CodeEntryPointMethod main = new CodeEntryPointMethod();
        main.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string[]), "args"));

        var helloString = new CodePrimitiveExpression("Hello world");

        main.Statements.Add(new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression("System.Console"),
            "WriteLine", helloString));
        entryPointClass.Members.Add(main);
    }
}