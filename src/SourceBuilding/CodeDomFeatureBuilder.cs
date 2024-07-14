using System.CodeDom;

namespace SourceBuilding;

public class CodeDomFeatureBuilder
{
    private string rootNamespaceName = "HelloReprise";
    
    private CodeCompileUnit _compileUnit = new();

    public void BuildReprResponse()
    {
        var ns = new CodeNamespace($"{rootNamespaceName}.Features.HelloWorld");
        _compileUnit.Namespaces.Add(ns);

        var respClass = new CodeTypeDeclaration($"HelloWorldRequest");
        ns.Types.Add(respClass);
    } 
}