using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Reflection;

public class DbContextReflector
{
    private AssemblyLoader _asmLoader = new();
    
    /// <summary>
    /// Gets a collection of all entity types, i.e. models, defined in a given DbContext.
    /// </summary>
    /// <param name="dbContextType">Type that defines a DbContext to read entity types from.</param>
    /// <remarks>
    /// Gets all entity types used to define DbSet properties in type <paramref name="dbContextType"/>.
    /// </remarks>
    public IEnumerable<Type> GetDbSetTypes(Type dbContextType)
    {
        var props = dbContextType.GetProperties();
        var dbsetTypeName = typeof(DbSet<>).Name;
        
        var dbSets = dbContextType.GetProperties()
            .Where(p => p.PropertyType.IsGenericType &&
                        p.PropertyType.GetGenericTypeDefinition().Name == dbsetTypeName)
            .Select(p => p.PropertyType.GetGenericArguments().First());

        return dbSets;
    }
    
    public IEnumerable<Type> GetDbSetTypesFromAssembly(string assemblyPath, Type dbContextType)
    {
        var asm = _asmLoader.LoadAssembly(assemblyPath);
        var dbct = GetDbContextType(assemblyPath, "CTSDBContext");
        var dbSets = dbct.GetProperties()
            .Where(p => p.PropertyType.IsGenericType &&
                        p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
            .Select(p => p.PropertyType.GetGenericArguments().First());

        return dbSets;
    }
    
    /// <summary>
    /// Returns a Type that defines a DbContext given an assembly path and DbContext name.
    /// </summary>
    /// <param name="assemblyPath">Path to an assembly that contains the DbContext.</param>
    /// <param name="dbContextName">Type name of the DbContext</param>
    public Type GetDbContextType(string assemblyPath, string dbContextName)
    {
        // TASKT: Replace exceptions with a Result pattern.
        if (!File.Exists(assemblyPath))
        {
            throw new FileNotFoundException($"Assembly not found at path: {assemblyPath}");
        }

        var loader = new AssemblyLoader();
        var assembly = loader.LoadAssembly(assemblyPath);
        
        // TASKQ: Why isn't this working with `&& typeof(DbContext).IsAssignableFrom(t)`?
        //var dbContextType = assembly.GetTypes().FirstOrDefault(t => t.Name == dbContextName && typeof(DbContext).IsAssignableFrom(t));
        var dbContextType = assembly.GetTypes().FirstOrDefault(t => t.Name == dbContextName);
        
        if (dbContextType == null)
        {
            throw new ArgumentException($"DbContext with name '{dbContextName}' not found in assembly {assembly.GetName()}");
        }

        return dbContextType;
    }
    
    /// <summary>
    /// Gets all public properties for a given entity.
    /// </summary>
    /// <param name="entityType">Entity type to get properties for.</param>
    /// <returns>A collection of <see cref="PropertyInfo"/> objects representing the public properties of <paramref name="entityType"/>.</returns>
    public IEnumerable<PropertyInfo> GetEntityProperties(Type entityType)
    {
        var baseFlags = BindingFlags.Public | BindingFlags.Instance;

        return entityType.GetProperties(baseFlags | BindingFlags.DeclaredOnly);
    }
}

