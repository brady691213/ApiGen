using System.CodeDom;
using CodeGenerators.Builders;
using CodeGenerators.Models;

namespace CodeGenerators.CodeDom;

public class ConsoleAppMethods
{
    private static readonly ClassBuilder ClassBuilder = new();
    
    /// <summary>
    /// Builds a <see cref="CodeMemberMethod"/> that defines a <c>Main</c> entry point method for an application.
    /// </summary>
    internal static Result<CodeMemberMethod> BuildMainMethod(CodeStatementCollection? statements = null)
    {
        // TASKT: Call from app builder not from BuildProgramClass
        var mainStatements = statements ??  [BuildHelloWorldStatement()];
        ParameterModel[] parameters = [new ParameterModel(typeof(string[]), "args")];
        var main = ClassBuilder.BuildMethodDec("Main", parameters, mainStatements, MemberAttributes.Static | MemberAttributes.Public);
        return main;
    }
    
    /// <summary>
    /// Builds a <see cref="CodeMethodInvokeExpression"/> that defines the following code:
    /// <code>
    /// System.Console.WriteLine("Hello, world!");
    /// </code>
    /// </summary>
    private static CodeMethodInvokeExpression BuildHelloWorldStatement()
    {
        var argsParam = new ParameterModel(typeof(string[]), "args");
        var stmt = ClassBuilder.BuildMethodCall(typeof(Console), "WriteLine", [argsParam]);
        var statement = CodeElements.BuildMethodCallExpression(
            typeof(Console), 
            "WriteLine",
            [new CodePrimitiveExpression("Hello, world")]);
        return statement;
    }
}