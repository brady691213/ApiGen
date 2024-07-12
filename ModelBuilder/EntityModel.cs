namespace EntityDecompiler;

public class EntityModel(string entityName, List<PropertyDeclaration> properties)
{
    public string EntityName { get; set; } = entityName;

    public List<PropertyDeclaration> Properties { get; set; } = properties;
}