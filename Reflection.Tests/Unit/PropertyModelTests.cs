using Reflection.Tests.Types;
using Shouldly;

namespace Reflection.Tests.Unit;

public class PropertyModelTests
{
    [Fact]
    public void NoAliasExplicitNullableGenericIsValid()
    {
        var pRef = new PropertyReflector();
        var genericType = typeof(SuperGenericNoAlias);
        var nullableProp = genericType.GetProperty("ExplicitNullables");

        var model = pRef.GetPropertyModel(nullableProp, skipAliases:true);

        var dec = model.TypeDeclaration;
        
        dec.ShouldBe("List<Nullable<Int32>>?");
    }
    
    [Fact]
    public void AliasedExplicitNullableGenericIsValid()
    {
        var pRef = new PropertyReflector();
        var genericType = typeof(SuperGenericNoAlias);
        var nullableProp = genericType.GetProperty("ExplicitNullables");

        var model = pRef.GetPropertyModel(nullableProp);

        var dec = model.TypeDeclaration;
        
        dec.ShouldBe("List<Nullable<int>>?");
    }
    
    [Fact]
    public void NoAliasShortFormNullableGenericIsValid()
    {
        var pRef = new PropertyReflector();
        var genericType = typeof(SuperGenericNoAlias);
        var nullableProp = genericType.GetProperty("ShortFormNullables");

        var model = pRef.GetPropertyModel(nullableProp, skipAliases:true);

        var dec = model.TypeDeclaration;
        
        dec.ShouldBe("List<Nullable<Int32>>?");
    }
    
    [Fact]
    public void AliasedShortFormNullableGenericIsValid()
    {
        var pRef = new PropertyReflector();
        var genericType = typeof(SuperGenericNoAlias);
        var nullableProp = genericType.GetProperty("ShortFormNullables");

        var model = pRef.GetPropertyModel(nullableProp);

        var dec = model.TypeDeclaration;
        
        dec.ShouldBe("List<Nullable<int>>?");
    }
}