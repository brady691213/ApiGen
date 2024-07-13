using System.Reflection;
using Reflection;

namespace SourceBuilder;

/// <summary>
/// This class uses text templates to generate models for a web API such as Request and Response DTOs.
/// </summary>
public class DtoBuilder
{
    // TASKT: Male this part of an IOptions read from config.
    public bool skipTypeAliasing = false;
    
    private PropertyReflector _propertyReflector = new();


    /// <summary>
    /// Builds source code for a request or response DTO that can eb mapped to an EF entity.
    /// </summary>
    /// <param name="dtoType">A ValueObject that specifies if the DTO will be used as a Request or a Response.</param>
    /// <param name="entityType">EF entity type to base the DTO on.</param>
    /// <returns></returns>
    public string BuildDtoForEntity(DtoRequestResponse dtoType, Type entityType)
    {
        // TASKT: Move props work to prop reflector.
        
        var dbReflector = new DbContextReflector();
        var entityProps = dbReflector.GetEntityProperties(entityType);

        var dtoProps = entityProps
            .Select(PropertyModelFromInfo)
            .ToList();
        var dtoModel = new DtoModel( entityType.Name, dtoProps);
        
        var loader = new TemplateLoader();
        var template = loader.LoadDtoTemplate();

        var dtoSource = template.Render(new {model = dtoModel});

        return dtoSource;
    }

    public PropertyModel PropertyModelFromInfo(PropertyInfo info)
    {
        // TASKT: Map Nullable<T> to T?

        var model = new PropertyModel(info.PropertyType.Name, info.Name);
        model.TypeDeclaration =  BuildTypeDeclaration(info.PropertyType);
        
        if (_propertyReflector.IsMarkedAsNullable(info))
        {
            // TASKT: Terrible kludge!!! The nullabel prefix thing.
            if (!info.PropertyType.Name.StartsWith("Nullable"))
                model.TypeDeclaration += "?";
        }

        return model;
    }
    
    public string BuildTypeDeclaration(Type propType)
    {
        if (!propType.IsGenericType)
        {
            return skipTypeAliasing ? propType.Name : _propertyReflector.GetTypeAlias(propType);
        }

        var names = new List<string>();
        foreach (var genericTypeArgument in propType.GenericTypeArguments)
        {
            names.Add(BuildTypeDeclaration(genericTypeArgument));
        }

        return $"{propType.Name.Split('`')[0]}<{string.Join(",", names)}>";
    }

    private string BuildDtoName(DtoRequestResponse dtoType, Type entityType)
    {
        return $"{entityType.Name}{dtoType}";
    }
}