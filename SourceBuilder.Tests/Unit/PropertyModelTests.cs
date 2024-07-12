using Reflection;
using Reflection.Tests.Types;
using Shouldly;
using Xunit;

namespace SourceBuilder.Tests.Unit;

public class PropertyModelTests
{
    private readonly DtoBuilder _dtoBuilder = new();
    private readonly Type _genericType = typeof(NestedGenerics);
    
    [Fact]
    public void NoAliasExplicitNullableGenericIsValid()
    {
        _dtoBuilder.skipTypeAliasing = true;

        var expectedDec = "List<Nullable<Int32>>?";
        var nullableProp = _genericType.GetProperty(nameof(NestedGenerics.ExplicitNullables));

        var model = _dtoBuilder.PropertyModelFromInfo(nullableProp!);

        var actualDec = model.TypeDeclaration;
        actualDec.ShouldBe(expectedDec);
    }
    
    [Fact]
    public void AliasedExplicitNullableGenericIsValid()
    {
        _dtoBuilder.skipTypeAliasing = false;

        var expectedDec = "List<Nullable<int>>?";
        var nullableProp = _genericType.GetProperty(nameof(NestedGenerics.ExplicitNullables));

        var model = _dtoBuilder.PropertyModelFromInfo(nullableProp!);

        var actualDec = model.TypeDeclaration;
        actualDec.ShouldBe(expectedDec);
    }
    
    [Fact]
    public void NoAliasShortFormNullableGenericIsValid()
    {
        _dtoBuilder.skipTypeAliasing = true;

        var expectedDec = "List<Nullable<Int32>>?";
        var nullableProp = _genericType.GetProperty(nameof(NestedGenerics.ShortFormNullables));

        var model = _dtoBuilder.PropertyModelFromInfo(nullableProp!);

        var actualDec = model.TypeDeclaration;
        actualDec.ShouldBe(expectedDec);
    }
    
    [Fact]
    public void AliasedShortFormNullableGenericIsValid()
    {
        _dtoBuilder.skipTypeAliasing = true;
        
        var nullableProp = _genericType.GetProperty(nameof(NestedGenerics.ShortFormNullables));
        var expectedDec = "List<Nullable<int>>?";

        var model = _dtoBuilder.PropertyModelFromInfo(nullableProp!);
        
        var actualDec = model.TypeDeclaration;
        actualDec.ShouldBe(expectedDec);
    }
}