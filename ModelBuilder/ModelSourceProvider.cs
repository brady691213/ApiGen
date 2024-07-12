using System.Reflection;
using Reflection;
using Scriban;

namespace EntityDecompiler;

public class ModelSourceProvider(DbContextReflector reflector)
{
    private DbContextReflector _reflector = reflector;

    public string BuildEntityDto(Type entityType)
    {
        var entityProps = _reflector.GetEntityProperties(entityType);

        var propDecls = entityProps
            .Select(p => new PropertyDeclaration(p.PropertyType.Name, p.Name))
            .ToList();

        var model = new EntityModel(entityType.Name, propDecls);

        var templateText = File.ReadAllText(@"Templates\dto.txt");
        var template = Template.Parse(templateText);

        var modelClass = template.Render(model);

        return modelClass;
    }
}