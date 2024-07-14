using Reflection.Tests.Types;
using Shouldly;
using SourceBuilding;
using Xunit;

namespace SourceBuilder.Tests.Unit;

public class PropertyModelTests
{
    private readonly PropertyBuilder _propertyBuilder = new();
    private readonly DtoBuilder _dtoBuilder = new();
    private readonly Type _genericType = typeof(TypesForPropertyBuilderTests);
    
    //[Theory]
    
    
    [Fact]
    public void TypeStringForNestedGenericIsValid()
    {
        var expectedDec = "List<Nullable<int>>";
        var nullableProp = _genericType.GetProperty(nameof(TypesForPropertyBuilderTests.NullableWithNullableNestedGeneric));

        var model = _propertyBuilder.PropertyModelFromInfo(nullableProp!);

        var actualDec = model.TypeString;
        actualDec.ShouldBe(expectedDec);
    }

    [Fact]
    public void TypeStringForNullableIsValid()
    {
        
    }
    
    [Fact]
    public void NestedGenericNullableTypeDecIsValid()
    {
        var nullableProp = _genericType.GetProperty(nameof(TypesForPropertyBuilderTests.NullableWithNullableGenericParam));
        var expectedDec = "List<Nullable<int>>?";

        var model = _propertyBuilder.PropertyModelFromInfo(nullableProp!);
        
        var actualDec = model.TypeString;
        actualDec.ShouldBe(expectedDec);
    }
}