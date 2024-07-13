using Reflection.Tests.Types;
using Shouldly;
using Xunit;

namespace SourceBuilder.Tests.Unit;

public class PropertyModelTests
{
    private readonly DtoBuilder _dtoBuilder = new();
    private readonly Type _genericType = typeof(NestedGenerics);
    
    [Fact]
    public void NestedGenericTypeDecIsValid()
    {
        _dtoBuilder.SkipTypeAliasing = true;

        var expectedDec = "List<Nullable<int>>";
        var nullableProp = _genericType.GetProperty(nameof(NestedGenerics.ExplicitNullables));

        var model = _dtoBuilder.PropertyModelFromInfo(nullableProp!);

        var actualDec = model.TypeDeclaration;
        actualDec.ShouldBe(expectedDec);
    }
    
    [Fact]
    public void NestedGenericNullableTypeDecIsValid()
    {
        _dtoBuilder.SkipTypeAliasing = true;
        
        var nullableProp = _genericType.GetProperty(nameof(NestedGenerics.ShortFormNullables));
        var expectedDec = "List<Nullable<int>>?";

        var model = _dtoBuilder.PropertyModelFromInfo(nullableProp!);
        
        var actualDec = model.TypeDeclaration;
        actualDec.ShouldBe(expectedDec);
    }
}