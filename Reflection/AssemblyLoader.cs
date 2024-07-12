using System.Reflection;

namespace Reflection;

public class AssemblyLoader
{
    public Assembly LoadAssembly(string assemblyPath)
    {
        var resolver = new PathAssemblyResolver(new string[] { "ExampleAssembly.dll", typeof(object).Assembly.Location });
        var mlc = new MetadataLoadContext(resolver);

        var asm = mlc.LoadFromAssemblyPath(assemblyPath);

        return asm;
    }
}