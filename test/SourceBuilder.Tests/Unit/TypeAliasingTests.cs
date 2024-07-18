using Reflection;
using Shouldly;
using Xunit;

namespace SourceBuilder.Tests.Unit;

public class TypeAliasingTests
{
    [Theory]
    [ClassData(typeof(SimpleTypeToAliasTheoryData))]
    public void CorrectAliasForSimpleType(Type type, string expected)
    {
        var actualAlias = CSharpTypeMaps.GetAliasForType(type);
        actualAlias.ShouldBe(expected);
    }
    
    [Theory]
    [ClassData(typeof(ArrayTypeToAliasTheoryData))]
    public void CorrectAliasForSimpleArrayType(Type type, string expected)
    {
        var actualAlias = CSharpTypeMaps.GetAliasForType(type);
        actualAlias.ShouldBe(expected);
    }
    
    private class SimpleTypeToAliasTheoryData: TheoryData<Type, string>
    {
        public SimpleTypeToAliasTheoryData()
        {
            foreach (var kvp in CSharpTypeMaps.TypeKeyedLookup)
            {
                Add(kvp.Key, kvp.Value);
            }
        }
    }
    
    private class ArrayTypeToAliasTheoryData: TheoryData<Type, string>
    {
        public ArrayTypeToAliasTheoryData()
        {
            foreach (var kvp in CSharpTypeMaps.TypeKeyedLookup)
            {
                var arrayType = Type.GetType($"System.{kvp.Key.Name}[]");
                arrayType.ShouldNotBeNull();
                Add(arrayType, kvp.Value);
            }
        }
    }
}