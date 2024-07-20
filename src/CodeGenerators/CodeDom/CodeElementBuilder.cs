using System.CodeDom;
using System.Reflection;

namespace CodeGenerators.CodeElements;

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

    /// <summary>
    /// Builds an expression that represents a method call on an existing Type.
    /// </summary>
    public static CodeMethodInvokeExpression BuildMethodCallExpression(Type targetType, string methodName, CodeExpression[] parameters)
    {
        var call = new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression(targetType.Name),
            methodName,
            parameters);
        return call;
    }
}