using Reflection;

namespace ModelBuilder;

public class ModelSourceProvider
{
    public string BuildEntityDto(Type entityType)
    {
        var _reflector = new DbContextReflector();
        var entityProps = _reflector.GetEntityProperties(entityType);

        var propDecls = entityProps
            .Select(p => new PropertyModel(p.PropertyType.Name, p.Name))
            .ToList();

        var model = new EntityModel(entityType.Name, propDecls);

        var builder = new TemplateBuilder();
        var template = builder.ParseDtoTemplate();

        var dtoClass = template.Render(new {entityName = model.EntityName, entityProps = model.Properties});

        return dtoClass;
    }
}