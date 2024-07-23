using System.CodeDom;
using CodeGenerators.Builders;
using CodeGenerators.Models;
using Microsoft.AspNetCore.Builder;

namespace CodeGenerators.CodeDom;

public class FastEndpointsMethods
{
    private static readonly ILogger Logger = Log.ForContext<FastEndpointsMethods>();
    private static readonly ClassBuilder Builder = new ClassBuilder();

    public static CodeMemberMethod BuildMainMethod()
    {
        Logger.Verbose("Starting BuildOperation {BuildOperation}", nameof(BuildMainMethod));
        
        var builderVarName = "builder";
        var appVarName = "app";
        
        var builderDec = BuildWebAppBuilderDec(builderVarName);
        var addFastEndpoints = CodeElements.InvokeServiceCollectionMethod(builderVarName,"AddFastEndpoints");
        
        var appDec = BuildAppVarDec(appVarName, builderVarName);
        var useFastEndpoints = CodeElements.GetMethodInvocation(appVarName, "UseFastEndpoints", []);
        var run = CodeElements.GetMethodInvocation(appVarName, "Run", []);

        ParameterModel[] parameters = [new ParameterModel(typeof(string[]), "args")];
        var statements = new CodeStatementCollection { builderDec, addFastEndpoints, appDec, useFastEndpoints, run };
        
        var main = Builder.BuildMethodDec("Main", parameters, statements, MemberAttributes.Static | MemberAttributes.Public);
        
        Logger.Debug("Finished BuildOperation {BuildOperation} with code {GeneratedCode}", nameof(BuildMainMethod), main);

        return main;
    }
    
    /// <summary>
    /// Builds a statement for <c>WebApplicationBuilder builder;;</c>, but with variable names from parameters.
    /// </summary>
    private static CodeVariableDeclarationStatement BuildWebAppBuilderDec(string builderName)
    {
        var valueExp = CodeElements.BuildMethodCallExpression(typeof(WebApplication), "CreateBuilder", []);
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplicationBuilder), builderName, valueExp);
        return dec;
    }
    
    /// <summary>
    /// Builds a statement for <c>WebApplication app = builder.Build();</c>, but with variable names from parameters.
    /// </summary>
    private static CodeVariableDeclarationStatement BuildAppVarDec(string appVarName, string builderVarName)
    {
        var builderExp = new CodeVariableReferenceExpression(builderVarName);
        var valueExp = CodeElements.BuildMethodCallExpression(builderExp, "Build", []);
        var dec = new CodeVariableDeclarationStatement(typeof(WebApplication), appVarName, valueExp);
        return dec;
    }
}