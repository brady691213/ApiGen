using System.CodeDom;

namespace CodeGenerators.CodeDom;

public class Namespaces
{
    public static CodeNamespace BuildCodeNamespace(string name)
    {
        var ns = new CodeNamespace(name);
        return ns;
    }
}