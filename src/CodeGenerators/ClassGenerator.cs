﻿using System.CodeDom;
using System.Reflection;

namespace CodeGenerators;

/// <summary>
/// Builds classes and other type definitions based on Type info obtained via Reflection.
/// </summary>
public class ClassGenerator
{
    /// <summary>
    /// Builds a simple C# class without any members.
    /// </summary>
    /// <returns>A <see cref="CodeTypeDeclaration"/> that defines an empty class.</returns>
    public CodeTypeDeclaration GenerateClass(ClassModel model, TypeAttributes classAttributes = TypeAttributes.Public)
    {
        var outClass = new CodeTypeDeclaration(model.ClassName)
        {
            IsClass = true,
            TypeAttributes = classAttributes
        };

        outClass.Members.AddRange(model.Members);

        return outClass;
    }

    /// <summary>
    /// Builds a class method.
    /// </summary>
    public CodeMemberMethod BuildMethod(string methodName, ParameterModel[] parameters,
        CodeStatementCollection statements, MemberAttributes methodAttributes)
    {
        var method = new CodeMemberMethod
        {
            Name = methodName,
            Attributes = methodAttributes
        };
        var paramExpressions = parameters
            .Select(p => new CodeParameterDeclarationExpression(p.Type, p.Name))
            .ToArray();
        method.Parameters.AddRange(paramExpressions);
        method.Statements.AddRange(statements);

        return method;
    }
}