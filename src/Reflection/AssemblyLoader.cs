using System.Reflection;
using System.Runtime.InteropServices;

namespace Reflection;

public class AssemblyLoader
{
    /// <summary>
    /// Load an <see cref="Assembly"/> object from a compiled assembly located on the file system.
    /// </summary>
    /// <param name="assemblyPath">File path of the assembly to load.</param>
    /// <remarks>
    /// Uses a <see cref="MetadataLoadContext"/> so that we can load the assembly metadata required for reflection
    /// without actually referencing the assembly and thus loading it into the runtime.
    /// <see cref="https://learn.microsoft.com/en-us/dotnet/standard/assembly/inspect-contents-using-metadataloadcontext">Inspect assembly contents using MetadataLoadContext</see>
    /// </remarks>
    public Assembly LoadAssembly(string assemblyPath)
    {
        string[] runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
        var paths = new List<string>(runtimeAssemblies);
        paths.Add(assemblyPath);
        
        // Getting exception that Microsoft.EntityFrameworkCore asm not found. So this:
        var efcPath = typeof(Microsoft.EntityFrameworkCore.ModelBuilder).Assembly.Location;
        paths.Add(efcPath);
        
        var resolver = new PathAssemblyResolver(paths);
        var mlc = new MetadataLoadContext(resolver);

        var asm = mlc.LoadFromAssemblyPath(assemblyPath);

        return asm;
    }
}