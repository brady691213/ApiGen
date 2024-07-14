using System.Reflection;
using Shouldly;
using Xunit;

namespace SourceBuilder.Tests.Integration;

/// <summary>
/// Here I use 1709 property declarations parsed from the decompiled sample assembly as expected cases
/// to test actual declarations generated using information obtained via reflection.
/// </summary>
public class TypeDecMassTests
{
    private readonly PropertyBuilder _builder = new();

    [Theory]
    [ClassData(typeof(MassTypeTestTheoryData))]
    public void GeneratedPropertyTypeIsCorrect(PropertyInfo info, string expected)
    {
        var model = _builder.PropertyModelFromInfo(info);
        var actual = model.TypeString;

        actual.ShouldBe(expected);
    }
}