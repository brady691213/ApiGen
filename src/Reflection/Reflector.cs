using System.Reflection;
using Microsoft.EntityFrameworkCore;
namespace Reflection;

/// <summary>
/// Provides functionality to extract EF entity type information from compiled <see cref="DbContext"/> classes.
/// </summary>
public class Reflector
{
    private AssemblyLoader _asmLoader = new();
    
    /// <summary>
    /// Gets a collection of all entity types, i.e. models, defined in a given <see cref="DbContext"/>.
    /// </summary>
    /// <param name="dbContextType">DbContext type to read entity types from.</param>
    /// <remarks>
    /// Gets all entity types used to define <see cref="DbSet{TEntity}"/> properties in
    /// type <paramref name="dbContextType"/> providing this class is defined an assembly that is referenced
    /// by this assembly.
    /// </remarks>
    public IEnumerable<Type> GetEntityTypes(Type dbContextType)
    {
        var props = dbContextType.GetProperties();
        var dbsetTypeName = typeof(DbSet<>).Name;
        
        var dbSets = dbContextType.GetProperties()
            .Where(p => p.PropertyType.IsGenericType &&
                        p.PropertyType.GetGenericTypeDefinition().Name == dbsetTypeName)
            .Select(p => p.PropertyType.GetGenericArguments().First());

        return dbSets;
    }

    /// <summary>
    /// Gets a collection of all entity types, i.e. models, defined in a named <see cref="DbContext"/>.
    /// </summary>
    /// <param name="assemblyPath">Path to the assembly file inm which the class with name
    /// <paramref name="dbContextName"/>.</param>
    /// <param name="dbContextName">Name of the DbContext class to read entity types from.</param>
    /// <remarks>
    /// Gets all entity types used to define <see cref="DbSet{TEntity}"/> properties in
    /// the class with name <paramref name="dbContextName"/> providing this class is defined the assembly file located
    /// at <paramref name="assemblyPath"/>.
    /// </remarks>
    public IEnumerable<Type> GetEntityTypesFromAssembly(string assemblyPath, string dbContextName)
    {
        var dbsetTypeName = typeof(DbSet<>).Name;
        var dbct = GetDbContextType(assemblyPath, dbContextName);
        var dbSets = dbct.GetProperties()
            .Where(p => p.PropertyType.IsGenericType &&
                        p.PropertyType.GetGenericTypeDefinition().Name == dbsetTypeName)
            .Select(p => p.PropertyType.GetGenericArguments().First());

        return dbSets;
    }
    
    /// <summary>
    /// Returns a <see cref="Type"/> for a <see cref="DbContext"/> class given an assembly path and class name.
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
    /// Gets a collection of <see cref="PropertyInfo"/> objects representing the public properties of
    /// <paramref name="entityType"/>.
    /// </summary>
    /// <param name="entityType">Entity type to get properties for.</param>
    public IEnumerable<PropertyInfo> GetEntityProperties(Type entityType)
    {
        var baseFlags = BindingFlags.Public | BindingFlags.Instance;

        return entityType.GetProperties(baseFlags | BindingFlags.DeclaredOnly);
    }
}

