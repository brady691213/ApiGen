using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;

namespace CodeGenerators;

/// <summary>
/// Builds classes and other type defintoions based on input obtained from Reflection.
/// </summary>
public class ClassBuilder
{
    /// <summary>
    /// Builds a simple C# class without any members.
    /// </summary>
    /// <returns>A <see cref="CodeTypeDeclaration"/> that defines an empty class.</returns>
    public CodeTypeDeclaration BuildClass(ClassModel model, TypeAttributes classAttributes = TypeAttributes.Public)
    {
        var outClass = new CodeTypeDeclaration(model.ClassName)
        {
            IsClass = true,
            TypeAttributes = classAttributes
        };

        if (model.Members.Count == 0)
        {
            var main = BuildMainMethod();
            outClass.Members.Add(main);
        }
        outClass.Members.AddRange(model.Members);
        
        return outClass;
    }

    /// <summary>
    /// Builds a <c>Main</c> method as used an entry point in console apps.
    /// </summary>
    /// <returns>A <see cref="CodeMemberMethod"/> that defines a <c>Main</c> method.</returns>
    public CodeMemberMethod BuildMainMethod(CodeStatementCollection? statements = null, MemberAttributes? methodAttributes = null)
    {
        // TASKT: Refgactor into BuildMethod.
        var mainMethod = new CodeMemberMethod
        {
            Name = "Main",
            Attributes = methodAttributes ?? MemberAttributes.Static | MemberAttributes.Public
        };
        mainMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string[]), "args"));

        if (statements == null)
        {
            mainMethod.Statements.Add(new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("System.Console"),
                "WriteLine",
                new CodePrimitiveExpression("Hello world")));
        }

        return mainMethod;
    }
    
    public CodeTypeDeclaration BuildProgramClass(string @namespace)
    {
        var model = new ClassModel("Program");
        
        var classBuilder = new ClassBuilder();
        var programClass = classBuilder.BuildClass(model);

        return programClass;
    }
}