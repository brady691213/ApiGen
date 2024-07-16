using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;

namespace CodeBuilder;

public abstract class CodeElementBuilder
{
    public static CodeMemberProperty BuildAutoProperty(PropertyInfo inputInfo)
    {
        var property = new CodeMemberProperty();
        property.Attributes = MemberAttributes.Final | MemberAttributes.Public;
        property.Name = inputInfo.Name;
        property.HasGet = true;
        property.HasSet = true;
        property.Type = new CodeTypeReference(inputInfo.PropertyType);
        return property;
    }
}