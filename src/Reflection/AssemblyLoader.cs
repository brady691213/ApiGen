using System.Reflection;
using System.Runtime.InteropServices;

namespace Reflection;

public class AssemblyLoader
{
    public Assembly LoadAssembly(string assemblyPath)
    {
        // Following docs at: https://learn.microsoft.com/en-us/dotnet/standard/assembly/inspect-contents-using-metadataloadcontext
        
        string[] runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
        var paths = new List<string>(runtimeAssemblies);
        paths.Add(assemblyPath);
        
        // Getting exeption that Microsoft.EntityFrameworkCore asm not found. So this:
        var efcPath = typeof(Microsoft.EntityFrameworkCore.ModelBuilder).Assembly.Location;
        paths.Add(efcPath);
        
        var resolver = new PathAssemblyResolver(paths);
        var mlc = new MetadataLoadContext(resolver);

        var asm = mlc.LoadFromAssemblyPath(assemblyPath);

        return asm;
    }
}