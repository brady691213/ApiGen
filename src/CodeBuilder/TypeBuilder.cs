using System.CodeDom;
using System.Collections;
using System.Reflection;
using SourceBuilding;

namespace CodeBuilder;

/// <summary>
/// General functionality for building CodeDom elements common to most code building tasks.
/// </summary>
public class TypeBuilder
{
    public string BuildDto(string dtoNamespace, Type entityType, DtoDirection? direction, string? operationName = "")
    {
        var classBuilder = new ClassBuilder();
        var codeNamespace = new CodeNamespace(dtoNamespace);

        var dtoName = BuildDtoName(entityType, direction, operationName);
        var dtoClass = new CodeTypeDeclaration
        {
            Name = dtoName,
            IsClass = true,
            TypeAttributes = TypeAttributes.Public
        };
        var outputProps = GetModelProperties(entityType);
        foreach (var pm in GetPropertyMembers(outputProps))
        {
            dtoClass.Members.Add(pm);
        }

        codeNamespace.Types.Add(dtoClass);
        var dtoSource = classBuilder.GenerateCSharpCode([codeNamespace]);
        return dtoSource;
    }

    /// <summary>
    /// Builds a name for a REPR dto based on an entity type, whether for a request or response, and the CRUD operation;
    /// </summary>
    /// <remarks>
    /// Examples, for a request to update an `Employee`, the name will be `EmployeeUpdateRequest`,
    /// and for the response from request to delete a `Course`, the name will be `CourseDeleteResponse`. 
    /// </remarks>
    private string BuildDtoName(Type entityType, DtoDirection? direction, string? operationName = "")
    {
        return $"{entityType}{operationName}{direction?.ToString() ?? ""}";
    }

    private List<CodeMemberProperty> GetPropertyMembers(List<PropertyInfo> props)
    {
        CodeMemberProperty[] members = [];
        foreach (var info in props)
        {
            var prop = CodeElementBuilder.BuildAutoProperty(info);
            ((IList)members).Add(prop);
        }
        return members.ToList();
    }

    private List<PropertyInfo> GetModelProperties(Type inputType)
    {
        var bindingFlags = BindingFlags.Public | BindingFlags.Instance;
        return inputType.GetProperties(bindingFlags).ToList();
    }
}