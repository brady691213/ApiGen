using System.CodeDom;
using System.CodeDom.Compiler;

namespace CodeGenerators.CodeDom;

/// <summary>
/// Uses the <seealso cref="CodeDom"/> namespace functionality to generate C# code.
/// </summary>
public class CodeDomSourceGenerator
{
    private readonly CodeDomProvider _provider = CodeDomProvider.CreateProvider("CSharp");
    private readonly CodeGeneratorOptions _generatorOptions = new()
    {
        IndentString = null,
        BracingStyle = "C",
        ElseOnClosing = false,
        BlankLinesBetweenMembers = false,
        VerbatimOrder = false
    };

    /// <summary>
    /// Generates C# code for a <see cref="CodeTypeDeclaration"/>.
    /// </summary>
    public CodeFileModel GenerateCodeForType(CodeTypeDeclaration classType, string? namespaceName)
    {
        var compileUnit = new CodeCompileUnit();
        var compileNamespace = namespaceName ?? classType.Name;
        var codeNamespace = BuildNamespace(compileNamespace);
        codeNamespace.Types.Add(classType);
        compileUnit.Namespaces.Add(codeNamespace);
        
        using var sourceWriter = new StringWriter();
        _provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, _generatorOptions);
        return new CodeFileModel(classType.Name, sourceWriter.ToString());
    }

    /// <summary>
    /// Builds a containing <seealso cref="CodeNamespace"/> for use in code generation.
    /// </summary>
    private CodeNamespace BuildNamespace(string name, List<string>? addImports = null)
    {
        var codeNamespace = new CodeNamespace(name);
        var imports = addImports ?? ["System"];
        codeNamespace.Imports.AddRange(imports
            .Where(i => i != "System").Select(i => new CodeNamespaceImport(i))
            .ToArray());
        return codeNamespace;
    }
}