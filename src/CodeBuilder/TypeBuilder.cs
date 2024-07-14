using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Reflection;

namespace CodeBuilder;

/// <summary>
/// General functionality for building CodeDom elements common to most code building tasks.
/// </summary>
public class TypeBuilder(CodeOutputConfig outputConfig): CodeBuilder
{
    public string BuildModelType(Type entityType, string? operationName = null)
    {
        var dtoNamespace = GetTypeNamespace();
        
        var responseClass = new CodeTypeDeclaration($"HelloWorld{operationName ?? ""}");
        responseClass.IsClass = true;
        responseClass.TypeAttributes = TypeAttributes.Public;
        var outputProps = GetModelProperties(entityType);
        foreach (var pm in GetPropertyMembers(outputProps))
        {
            responseClass.Members.Add(pm);
        }

        dtoNamespace.Types.Add(responseClass);
        CompileUnit.Namespaces.Add(dtoNamespace);

        var dtoSource = GenerateCSharpCode();

        return dtoSource;
    }

    private List<CodeMemberProperty> GetPropertyMembers(List<PropertyInfo> props)
    {
        CodeMemberProperty[] members = [];
        foreach (var info in props)
        {
            var prop = CodeElements.BuildAutoProperty(info);
            ((IList)members).Add(prop);
        }
        return members.ToList();
    }
    
    private CodeNamespace GetTypeNamespace()
    {
        var root = outputConfig.RootNamespace ?? outputConfig.OutputFolder;
        return new CodeNamespace($"{root}.Features.HelloWorld");
    }

    private List<PropertyInfo> GetModelProperties(Type inputType)
    {
        var bindingFlags = BindingFlags.Public | BindingFlags.Instance;
        return inputType.GetProperties(bindingFlags).ToList();
    }
}