using Reflection;

namespace ModelBuilder;

/// <summary>
/// This class uses text templates to generate models for a web API such as Request and Response DTOs.
/// </summary>
public class ModelSourceProvider
{
    /// <summary>
    /// Builds source code for a request or response DTO that can eb mapped to an EF entity.
    /// </summary>
    /// <param name="entityType">EF entity type to base the DTO on.</param>
    /// <returns></returns>
    public string BuildDtoForEntity(Type entityType)
    {
        var reflector = new DbContextReflector();
        var entityProps = reflector.GetEntityProperties(entityType);

        var dtoProps = entityProps
            .Select(p => new PropertyModel(p.PropertyType.Name, p.Name))
            .ToList();
        var model = new EntityModel(entityType.Name, dtoProps);

        var builder = new TemplateLoader();
        var template = builder.LoadDtoTemplate();

        // TASKT: Pass an object with only one property.
        var dtoClass = template.Render(new {entityName = model.EntityName, entityProps = model.Properties});

        return dtoClass;
    }
}