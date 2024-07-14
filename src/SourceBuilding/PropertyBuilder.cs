using System.Reflection;
using Reflection;

namespace SourceBuilding;

public class PropertyBuilder
{
    public PropertyModel PropertyModelFromInfo(PropertyInfo info)
    {
        var typeString = BuildTypeString(info.PropertyType) + (IsMarkedAsNullable(info) ? "?" : "");
        var model = new PropertyModel(typeString, info.Name, info.DeclaringType);

        return model;
    }

    private string BuildTypeString(Type propType)
    {
        if (!propType.IsGenericType)
        {
            return CSharpTypeInformation.GetAliasForType(propType);
        }

        var typenameParts = propType.Name.Split('`');
        if (typenameParts.Length > 1 && typenameParts[0] == "Nullable")
        {
            return CSharpTypeInformation.GetAliasForType(propType.GenericTypeArguments[0]) + "?";
        }
        
        var names = propType.GenericTypeArguments
            .Select(BuildTypeString)
            .ToList();

        return $"{typenameParts[0]}<{string.Join(",", names)}>";
    }

    private bool IsMarkedAsNullable(PropertyInfo p)
    {
        // https://stackoverflow.com/a/72586919/8741
        // Comment adds to check ReadState not WriteState, for get only. Maybe check for each method.
        return new NullabilityInfoContext().Create(p).WriteState is NullabilityState.Nullable;
    }
}