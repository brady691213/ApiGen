using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Reflection;

namespace CodeDomSourceBuilder;

public class TypeBuilder(string outputFolder, string rootNamespace)
{
    private readonly CodeCompileUnit _compileUnit = new();

    public string BuildResponseDto(Type entityType, string? operationName = null)
    {
        var responeBindingFlags = BindingFlags.Public | BindingFlags.Instance;

        var ns = new CodeNamespace($"{rootNamespace}.Features.HelloWorld");
        
        var responseClass = new CodeTypeDeclaration($"HelloWorld{operationName ?? ""}");
        responseClass.IsClass = true;
        responseClass.TypeAttributes = TypeAttributes.Public;
        foreach (var pm in GetPropertyMembers(entityType.GetProperties(responeBindingFlags).ToList()))
        {
            responseClass.Members.Add(pm);
        }

        ns.Types.Add(responseClass);
        _compileUnit.Namespaces.Add(ns);

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
}