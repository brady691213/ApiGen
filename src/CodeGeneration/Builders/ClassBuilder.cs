using System.CodeDom;
using System.Reflection;
using CodeGenerators.CodeDom;
using CodeGenerators.Models;

namespace CodeGenerators.Builders;

/// <summary>
/// Builds classes and other type definitions based on Type info obtained via Reflection.
/// </summary>
public class ClassBuilder
{
    /// <summary>
    /// Builds a <see cref="CodeTypeDeclaration"/> for a C# class.
    /// </summary>
    public CodeArtifactModel BuildTypeForClass(CodeArtifactModel model, TypeAttributes classAttributes = TypeAttributes.Public)
    {
        var outClass = new CodeTypeDeclaration(model.ClassName)
        {
            IsClass = true,
            TypeAttributes = classAttributes
        };

        outClass.Members.AddRange(model.Members);
        model.ClassDeclaration = outClass;
        
        return model;
    }

    /// <summary>
    /// Builds a class method declaration.
    /// </summary>
    public CodeMemberMethod BuildMethodDec(string methodName, ParameterModel[] parameters,
        CodeStatementCollection statements, MemberAttributes methodAttributes)
    {
        var method = new CodeMemberMethod
        {
            Name = methodName,
            Attributes = methodAttributes
        };

        method.Statements.AddRange(statements);

        return method;
    }
    
    /// <summary>
    /// Builds a <see cref="CodeMethodInvokeExpression"/> for a static method call on a given Type. 
    /// </summary>
    public CodeMethodInvokeExpression BuildMethodCall(Type targetType, string methodName, List<ParameterModel> paramModels)
    {
        CodeExpression[] parameters = ParameterBuilder.ModelsToExpressions(paramModels);
        CodeParameterDeclarationExpression[] pms = [new CodeParameterDeclarationExpression()];
        var statement = CodeElements.BuildMethodCallExpression(
            targetType, 
            methodName,
            parameters );
        return statement;
    }
}