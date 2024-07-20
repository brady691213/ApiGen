namespace CodeGenerators;

public class ParameterModel(Type type, string name)
{
    public Type Type { get; set; } = type;

    public string Name { get; set; } = name;
}