namespace CodeGenerators.Models;

public record PropertyModel(Type PropertyType, string Name, bool IsReadonly = false, bool IsVirtual = false)
{
    public Type PropertyType { get; set; } = PropertyType;

    public string Name { get; set; } = Name;

    public bool IsReadonly { get; set; } = IsReadonly;

    public bool IsVirtual { get; set; } = IsVirtual;
}