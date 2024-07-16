using CodeBuilder;
using Xunit;

namespace CodeBuilderIntegrationTests;

public class BuilderExceptionTests
{
    private const string OutputDirectory = @"C:\Users\brady\projects\ApiGen\sample-output";
    private const string SolutionName = "SolutionForTests";
    
    [Fact]
    public void CreateSolutionThrowsInvalidOperation()
    {
        var solDir = GetSolutionDirectory(SolutionName);
        EnsureDirectoryExists(solDir);
        var model = new SolutionModel(SolutionName);
        var builder = new SolutionBuilder();

        Assert.Throws<InvalidOperationException>(() =>
        {
            builder.CreateSolution(model);
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
}