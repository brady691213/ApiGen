using System.CodeDom;
using System.Collections;
using System.Reflection;
using CodeGenerators.CodeElements;
using CodeGenerators.Next;

namespace CodeGenerators;

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
        foreach (var pm in BuildPropertyMembers(outputProps))
        {
            dtoClass.Members.Add(pm);
        }

        codeNamespace.Types.Add(dtoClass);
        var generator = new CSharpCodeGenerator();
        var dtoSource = generator.GenerateCodeForNamespaces([codeNamespace]);
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

    /// <summary>
    /// Builds a collection of property members that corresponds to a collection of <see cref="PropertyInfo"/> objects obtained via reflection.
    /// </summary>
    /// <param name="props">PropertyInfo objects to base output CodeMemberProperty objects on.</param>
    /// <returns>A collection of <see cref="CodeMemberProperty"/> objects based on <paramref name="props"/>.</returns>
    private List<CodeMemberProperty> BuildPropertyMembers(List<PropertyInfo> props)
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