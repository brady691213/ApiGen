using CodeGenerators;
using CodeGenerators.Applications;
using Serilog;
using Shouldly;
using Xunit;

namespace CodeScaffolderIntegrationTests;

public class ProjectBuilderTests
{
    private const string SolutionName = "SolutionForTests";
    private const string ProjectName = "ProjectForTests";
    private ILogger _logger = Log.Logger;
    
    [Fact]
    public void CreateProjectThrowsOnDirExists()
    {
        var projDir = GetProjectDirectory(ProjectName);
        FileSystemTools.EnsureDirectoryExists(projDir);
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectGenerator(_logger);

        Should.Throw<InvalidOperationException>(() =>
        {
            builder.GenerateProject(model, TestConstants.OutputDirectory, false);
        });
    }

    [Fact]
    public void CreateProjectCreatesProjectDir()
    {
        FileSystemTools.EnsureEmptyOutputDir();
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectGenerator(_logger);
        
        builder.GenerateProject(model, TestConstants.OutputDirectory, false);

        var projDir = GetProjectDirectory(ProjectName);
        var exists = Directory.Exists(projDir);
        exists.ShouldBeTrue();
    }

    [Fact]
    public void GenerateProjectCreatesCsproj()
    {
        FileSystemTools.EnsureEmptyOutputDir();
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectGenerator(_logger);
        
        builder.GenerateProject(model, TestConstants.OutputDirectory, false);

        var filePath = Path.Combine(GetProjectDirectory(ProjectName), $"{ProjectName}.csproj");
        var exists = File.Exists(filePath);
        exists.ShouldBeTrue();
    }
    
    private string GetProjectDirectory(string projectName)
    {
        return Path.Combine(TestConstants.OutputDirectory, projectName);
    }
}