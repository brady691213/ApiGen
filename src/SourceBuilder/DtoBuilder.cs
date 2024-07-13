using Reflection;

namespace SourceBuilder;

/// <summary>
/// This class uses text templates to generate models for a web API such as Request and Response DTOs.
/// </summary>
public class DtoBuilder
{
    // TASKT: Make this part of an IOptions read from config.
    internal bool SkipTypeAliasing = false;

    private PropertyBuilder _propertyBuilder = new();
    
    /// <summary>
    /// Builds source code for a request or response DTO that can eb mapped to an EF entity.
    /// </summary>
    /// <param name="dtoType">A ValueObject that specifies if the DTO will be used as a Request or a Response.</param>
    /// <param name="entityType">EF entity type to base the DTO on.</param>
    /// <returns></returns>
    public string BuildDtoForEntity(DtoRequestResponse dtoType, Type entityType)
    {
        // TASKT: Move props work to prop reflector.

        var dbReflector = new Reflector();
        var entityProps = dbReflector.GetEntityProperties(entityType);

        var dtoProps = entityProps
            .Select(_propertyBuilder.PropertyModelFromInfo)
            .ToList();
        var dtoModel = new DtoModel(entityType.Name, dtoProps);

        var loader = new TemplateLoader();
        var template = loader.LoadDtoTemplate();

        var dtoSource = template.Render(new { model = dtoModel });

        return dtoSource;
    }
    

    private string BuildDtoName(DtoRequestResponse dtoType, Type entityType)
    {
        return $"{entityType.Name}{dtoType}";
    }
}