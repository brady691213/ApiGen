using System.CodeDom;
using System.Reflection;

namespace CodeBuilder;

public class ConsoleAppBuilder : CodeBuilder
{
    public void BuildApp()
    {
        var program = BuildProgramClass();
        AddEntryPoint(program);
        var code = GenerateCSharpCode();
        
        Console.WriteLine(code);
    }

    private CodeTypeDeclaration BuildProgramClass()
    {
        var programClass = new CodeTypeDeclaration("Program");
        programClass.IsClass = true;
        programClass.TypeAttributes = TypeAttributes.Public;
        return programClass;
    }

    private void AddEntryPoint(CodeTypeDeclaration entryPointClass)
    {
        CodeEntryPointMethod main = new CodeEntryPointMethod();

        var hello = new CodePrimitiveExpression("Hello world");

        main.Statements.Add(new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression("System.Console"),
            "WriteLine", hello));
        entryPointClass.Members.Add(main);
    }

    private string BuildProjectDefinition()
    {
        var model = new ProjectFileModel();
        model.RepriseVersion = "0.0.1";

        var template = TemplateLoader.LoadCsprojTemplate();
        var pjfText = template.Render(new { model = model });

        return pjfText;
    }
}