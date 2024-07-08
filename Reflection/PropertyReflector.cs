using System.Reflection;

namespace Reflection.Tests;

public class PropertyReflector
{
    public IEnumerable<PropertyDef> GetEntityProperties(Type entityType)
    {
        var baseFlags = BindingFlags.Public | BindingFlags.Instance;

        var declared = entityType.GetProperties(baseFlags | BindingFlags.DeclaredOnly)
            .Select(info => new PropertyDef
            {
                TypeName = info.PropertyType.Name,
                PropertyName = info.Name
            });
    }
}