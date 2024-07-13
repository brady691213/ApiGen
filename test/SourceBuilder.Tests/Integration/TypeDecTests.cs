using System.Reflection;
using Shouldly;
using SourceReader;
using Xunit;

namespace SourceBuilder.Tests.Integration;

public class TypeDecTests
{
    private PropertyBuilder _builder = new PropertyBuilder();

    [Theory]
    [ClassData(typeof(MassTypeTestTheoryData))]
    public void GeneratedPropertyTypeIsCorrect(PropertyInfo info, InputPropertyDeclaration expectedDec)
    {
        var model = _builder.PropertyModelFromInfo(info);
        var actualDec = model.TypeDeclaration;

        actualDec.ShouldBe(expectedDec.ContainingTypeName);
    }

    [Fact]
    public void aFact()
    {
        var data = new MassTypeTestTheoryData();
    }
}