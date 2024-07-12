using CTSCore.Models;
using EntityDecompiler;
using Reflection;
using Reflection.Tests.SampleTypes;
using Shouldly;
using Xunit;

namespace ModelBuilder.Tests;

public class ModelSourceProviderTests
{
    private const string DbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";

    private DbContextReflector _reflector = new DbContextReflector();
    private ModelSourceProvider _sourceProvider;

    public ModelSourceProviderTests()
    {
        _sourceProvider = new ModelSourceProvider(_reflector);
    }
    
    [Fact]
    public void BuildEntityDtoRendersCorrectProps()
    {
        var entityType = typeof(CourseTemplate);
        var expectedProps = _reflector.GetEntityProperties(entityType)
            .Select(p => new PropertyDeclaration(p.PropertyType.Name, p.Name))
            .ToList();

        var actual = _sourceProvider.BuildEntityDto(entityType);

        var lines = actual.Split('\n');

        var actualDecs = new List<PropertyDeclaration>();

        for (var i = 1; i < lines.Length - 2; i++)
        {
            var parts = lines[i].Split(' ');
            actualDecs.Add(new PropertyDeclaration(parts[1], parts[2]));
        }

        actualDecs.ShouldBe(expectedProps, ignoreOrder: true);
    }
}