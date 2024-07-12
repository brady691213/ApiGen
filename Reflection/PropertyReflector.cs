using System.Reflection;

namespace Reflection;

public class PropertyReflector
{
    public PropertyModel GetPropertyModel(PropertyInfo info)
    {
        // TASKT: Map typename to keyword.

        var model = new PropertyModel(info.PropertyType.Name, info.Name);
        model.TypeDeclaration = BuildTypeDeclaration(info.PropertyType);

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

        return $"<{string.Join(",", names)}>";
    }
}