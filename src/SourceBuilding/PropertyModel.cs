namespace SourceBuilding;

/// <summary>
/// Models information required to generate a property declaration.
/// </summary>
/// <param name="typeString">String describing the property's type.</param>
/// <param name="name">Name of a property.</param>
public class PropertyModel(string typeString, string name, Type? declaringType)
{
    public string TypeString { get; set; } = typeString;

    public string Name { get; set; } = name;

    public Type? DeclaringType { get; set; } = declaringType;
}