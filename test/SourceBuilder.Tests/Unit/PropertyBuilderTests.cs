using Reflection;
using Shouldly;
using Xunit;

namespace SourceBuilder.Tests.Unit;

public class PropertyBuilderUnitTests
{
    [Theory]
    [ClassData(typeof(TypeStringForSimpleTypeTheoryData))]
    public void CorrectTypeStringForSimpleTypes()
    {
        
    }
    
    
    private class TypeStringForSimpleTypeTheoryData: TheoryData<Type, string>
    {
        public TypeStringForSimpleTypeTheoryData()
        {
            foreach (var kvp in CSharpTypeMaps.TypeKeyedLookup)
            {
                Add(kvp.Key, kvp.Value);
            }
        }
    }
    
    private class TypeStringForNullableTheoryData: TheoryData<Type, string>
    {
        public TypeStringForNullableTheoryData()
        {
            foreach (var kvp in CSharpTypeMaps.TypeKeyedLookup)
            {
                var nullableType = Type.GetType($"System.{kvp.Key}?");
                nullableType.ShouldNotBeNull();
                Add(nullableType, kvp.Value);
            }
        }
    }

}