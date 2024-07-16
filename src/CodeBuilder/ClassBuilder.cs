using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;

namespace CodeBuilder;

public class ClassBuilder
{
    private CodeDomProvider _provider = CodeDomProvider.CreateProvider("CSharp");
    private CodeGeneratorOptions _generateOptions = new CodeGeneratorOptions();

    public ClassBuilder()
    {
        _generateOptions.BracingStyle = "C";
    }
    
    public CodeTypeDeclaration BuildClass(string className)
    {
        var programClass = new CodeTypeDeclaration(className);
        programClass.IsClass = true;
        programClass.TypeAttributes = TypeAttributes.Public;
        return programClass;
    }

    public CodeMemberMethod BuildMainMethod(CodeStatementCollection? statements = null)
    {
        var mainMethod = new CodeMemberMethod
        {
            Name = "Main",
            Attributes = MemberAttributes.Static | MemberAttributes.Public
        };
        mainMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string[]), "args"));

        if (statements == null)
        {
            mainMethod.Statements.Add(new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("System.Console"),
                "WriteLine",
                new CodePrimitiveExpression("Hello world")));
        }

        return mainMethod;
    }

    public CodeNamespace BuildNamespace(string name, List<string>? addImports = null)
    {
        var ns = new CodeNamespace(name);
        var imports = addImports ?? ["System"];
        ns.Imports.AddRange(imports
            .Where(i => i != "System").Select(i => new CodeNamespaceImport(i))
            .ToArray());
        return ns;
    }

    public string GenerateCSharpCode(CodeNamespace[] namespaces)
    {
        var compileUnit = new CodeCompileUnit();
        compileUnit.Namespaces.AddRange(namespaces);
        
        using var sourceWriter = new StringWriter();
        _provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, _generateOptions);
        return sourceWriter.ToString();
    }
}