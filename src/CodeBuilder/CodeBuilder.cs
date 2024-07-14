using System.CodeDom;
using System.CodeDom.Compiler;

namespace CodeBuilder;

public class CodeBuilder
{
    private CodeDomProvider _provider = CodeDomProvider.CreateProvider("CSharp");
    protected CodeCompileUnit CompileUnit = new();
    protected CodeGeneratorOptions Options = new CodeGeneratorOptions();
    
    public CodeBuilder()
    {
        Options.BracingStyle = "C";
    }
    
    public string GenerateCSharpCode()
    {
        using var sourceWriter = new StringWriter();
        _provider.GenerateCodeFromCompileUnit(CompileUnit, sourceWriter, Options);

        return sourceWriter.ToString();
    }
    
}