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
        model.TypeDeclaration = BuildTypeDeclaration(info.PropertyType);

        if (IsMarkedAsNullable(info))
        {
            model.TypeDeclaration += "?";
        }

        return model;
    }
    
    internal string? BuildTypeDeclaration(Type propType)
    {
        if (!propType.IsGenericType)
        {
            return SkipTypeAliasing ? propType.Name : TypeAliasing.GetAliasForType(propType);
        }

        var typenameParts = propType.Name.Split('`');
        
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