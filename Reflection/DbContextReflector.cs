using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Reflection;

public class DbContextReflector
{
    /// <summary>
    /// Gets a list of all entity types, i.e. models, defined in a given DbContext.
    /// </summary>
    /// <param name="dbContextType">Type that defines a DbContext to read entity types from.</param>
    /// <remarks>
    /// Gets all entity types used to define DbSet properties in type <paramref name="dbContextType"/>.
    /// </remarks>
    public IEnumerable<Type> GetDbSetTypes(Type dbContextType)
    {
        var dbSets = dbContextType.GetProperties()
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

        var assembly = Assembly.LoadFrom(assemblyPath);
        var dbContextType = assembly.GetTypes().FirstOrDefault(t => t.Name == dbContextName && typeof(DbContext).IsAssignableFrom(t));
        
        if (dbContextType == null)
        {
            throw new ArgumentException($"DbContext with name '{dbContextName}' not found in assembly {assembly.GetName()}");
        }

        return dbContextType;
    }
}

