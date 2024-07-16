using System.CodeDom;

namespace CodeBuilder;

public class ConsoleAppBuilder
{
    public void BuildHelloWorldApp(string outputDirectory)
    {
        var projectName = "HelloWorld";

        // For now, we just use the project name as a solution name and path.
        var solutionName = projectName;
        var solutionDirectory = $"{outputDirectory}/{solutionName}";
        
        var sourceLocation = $"{solutionDirectory}/src";

        var progSource = BuildProgramClass(projectName);
        var progModel = new CodeFileModel("Program.cs", progSource);

        var projectModel = new ProjectModel(projectName, [progModel]);
        var projectBuilder = new ProjectBuilder();
        projectBuilder.CreateProject(projectModel, sourceLocation);        
        
        var slnBuilder = new SolutionBuilder();
        var slnModel = new SolutionModel(solutionName, [projectModel]);
        
        slnBuilder.CreateSolution(slnModel, solutionDirectory);
    }

    private string BuildProgramClass(string @namespace)
    {
        var classBuilder = new ClassBuilder();

        var rootNamespace = classBuilder.BuildNamespace(@namespace);
        var programClass = classBuilder.BuildClass("Program");
        var mainMethod = classBuilder.BuildMainMethod();
        
        programClass.Members.Add(mainMethod);
        rootNamespace.Types.Add(programClass);

        var code = classBuilder.GenerateCSharpCode([rootNamespace]);
        return code;
    }
}