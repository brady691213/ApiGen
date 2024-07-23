using System.CodeDom;
using System.Reflection;
using CodeGenerators.Models;
using Microsoft.AspNetCore.Builder;

namespace CodeGenerators.CodeDom;

public class CodeElements
{
    public static CodeMemberProperty PropertyDec(Type type, string name)
    {
        CodeMemberProperty property1 = new CodeMemberProperty();
        property1.Name = name;
        property1.Type = new CodeTypeReference(type);
        property1.Attributes = MemberAttributes.Public;
        property1.GetStatements.Add( new CodeMethodReturnStatement());
        property1.SetStatements.Add( new CodeAssignStatement());
        return property1;
    }
    
    /// <summary>
    /// Builds a declaration statement for a WebApplicationBuilder.
    /// </summary>
    public static CodeVariableDeclarationStatement WebAppBuilderDec(string builderName)
    {
        var valueExp = BuildMethodCallExpression(typeof(WebApplication), "CreateBuilder", []);
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplicationBuilder), builderName, valueExp);
        return dec;
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
    /// Builds an invocation expression for a given method on the <c>Services</c> property of a <c>WebApplicationBuilder</c>.
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
        var variableExprression = GetWebApplicationExpression(targetVariable);
        var mxs = new CodeMethodInvokeExpression(variableExprression, methodName);
        return mxs;
    }
    
    /// <summary>
    /// Builds a statement that declares the WebApplication instance used in startup code.
    /// </summary>
    public static CodeVariableDeclarationStatement InitAppVar(string appVarName, string builderVarName)
    {
        var builderExp = new CodeVariableReferenceExpression(builderVarName);
        var valueExp = BuildMethodCallExpression(builderExp, "Build", []);
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplication), appVarName, valueExp);
        return dec;
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