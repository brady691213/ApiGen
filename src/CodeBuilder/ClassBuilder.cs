using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;

namespace CodeBuilder;

public class ClassBuilder
{
    private CodeDomProvider _provider = CodeDomProvider.CreateProvider("CSharp");
    protected CodeCompileUnit CompileUnit = new();
    protected CodeNamespace ClassNamespace;
    protected CodeGeneratorOptions GenerateOptions = new CodeGeneratorOptions();
    protected CodeTypeDeclaration ProgramClass;

    protected ClassBuilder()
    {
        ClassNamespace = new CodeNamespace("HelloWorldApp");
        ClassNamespace.Imports.Add(new CodeNamespaceImport("System"));
        ProgramClass = BuildClass();
        
        GenerateOptions.BracingStyle = "C";
    }
    
    private CodeTypeDeclaration BuildClass()
    {
        var programClass = new CodeTypeDeclaration("Program");
        programClass.IsClass = true;
        programClass.TypeAttributes = TypeAttributes.Public;
        return programClass;
    }

    protected string GenerateCSharpCode()
    {
        ClassNamespace.Types.Add(ProgramClass);
        CompileUnit.Namespaces.Add(ClassNamespace);
        
        using var sourceWriter = new StringWriter();
        _provider.GenerateCodeFromCompileUnit(CompileUnit, sourceWriter, GenerateOptions);
        return sourceWriter.ToString();
    }
}