using System.Text.RegularExpressions;
using Xunit;

namespace SourceBuilder.Tests.Integration;

// TASKT: Test for Nullable<xxx>? decs. Lose the `Nullable` or the `?`


public class DtoBuilderTests
{
    // This should be defined here in the tests because the actual reflector should never have a fixed asm path.
    private const string DbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";

    [Fact]
    public void PropertiesForRequestDtoAreCorrect()
    {
        // var dtoBuilder = new DtoBuilder();
        // var entityType = typeof(CourseTemplate);
        // var dbRef = new Reflector();
        // var pRef = new TypeAliasing();
        //
        // var expectedModels = dbRef.GetEntityProperties(entityType)
        //     .Select(p => dtoBuilder.PropertyModelFromInfo(p))
        //     .ToList();
        // var expectedDecs = expectedModels
        //     .Select(m => $"public {m.TypeDeclaration}")
        //     .ToList();
        //
        // var actualCode = dtoBuilder.BuildDtoForEntity(DtoRequestResponse.Request, entityType);
        //
        // var actualDecs = GetPropertyDecsFromType(actualCode).ToList();
        // //actualDecs.ShouldBe(expectedDecs, ignoreOrder: true);
    }

    private List<PropertyModel> GetPropertyDecsFromType(string modelSource)
    {
        // TASKT: Get fancy and use RegEx to pull the properties.

        var rx = new Regex(@"(?'access'\w+) (?'type')\w+ (?'name'\w+)");
        var decs = rx.Match(modelSource);

        return new List<PropertyModel>();
    }
}