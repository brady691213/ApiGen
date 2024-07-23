using System.CodeDom;
using System.Reflection;
using CodeGenerators.Models;
using Microsoft.AspNetCore.Builder;

namespace CodeGenerators.CodeDom;

public class CodeElements
{
    /// <summary>
    /// Builds a long form property declaration.
    /// </summary>
    /// <returns>
    /// A <see cref="CodeMemberField"/> for the property's backing field
    /// and a <see cref="CodeMemberProperty"/> with explicit <c>get</c> and <c>set</c> accessors.
    /// </returns>
    public static CodeTypeMember[] BuildPropertyDec(PropertyModel model)
    {
        return BuildPropertyDec(model.PropertyType, model.Name, model.IsVirtual);
    }
    
    private static CodeTypeMember[] BuildPropertyDec(Type type, string name, bool isVirtual = false)
    {
        // TASKT: Make first alpha lower case.
        var fieldName = $"_{name}";
        var backing = new CodeMemberField(type.FullName, fieldName);

        var prop = new CodeMemberProperty
        {
            Name = name,
            Type = new CodeTypeReference(type),
            // Default to final and only make virtual if needed.
            Attributes = MemberAttributes.Public | MemberAttributes.Final
        };

        if (isVirtual)
        {
            prop.Attributes &= ~MemberAttributes.Final;
        }
        prop.GetStatements.Add( new CodeMethodReturnStatement( new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName) ) );
        prop.SetStatements.Add( new CodeAssignStatement( new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName), new CodePropertySetValueReferenceExpression()));
        return [backing, prop];
    }
    

    
    /// <summary>
    /// Builds an expression to access the <c>Services</c> property of the variable referenced by <paramref name="builderVariable"/>
    /// </summary>
    public static CodePropertyReferenceExpression GetServicesExpression(string builderVariable)
    {
        var builderExp = new CodeVariableReferenceExpression(builderVariable);
        var servicesExp = new CodePropertyReferenceExpression(builderExp, "Services");
        return servicesExp;
    }
    
    /// <summary>
    /// Builds an expression for calling method <paramref name="methodName"/> on variable <paramref name="builderVar"/>.
    /// </summary>
    public static CodeMethodInvokeExpression InvokeServiceCollectionMethod(string builderVar, string methodName)
    {
        var services = GetServicesExpression(builderVar);
        var method = new CodeMethodInvokeExpression(services, methodName);
        return method;
    }

    /// <summary>
    /// Builds an expression for the WebApplication instance variable used in startup code.
    /// </summary>
    public static CodeVariableReferenceExpression GetWebApplicationExpression(string appName)
    {
        var appExp = new CodeVariableReferenceExpression(appName);
        return appExp;
    }

    /// <summary>
    /// Builds an invocation expression for a method on a variable.
    /// </summary>
    /// <param name="targetVariable">Name of a variable that holds a reference to the object on which to call method <paramref name="methodName"/> </param>
    /// <param name="methodName">Name of a method to call on an object referenced by variable <paramref name="targetVariable"/> </param>.
    /// .
    public static CodeMethodInvokeExpression GetMethodInvocation(string targetVariable, string methodName, List<ParameterModel> parameters)
    {
        var variableExpression = GetWebApplicationExpression(targetVariable);
        var mxs = new CodeMethodInvokeExpression(variableExpression, methodName);
        return mxs;
    }
    

    
    /// <summary>
    /// Builds a statement that declares the WebApplication instance used in startup code.
    /// </summary>
    public CodeVariableDeclarationStatement WebAppDec(string builderName, string appName)
    {
        var builderExp = new CodeVariableReferenceExpression(builderName);
        var exp = new CodeMethodInvokeExpression(builderExp, "Build");
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplication), appName, exp);
        return dec;
    }
    
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
        
        var hello = CodeDom.CodeElements
            .BuildMethodCallExpression(typeof(Console), "WriteLine",
            [new CodePrimitiveExpression("Hello world")]);
    }

    public static CodeMethodInvokeExpression BuildMethodCallExpression(CodeExpression targetObject, string methodName, CodeExpression[] parameters)
    {
        var call = new CodeMethodInvokeExpression(
            targetObject, 
            methodName,
            parameters);
        return call;
    }

    public static CodeMethodInvokeExpression BuildMethodCallExpression(string methodName, CodeExpression[] parameters)
    {
        var call = new CodeMethodInvokeExpression(
            new CodeThisReferenceExpression(), 
            methodName,
            parameters);
        return call;
    }
}