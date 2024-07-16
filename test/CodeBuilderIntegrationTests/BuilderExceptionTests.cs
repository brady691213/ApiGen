using CodeBuilder;
using Shouldly;
using Xunit;

namespace CodeBuilderIntegrationTests;

public class BuilderTests
{
    private const string OutputDirectory = @"C:\Users\brady\projects\ApiGen\sample-output";
    private const string SolutionName = "SolutionForTests";
    private const string ProjectName = "ProjectForTests";

    [Fact]
    public void CreateSolutionCreatesSolutionDir()
    {
        EnsureEmptyOutputDir();
        var model = new SolutionModel(SolutionName);
        var builder = new SolutionBuilder();
        
        builder.CreateSolution(model, OutputDirectory);

        var solDir = GetSolutionDirectory(SolutionName);
        var exists = Directory.Exists(solDir);
        exists.ShouldBeTrue();
    }

    [Fact]
    public void CreateSolutionCreatesSlnFile()
    {
        EnsureEmptyOutputDir();
        var model = new SolutionModel(SolutionName);
        var builder = new SolutionBuilder();
        
        builder.CreateSolution(model, OutputDirectory);
        
        var solDir = GetSolutionDirectory(SolutionName);
        var exists = File.Exists($"{solDir}/{SolutionName}.sln");
        exists.ShouldBeTrue();
    }

    [Fact]
    public void CreateSolutionThrowsOnDirExists()
    {
        var solDir = GetSolutionDirectory(SolutionName);
        EnsureDirectoryExists(solDir);
        var model = new SolutionModel(SolutionName);
        var builder = new SolutionBuilder();

        Should.Throw<InvalidOperationException>(() =>
        {
            builder.CreateSolution(model);
        });
    }

    [Fact]
    public void CreateProjectThrowsOnDirExists()
    {
        var projDir = GetProjectDirectory(ProjectName);
        EnsureDirectoryExists(projDir);
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectBuilder();

        Should.Throw<InvalidOperationException>(() =>
        {
            builder.CreateProject(model, OutputDirectory);
        });
    }

    private void EnsureDirectoryExists(string path)
    {
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    }

    private string GetSolutionDirectory(string solutionName)
    {
        return Path.Combine(OutputDirectory, solutionName);
    }

    private string GetProjectDirectory(string projectName)
    {
        return Path.Combine(OutputDirectory, projectName);
    }

    private void EnsureEmptyOutputDir()
    {
        Directory.Delete(OutputDirectory, true);
        Directory.CreateDirectory(OutputDirectory);
    }
}