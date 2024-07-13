using Shouldly;

namespace Reflection.Tests.Unit;

public class TypeAliasingTests
{
    [Theory]
    [ClassData(typeof(AliasToTypeTheoryData))]
    public void CorrectTypeForAlias(string alias, Type expected)
    {
        var actualType = TypeAliasing.GetTypeForAlias(alias);
        
        actualType.ShouldBe(expected);
    }
    
    [Theory]
    [ClassData(typeof(TypeToAliasTheoryData))]
    public void CorrectAliasForType(Type type, string expected)
    {
        var actualAlias = TypeAliasing.GetAliasForType(type);
        
        actualAlias.ShouldBe(expected);
    }
}