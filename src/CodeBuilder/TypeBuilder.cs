using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Reflection;

namespace CodeBuilder;

/// <summary>
/// General functionality for building CodeDom elements common to most code building tasks.
/// </summary>
public class TypeBuilder(CodeOutputConfig outputConfig)
{
    private readonly CodeCompileUnit _compileUnit = new();

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
        _compileUnit.Namespaces.Add(dtoNamespace);

        var dtoSource = GenerateCSharpCode(_compileUnit);

        return dtoSource;
    }

    private List<CodeMemberProperty> GetPropertyMembers(List<PropertyInfo> props)
    {
        CodeMemberProperty[] members = [];
        foreach (var info in props)
        {
            var prop = BuildAutoProperty(info);
            ((IList)members).Add(prop);
        }
        return members.ToList();
    }

    private string GenerateCSharpCode(CodeCompileUnit compileUnit)
    {
        CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
        CodeGeneratorOptions options = new CodeGeneratorOptions();
        options.BracingStyle = "C";

        using StringWriter sourceWriter = new StringWriter();
        provider.GenerateCodeFromCompileUnit(compileUnit, sourceWriter, options);

        return sourceWriter.ToString();
    }

    private CodeMemberProperty BuildAutoProperty(PropertyInfo info)
    {
        var property = new CodeMemberProperty();
        property.Attributes = MemberAttributes.Final | MemberAttributes.Public;
        property.Name = info.Name;
        property.HasGet = true;
        property.HasSet = true;
        property.Type = new CodeTypeReference(info.PropertyType);
        return property;
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