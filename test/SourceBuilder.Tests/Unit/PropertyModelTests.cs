using Reflection.Tests.Types;
using Shouldly;
using Xunit;

namespace SourceBuilder.Tests.Unit;

public class PropertyModelTests
{
    private readonly PropertyBuilder _propertyBuilder = new();
    private readonly DtoBuilder _dtoBuilder = new();
    private readonly Type _genericType = typeof(NestedGenerics);
    
    [Fact]
    public void NestedGenericTypeDecIsValid()
    {
        _dtoBuilder.SkipTypeAliasing = true;

        var expectedDec = "List<Nullable<int>>";
        var nullableProp = _genericType.GetProperty(nameof(NestedGenerics.ExplicitNullables));

        var model = _propertyBuilder.PropertyModelFromInfo(nullableProp!);

        var actualDec = model.TypeString;
        actualDec.ShouldBe(expectedDec);
    }
    
    [Fact]
    public void NestedGenericNullableTypeDecIsValid()
    {
        _dtoBuilder.SkipTypeAliasing = true;
        
        var nullableProp = _genericType.GetProperty(nameof(NestedGenerics.ShortFormNullables));
        var expectedDec = "List<Nullable<int>>?";

        var model = _propertyBuilder.PropertyModelFromInfo(nullableProp!);
        
        var actualDec = model.TypeString;
        actualDec.ShouldBe(expectedDec);
    }
}