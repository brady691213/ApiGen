using System.Reflection;
using Reflection;

namespace SourceBuilder;

public class PropertyBuilder
{
    // TASKT: Make this part of an IOptions read from config.
    internal bool SkipTypeAliasing = false;
    
    public PropertyModel PropertyModelFromInfo(PropertyInfo info)
    {
        // TASKT: Map Nullable<T> to T?

        var model = new PropertyModel(info.PropertyType.Name, info.Name);
        model.TypeString = BuildTypeDeclaration(info.PropertyType);
        model.ExposingTypeName = info.DeclaringType?.Name;

        if (IsMarkedAsNullable(info))
        {
            model.TypeString += "?";
        }

        return model;
    }
    
    internal string? BuildTypeDeclaration(Type propType)
    {
        if (!propType.IsGenericType)
        {
            // if (propType.Name.EndsWith("[]"))
            // {
            //     return TypeAliasing.GetAliasForType(propType.Name.Replace("[]", "");
            // }
            return TypeAliasing.GetAliasForType(propType);
        }

        var typenameParts = propType.Name.Split('`');
        if (typenameParts.Length > 1 && typenameParts[0] == "Nullable")
        {
            return TypeAliasing.GetAliasForType(propType.GenericTypeArguments[0]) + "?";
        }
        
        var names = new List<string?>();
        foreach (var genericTypeArgument in propType.GenericTypeArguments)
        {
            names.Add(BuildTypeDeclaration(genericTypeArgument));
        }

        return $"{typenameParts[0]}<{string.Join(",", names)}>";
    }
    
    public bool IsMarkedAsNullable(PropertyInfo p)
    {
        // https://stackoverflow.com/a/72586919/8741
        // Comment adds to check ReadState not WriteState, for get only. Maybe check for each method.
        return new NullabilityInfoContext().Create(p).WriteState is NullabilityState.Nullable;
    }
}