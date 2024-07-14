using Reflection;

namespace SourceBuilder;

/// <summary>
/// Models information required to generate a class declaration for a DTO.
/// </summary>
/// <param name="typeName">The type name for the DTO.</param>
/// <param name="properties">Properties for the DTO.</param>
/// <remarks>
/// The <paramref name="properties"/> only defines the properties of the modelled DTO that map to business entities
/// and nbt properties used by the APi itself or by API generation tools.
/// </remarks>
public class EntityModel(string typeName, List<PropertyModel> properties)
{
    public string EntityName { get; set; } = typeName;

    public List<PropertyModel> Properties { get; set; } = properties;
}