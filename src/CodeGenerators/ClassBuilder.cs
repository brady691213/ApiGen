using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using CodeGenerators.CodeElements;

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

        var allMembers = model.Members;
        
        // Add a default main method if no other methods provided.
        if (allMembers.Count == 0)
        {
            var argParam = new ParameterModel(typeof(string[]), "args");
            var main = BuildMethod("Main", [argParam], [], MemberAttributes.Static | MemberAttributes.Public);
            allMembers.Add(main);
        }
        outClass.Members.AddRange(allMembers);
        
        return outClass;
    }

    /// <summary>
    /// Builds a <c>Main</c> method as used an entry point in console apps.
    /// </summary>
    /// <returns>A <see cref="CodeMemberMethod"/> that defines a <c>Main</c> method.</returns>
    public CodeMemberMethod BuildMethod(string methodName, ParameterModel[] parameters, CodeStatementCollection statements, MemberAttributes methodAttributes)
    {
        var method = new CodeMemberMethod
        {
            Name = methodName,
            // TASKT: Add/override default atts with passed atts 
            // TASKT: Make internal after quick test
            Attributes = methodAttributes
        };
        var paramExpressions = parameters.Select(p => new CodeParameterDeclarationExpression(p.Type, p.Name)).ToArray();
        method.Parameters.AddRange(paramExpressions);

        // Add a default HelloWorld statement if no others present.
        if (statements.Count == 0)
        {
            var hello = CodeElementBuilder.BuildMethodCallExpression(typeof(Console), "WriteLine",
                [new CodePrimitiveExpression("Hello world")]);
            method.Statements.Add(hello);
        }

        return method;
    }
}