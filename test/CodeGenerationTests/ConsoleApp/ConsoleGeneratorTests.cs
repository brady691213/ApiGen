using CodeGenerators;
using CodeGenerators.Models;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests.ConsoleApp;

public class ConsoleGeneratorTests: IClassFixture<ConsoleSolutionFixture>
{
    private const string SolutionName = "HelloWorld";
    private string MainProjectName = $"{SolutionName}.Console";
    private const string SolutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";
    private const string ApiNamespace = SolutionName;
    
    private readonly SolutionModel _solutionModel;

    public ConsoleGeneratorTests(ConsoleSolutionFixture solutionFixture)
    {
        solutionFixture.RemoveGeneratedSolution = false;
        _solutionModel = solutionFixture.SolutionModel;
    }

    [Fact]
    public void SolutionHasMainProjectModel()
    {
        var projModel = _solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == MainProjectName);
        projModel.ShouldNotBeNull();
    }
    
    [Fact]
    public void MainProjectHasProgramFile()
    {
        var projModel = GetMainProjectModel();
        var progFile = projModel.CodeModels.FirstOrDefault(c => c.FileName == "Program.cs");
        progFile.ShouldNotBeNull();
    }
    
    private ProjectModel GetMainProjectModel()
    {
        var projModel = _solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == MainProjectName);
        projModel.ShouldNotBeNull();
        return projModel;
    }
}