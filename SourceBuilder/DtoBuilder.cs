using Reflection;

namespace SourceBuilder;

/// <summary>
/// This class uses text templates to generate models for a web API such as Request and Response DTOs.
/// </summary>
public class DtoBuilder
{
    /// <summary>
    /// Builds source code for a request or response DTO that can eb mapped to an EF entity.
    /// </summary>
    /// <param name="entityType">EF entity type to base the DTO on.</param>
    /// <returns></returns>
    public string BuildDtoForEntity(Type entityType)
    {
        // TASKT: Maybe name this BuildDtoForFeature?
        
        var dbReflector = new DbContextReflector();
        var entityProps = dbReflector.GetEntityProperties(entityType);
        var propertyReflector = new PropertyReflector();

        var dtoProps = entityProps
            .Select(p => propertyReflector.GetPropertyModel(p))
            .ToList();
        var dtoModel = new EntityModel(entityType.Name, dtoProps);

        foreach (var prop in dtoProps)
        {
            var dec = prop.TypeDeclaration;
        }
        
        var builder = new TemplateLoader();
        var template = builder.LoadDtoTemplate();

        // TASKT: Pass an object with only one property.
        var dtoClass = template.Render(new {model = dtoModel});

        return dtoClass;
    }
}