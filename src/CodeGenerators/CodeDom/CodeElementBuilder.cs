using System.CodeDom;
using System.Reflection;
using Microsoft.AspNetCore.Builder;

namespace CodeGenerators.CodeDom;

public class CodeElementBuilder
{
    public static CodeVariableDeclarationStatement WebAppBuilderVariable(string builderName)
    {
        var valueExp = BuildMethodCallExpression(typeof(WebApplication), "CreateBuilder", []);
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplicationBuilder), builderName, valueExp);
        return dec;
    }
    
    public static CodePropertyReferenceExpression GetServicesExpression(string builderName)
    {
        var builderExp = new CodeVariableReferenceExpression(builderName);
        var servicesExp = new CodePropertyReferenceExpression(builderExp, "Services");
        return servicesExp;
    }
    
    public static CodeMethodInvokeExpression InvokeServicesExtension(string builderVar, string methodName)
    {
        var sx = GetServicesExpression(builderVar);
        var mxs = new CodeMethodInvokeExpression(sx, methodName);
        return mxs;
    }

    
    public CodeVariableDeclarationStatement BuilderInvokeBuild(string appVarName)
    {
        var valueExp = BuildMethodCallExpression(typeof(WebApplication), "Build", []);
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplication), appVarName, valueExp);
        return dec;
    }

    public CodeVariableReferenceExpression AppUse(string appVarName)
    {
        var appRef = new CodeVariableReferenceExpression(appVarName);
        var meth = BuildMethodCallExpression(appRef, "UseFastEndpoints", []);
    }

    public CodeVariableDeclarationStatement WebApplicationBuilderInvokeBuild()
    {
        var valueExp = BuildMethodCallExpression(
            typeof(WebApplication), "CreateBuilder", []);
    }

    
    public CodeMemberProperty BuildAutoProperty(PropertyInfo inputInfo)
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

    public CodeMethodInvokeExpression BuildMethodCallExpression(CodeExpression targetObject, string methodName, CodeExpression[] parameters)
    {
        var call = new CodeMethodInvokeExpression(
            targetObject, 
            methodName,
            parameters);
        return call;
    }
}