namespace CodeGenerators;

public record PropertyModel(string typeAlias, string name)
{
    public string TypeAlias { get; set; } = typeAlias;

    public string Name { get; set; } = name;
}