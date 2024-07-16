namespace SourceBuilding;

/// <summary>
/// Models information required to generate a type declaration for a REPR type DTO.
/// </summary>
/// <param name="dtoName">The type name for the DTO.</param>
/// <param name="properties">Properties for the DTO.</param>
/// <remarks>
/// The <paramref name="properties"/> only defines the properties of the modelled DTO that map to business entities
/// and nbt properties used by the APi itself or by API generation tools.
/// </remarks>
public class DtoModel(string dtoName, List<PropertyModel> properties)
{
    public DtoDirection DtoDirection { get; set; }
    
    public string TypeName { get; set; } = dtoName;

    public List<PropertyModel> Properties { get; set; } = properties;
}