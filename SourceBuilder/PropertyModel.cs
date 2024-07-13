using System.Reflection;
using Reflection;

namespace SourceBuilder;

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
    private TypeAliasing _propertyReflector = new();
    
    public string TypeDeclaration { get; set; } 

    public string PropertyName { get; set; } = propertyName;
    

}