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
    public void GeneratedPropertyTypeIsCorrect(PropertyInfo info, string expected)
    {
        var model = _builder.PropertyModelFromInfo(info);
        var actual = model.TypeString;

        actual.ShouldBe(expected);
    }
}