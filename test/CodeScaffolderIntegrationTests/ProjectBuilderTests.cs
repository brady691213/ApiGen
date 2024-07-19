using CodeScaffolding;
using Shouldly;
using Xunit;

namespace CodeScaffolderIntegrationTests;

public class ProjectBuilderTests
{
    private const string SolutionName = "SolutionForTests";
    private const string ProjectName = "ProjectForTests";
    
    
    [Fact]
    public void CreateProjectThrowsOnDirExists()
    {
        var projDir = GetProjectDirectory(ProjectName);
        FileSystemTools.EnsureDirectoryExists(projDir);
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectScaffolder();

        Should.Throw<InvalidOperationException>(() =>
        {
            builder.ScaffoldProject(model, TestConstants.OutputDirectory);
        });
    }

    [Fact]
    public void CreateProjectCreatesProjectDir()
    {
        FileSystemTools.EnsureEmptyOutputDir();
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectScaffolder();
        
        builder.ScaffoldProject(model, TestConstants.OutputDirectory);

        var projDir = GetProjectDirectory(ProjectName);
        var exists = Directory.Exists(projDir);
        exists.ShouldBeTrue();
    }

    [Fact]
    public void CreateProjectCreatesCsproj()
    {
        FileSystemTools.EnsureEmptyOutputDir();
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectScaffolder();
        
        builder.ScaffoldProject(model, TestConstants.OutputDirectory);

        var filePath = Path.Combine(GetProjectDirectory(ProjectName), $"{ProjectName}.csproj");
        var exists = File.Exists(filePath);
    }
    
    private string GetProjectDirectory(string projectName)
    {
        return Path.Combine(TestConstants.OutputDirectory, projectName);
    }
}