using CTSCore.Models;
using Reflection;
using Shouldly;
using Xunit;

namespace ModelBuilder.Tests;

public class ModelSourceProviderTests
{
    // This should be defined here in the tests because the actual refelctor should never have a fixed asm path.
    private const string DbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";

    [Fact]
    public void BuildEntityDtoRendersCorrectProps()
    {
        var sourceProvider = new ModelSourceProvider();
        var entityType = typeof(CourseTemplate);
        var reflector = new DbContextReflector();
        
        var expectedDecs = reflector.GetEntityProperties(entityType)
            .Select(p => new PropertyModel(p.PropertyType.Name, p.Name))
            .ToList();

        var actualCode = sourceProvider.BuildDtoForEntity(entityType);
        
        var actualDecs = GetActualDeclarations(actualCode);
        actualDecs.ShouldBe(expectedDecs, ignoreOrder: true);
    }

    private List<PropertyModel> GetActualDeclarations(string actual)
    {
        // TASKT: Get fancy and use RegEx to pull the properties.
        
        var lines = actual
            .Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
            .Where(l => !l.StartsWith("public class"))
            .ToList();
        var actualDecs = new List<PropertyModel>();
        for (var i = 1; i < lines.Count - 2; i++)
        {
            var parts = lines[i].Split(' ');
            if (parts.Length > 2)
                actualDecs.Add(new PropertyModel(parts[1], parts[2]));
        }
        return actualDecs;
    }
}