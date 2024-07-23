using CodeGenerators;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests.ConsoleApp;

public class ConsoleGeneratorTests: IClassFixture<ConsoleSolutionFixture>
{
    private const string SolutionName = "HelloWorld";
    private const string SolutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";
    private const string ApiNamespace = SolutionName;
    
    private readonly SolutionModel _solutionModel;

    public ConsoleGeneratorTests(ConsoleSolutionFixture solutionFixture)
    {
        solutionFixture.RemoveGeneratedSolution = false;
        _solutionModel = solutionFixture.SolutionModel;
    }

    [Fact]
    public void SolutionHasProjectModel()
    {
        var projectName = $"{SolutionName}.Console";
        var projModel = _solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == projectName);
        projModel.ShouldNotBeNull();
    }
}