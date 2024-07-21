using System.CodeDom;
using CodeGenerators.Models;

namespace CodeGenerators.Builders;

public class ParameterBuilder
{
    public static CodeParameterDeclarationExpression[] ModelsToExpressions(List<ParameterModel> models)
    {
        var exps = models
            .Select(p => new CodeParameterDeclarationExpression(p.Type, p.Name))
            .ToArray();
        return exps;
    }
}