namespace CodeGenerators.Models;

public record PropertyModel(string TypeAlias, string Name)
{
    public string TypeAlias { get; set; } = TypeAlias;

    public string Name { get; set; } = Name;
}