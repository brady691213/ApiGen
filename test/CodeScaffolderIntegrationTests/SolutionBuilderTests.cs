using CodeBuilder;
using Shouldly;
using Xunit;

namespace CodeBuilderIntegrationTests;

public class SolutionBuilderTests
{
    private const string SolutionName = "SolutionForTests";
    private const string ProjectName = "ProjectForTests";

    [Fact]
    public void CreateSolutionCreatesSolutionDir()
    {
        FileSystemTools.EnsureEmptyOutputDir();
        var model = new SolutionModel(SolutionName);
        var builder = new SolutionBuilder();
        
        builder.ScaffoldSolution(model, TestConstants.OutputDirectory, null);

        var solDir = FileSystemTools.GetSolutionDirectory(SolutionName);
        var exists = Directory.Exists(solDir);
        exists.ShouldBeTrue();
    }

    [Fact]
    public void CreateSolutionCreatesSlnFile()
    {
        FileSystemTools.EnsureEmptyOutputDir();
        var model = new SolutionModel(SolutionName);
        var builder = new SolutionBuilder();
        
        builder.ScaffoldSolution(model, TestConstants.OutputDirectory, null);
        
        var solDir = FileSystemTools.GetSolutionDirectory(SolutionName);
        var exists = File.Exists($"{solDir}/{SolutionName}.sln");
        exists.ShouldBeTrue();
    }

    [Fact]
    public void CreateSolutionThrowsOnDirExists()
    {
        var solDir = FileSystemTools.GetSolutionDirectory(SolutionName);
        FileSystemTools.EnsureDirectoryExists(solDir);
        var model = new SolutionModel(SolutionName);
        var builder = new SolutionBuilder();

        Should.Throw<InvalidOperationException>(() =>
        {
            builder.ScaffoldSolution(model);
        });
    }
    

}