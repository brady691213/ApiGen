using System.Reflection;

namespace Reflection;

public class PropertyReflector
{
    public PropertyModel GetPropertyModel(PropertyInfo info)
    {
        // TASKT: Map typename to keyword.
        // TASKT: Map Nullable<T> to T?

        var model = new PropertyModel(info.PropertyType.Name, info.Name);
        model.TypeDeclaration = BuildTypeDeclaration(info.PropertyType);
        if (IsMarkedAsNullable(info))
        {
            model.TypeDeclaration += "?";
        }

        return model;
    }

    private string BuildTypeDeclaration(Type propType)
    {
        if (!propType.IsGenericType)
        {
            return propType.Name;
        }

        var names = new List<string>();
        foreach (var genericTypeArgument in propType.GenericTypeArguments)
        {
            names.Add(BuildTypeDeclaration(genericTypeArgument));
        }

        return $"{propType.Name.Split('`')[0]}<{string.Join(",", names)}>";
    }
    
    bool IsMarkedAsNullable(PropertyInfo p)
    {
        // https://stackoverflow.com/a/72586919/8741
        // Comment adds to check ReadState not WriteState, for get only. Maybe check for each method.
        return new NullabilityInfoContext().Create(p).WriteState is NullabilityState.Nullable;
    }

    private string GetTypeAlias(Type type)
    {
        var alias = _typeAliasLookup.SingleOrDefault(p => p.Value == type).Key;
        return alias ?? type.Name;
    }

    private string? GetFullTypeName(string alias)
    {
        _typeAliasLookup.TryGetValue(alias, out Type? type);
        return type?.Name;
    }

    private string GetAliasForNullable(string nullableTypeName)
    {
        var groups = nullableTypeRx.Match(nullableTypeName).Groups;
        return groups["0"].Captures[0].Value;

    }
}