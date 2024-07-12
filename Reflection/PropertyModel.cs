namespace Reflection;

/// <summary>
/// Models information required to generate a property declaration.
/// </summary>
/// <param name="typeName">Type of the property to declare.</param>
/// <param name="propertyName">Name of the property to declare.</param>
/// <remarks>
/// Used to build a simple C# property declaration like the following:
/// <code>
/// public <paramref name="typeName"/> <paramref name="propertyName"/> { get; set; }
/// </code>
/// </remarks>
public class PropertyModel(string typeName, string propertyName)
{
    public string TypeName { get; set; } = typeName;

    public string PropertyName { get; set; } = propertyName;
    
    public List<Type> TypeParameters { get; set; } = [];
    
    public string BuildPropertyDeclaration()
    {
        if (TypeParameters.Count == 0)
        {
            return typeName;
        }
        
        var typeParts = TypeName.Split('`');
        var gtps = string.Join(",", TypeParameters);
        return $"{typeParts[0]}<{gtps}>";
    }

    // private string GetGenericDec(Type type)
    // {
    //     var typeParts = type.Name.Split('`');
    //     var tpNames = type.GenericTypeArguments.Select(t => t.Name);
    //
    //
    // }
}