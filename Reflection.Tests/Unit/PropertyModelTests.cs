using Reflection.Tests.SampleTypes;
using Shouldly;

namespace Reflection.Tests.Unit;

public class PropertyModelTests
{
    public void GenericDeclarationIsValid()
    {
        var pRef = new PropertyReflector();
        var genericType = typeof(SuperGeneric);
        var nullableProp = genericType.GetProperty("ListOfNullables");

        var model = pRef.GetPropertyModel(nullableProp!);

        var dec = model.BuildPropertyDeclaration();
        
        dec.ShouldBe("List<Nullable<int>>?");
    }
}