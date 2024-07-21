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
    /// Generates C# code for a Type, based on a <see cref="CodeTypeDeclaration"/>.
    /// </summary>
    public CodeFileModel GenerateCodeForType(CodeTypeDeclaration classType, string? classNamespace)
    {
        var compileUnit = new CodeCompileUnit();
        var compileNamespace = classNamespace ?? classType.Name;
        var ns = BuildNamespace(compileNamespace);
        ns.Types.Add(classType);
        
        using var sourceWriter = new StringWriter();
        _provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, _generatorOptions);
        return new CodeFileModel(classType.Name, sourceWriter.ToString());
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