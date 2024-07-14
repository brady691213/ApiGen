using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;

namespace CodeBuilder;

public class CodeElements
{
    public static CodeMemberProperty BuildAutoProperty(PropertyInfo info)
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