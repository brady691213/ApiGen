using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;

namespace CodeScaffolding;

/// <summary>
/// Builds classes and other type defintoions based on input obtained from Reflection.
/// </summary>
public class ClassBuilder
{
    private CodeDomProvider _provider = CodeDomProvider.CreateProvider("CSharp");
    private CodeGeneratorOptions _generateOptions = new();

    /// <summary>
    /// Builds C# classes as text using the <see cref="System.CodeDom"/> tooling.
    /// </summary>
    public ClassBuilder()
    {
        _generateOptions.BracingStyle = "C";
    }
    
    /// <summary>
    /// Builds a simple C# class without any members.
    /// </summary>
    /// <returns>A <see cref="CodeTypeDeclaration"/> that defines an empty class.</returns>
    public CodeTypeDeclaration BuildClass(string className, TypeAttributes classAttributes = TypeAttributes.Public)
    {
        var outClass = new CodeTypeDeclaration(className)
        {
            IsClass = true,
            TypeAttributes = classAttributes
        };
        return outClass;
    }

    /// <summary>
    /// Builds a <c>Main</c> method as used an entry point in console apps.
    /// </summary>
    /// <returns>A <see cref="CodeMemberMethod"/> that defines a <c>Main</c> method.</returns>
    public CodeMemberMethod BuildMainMethod(CodeStatementCollection? statements = null, MemberAttributes? methodAttributes = null)
    {
        // TASKT: Refgactor into BuildMethod.
        var mainMethod = new CodeMemberMethod
        {
            Name = "Main",
            Attributes = methodAttributes ?? MemberAttributes.Static | MemberAttributes.Public
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

    /// <summary>
    /// Generates C# code for given namespaces.
    /// </summary>
    public string GenerateCSharpCode(CodeNamespace[] namespaces)
    {
        var compileUnit = new CodeCompileUnit();
        compileUnit.Namespaces.AddRange(namespaces);
        
        using var sourceWriter = new StringWriter();
        _provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, _generateOptions);
        return sourceWriter.ToString();
    }
    
    public string GenerateClassCode(ClassModel model)
    {
        var compileUnit = new CodeCompileUnit();
        var ns = BuildNamespace(model.ClassName);
        compileUnit.Namespaces.Add(ns);
        
        using var sourceWriter = new StringWriter();
        _provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, _generateOptions);
        return sourceWriter.ToString();
    }
}