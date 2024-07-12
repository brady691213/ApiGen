using System.Reflection;

namespace Reflection;

public class PropertyReflector
{
    public PropertyModel GetPropertyModel(PropertyInfo info)
    {
        // TASKT: Map typename to keyword.

        var model = new PropertyModel(info.PropertyType.Name, info.Name);
        model.TypeParameters = info.PropertyType.GenericTypeArguments.ToList();

        return model;
    }
}