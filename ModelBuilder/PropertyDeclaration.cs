namespace EntityDecompiler;

public class PropertyDeclaration(string typeName, string propertyName)
{
    public string TypeName { get; set; } = typeName;

    public string PropertyName { get; set; } = propertyName;
}