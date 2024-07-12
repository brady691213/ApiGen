using Reflection.Tests.SampleTypes;
using Shouldly;

namespace Reflection.Tests.Unit;

public class PropertyModelTests
{
    [Fact]
    public void GenericDeclarationIsValid()
    {
        var pRef = new PropertyReflector();
        var genericType = typeof(SuperGeneric);
        var nullableProp = genericType.GetProperty("ListOfNullables");

        var model = pRef.GetPropertyModel(nullableProp);

        var dec = model.TypeDeclaration;
        
        dec.ShouldBe("List<Nullable<int>>?");
    }
}