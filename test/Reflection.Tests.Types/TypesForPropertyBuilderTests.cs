namespace Reflection.Tests.Types;

public class TypesForPropertyBuilderTests
{
    public string EasyString { get; set; } = null!;

    public string? NullableEasyString { get; set; }
    
    public List<int?>? NullableWithNullableGenericParam { get; set; }
    
    public List<Dictionary<int, string?>>? NullableWithNullableNestedGeneric { get; set; }
}