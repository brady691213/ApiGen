using System.CodeDom;
using Microsoft.AspNetCore.Builder;

namespace CodeScaffolding.Applications;

/// <summary>
/// Work in progress: Using templates for non-reflection classes.
/// </summary>
public class WebAppStatementBuilder
{
    public CodeMethodInvokeExpression CreateBuilderField(string builderFieldName)
    {
        var statement = new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression("Microsoft.AspNetCore.Builder"),
            "CreateBuilder");
        
        return statement;
    }

    public CodeVariableDeclarationStatement CreateWebAppBuilderVariable(string name)
    {
        var variable = new CodeVariableDeclarationStatement(
            typeof(WebApplicationBuilder), name);
        return variable;
    }
}