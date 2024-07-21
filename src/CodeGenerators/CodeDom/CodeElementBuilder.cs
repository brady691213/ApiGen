using System.CodeDom;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.AspNetCore.Builder;

namespace CodeGenerators.CodeDom;

public class CodeElementBuilder
{
    public static CodeVariableDeclarationStatement WebAppBuilderDec(string builderName)
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

    public static CodeVariableReferenceExpression GetAppExpression(string appName)
    {
        var appExp = new CodeVariableReferenceExpression(appName);
        return appExp;
    }
    
    public static CodeMethodInvokeExpression InvokeAppMethod(string appVar, string methodName)
    {
        var ax = GetAppExpression(appVar);
        var mxs = new CodeMethodInvokeExpression(ax, methodName);
        return mxs;
    }

    
    public CodeVariableDeclarationStatement WebAppDec(string appVarName)
    {
        var valueExp = BuildMethodCallExpression(typeof(WebApplication), "Build", []);
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplication), appVarName, valueExp);
        return dec;
    }
    
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
        
        var hello = CodeDom.CodeElementBuilder
            .BuildMethodCallExpression(typeof(Console), "WriteLine",
            [new CodePrimitiveExpression("Hello world")]);
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