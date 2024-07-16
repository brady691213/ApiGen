﻿using System.CodeDom;

namespace CodeBuilder;

public class ConsoleAppBuilder : ClassBuilder
{
    public void BuildHelloWorldApp(string outputDirectory)
    {
        var projectName = "HelloWorld";

        // For now, we just use the project name as a solution name and path.
        var solutionName = projectName;
        var solutionDirectory = $"{outputDirectory}/{solutionName}";

        if (Directory.Exists(solutionDirectory))
        {
            throw new InvalidOperationException(
                $"Solution path {solutionDirectory} already exists. `{nameof(outputDirectory)}` must specify a new directory.");
        }

        Directory.CreateDirectory(solutionDirectory);

        var projectModel = new ProjectModel(projectName);
        
        var code = BuildProgramClass();
        var codeModel = new CodeFileModel("Program.cs", code);
        projectModel.CodeFileModels.Add(codeModel);
        
        var sourceLocation = $"{solutionDirectory}/src";
        
        var projectBuilder = new ProjectBuilder();
        projectBuilder.CreateProject(projectModel, sourceLocation);        
        
        var slnBuilder = new SolutionBuilder();
        var slnDef = slnBuilder.BuildSolutionDefinition(solutionName, [projectModel]);
        File.WriteAllText($"{solutionDirectory}/{solutionName}.sln", slnDef);
    }

    private string BuildProgramClass()
    {
        var mainMethod = new CodeMemberMethod
        {
            Name = "Main",
            Attributes = MemberAttributes.Static | MemberAttributes.Public
        };
        mainMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string[]), "args"));
        mainMethod.Statements.Add(new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression("System.Console"),
            "WriteLine",
            new CodePrimitiveExpression("Hello world")));
        ProgramClass.Members.Add(mainMethod);

        var code = GenerateCSharpCode();
        return code;
    }
}