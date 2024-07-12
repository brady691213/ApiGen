using Reflection.Tests.SampleTypes;
using Shouldly;

namespace Reflection.Tests.Unit;

public class PropertyModelTests
{
    [Fact]
    public void ExplicitNullableGenericDeclarationIsValid()
    {
        var pRef = new PropertyReflector();
        var genericType = typeof(SuperGenericNoAlias);
        var nullableProp = genericType.GetProperty("ExplicitNullables");

        var model = pRef.GetPropertyModel(nullableProp);

        var dec = model.TypeDeclaration;
        
        dec.ShouldBe("List<Nullable<Int32>>?");
    }
    
    [Fact]
    public void ShortFormNullableGenericDeclarationIsValid()
    {
        var pRef = new PropertyReflector();
        var genericType = typeof(SuperGenericNoAlias);
        var nullableProp = genericType.GetProperty("ShortFormNullables");

        var model = pRef.GetPropertyModel(nullableProp);

        var dec = model.TypeDeclaration;
        
        dec.ShouldBe("List<Nullable<Int32>>?");
    }
}