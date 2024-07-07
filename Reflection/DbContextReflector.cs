using System.Reflection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Reflection;

public class DbContextReflector
{
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
    
    /// <summary>
    /// Gets a list of all entity types used to define DbSet properties in a given DbContext type.
    /// </summary>
    /// <param name="assemblyPath"></param>
    /// <param name="dbContextName"></param>
    /// <returns></returns>
    /// <exception cref="FileNotFoundException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public List<string> GetDbSetEntities(Type dbContextType)
    {
 

        var entitySets = dbContextType.GetProperties()
            .Where(p => p.PropertyType.IsGenericType &&
                        p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
            .Select(p => p.Name)
            .ToList();

        return entitySets;
    }
    
    
}

