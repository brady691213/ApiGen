using System.CodeDom;
using System.CodeDom.Compiler;

namespace CodeGenerators.CodeElements;

public class CSharpCodeGenerator
{
    private CodeDomProvider _provider = CodeDomProvider.CreateProvider("CSharp");
    private CodeGeneratorOptions _generatorOptions = new();

    public CSharpCodeGenerator()
    {
        _generatorOptions = new()
        {
            BracingStyle = "C"
        };
    }
    
    /// <summary>
    /// Generates C# code for a collection of namespaces that contain classes and other types.
    /// </summary>
    public string GenerateCodeForNamespaces(CodeNamespace[] namespaces)
    {
        var compileUnit = new CodeCompileUnit();
        compileUnit.Namespaces.AddRange(namespaces);
        
        using var sourceWriter = new StringWriter();
        _provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, _generatorOptions);
        return sourceWriter.ToString();
    }
    
    /// <summary>
    /// Generates C# code for a class, based on a <see cref="ClassModel"/>.
    /// </summary>
    // TASKT: Pass a ClassModel here.
    public CodeFileModel GenerateCodeForClass(CodeTypeDeclaration classType, string? classNamespace)
    {
        var compileUnit = new CodeCompileUnit();
        var compileNamespace = classNamespace ?? classType.Name;
        var ns = BuildNamespace(compileNamespace);
        compileUnit.Namespaces.Add(ns);
        
        using var sourceWriter = new StringWriter();
        _provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, _generatorOptions);

        var model = new CodeFileModel($"{classType.Name}.cs", sourceWriter.ToString());

        return model;
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
}