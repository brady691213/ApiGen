using CodeGenerators;
using CodeGenerators.Applications;
using CodeGenerators.Models;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests.ConsoleApp;

public class ConsoleGeneratorTests : IClassFixture<ConsoleSolutionFixture>
{
    private const string SolutionName = "HelloWorld";
    private string MainProjectName = $"{SolutionName}.Console";
    private string FixtureSolutionOutput;
    private ConsoleAppGenerator _generator;

    private readonly SolutionModel _solutionModel;

    public ConsoleGeneratorTests(ConsoleSolutionFixture solutionFixture)
    {
        solutionFixture.RemoveGeneratedSolution = false;
        _solutionModel = solutionFixture.SolutionModel;
        FixtureSolutionOutput = solutionFixture.SolutionOutputLocation;
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

    [Fact]
    public void ProgramNamespaceCorrect()
    {
        var project = GetMainProjectModel();
        var program = project.CodeModels.FirstOrDefault(m => m.FileName == "Program.cs");

        program.ShouldNotBeNull();
        // Here the namespace is simply the same as the main project.
        program.Namespace.ShouldBe(MainProjectName);
    }

    [Fact]
    public void GeneratorErrorForNonEmptyOutput()
    {
        var generator = new ConsoleAppGenerator();
        
        // Fixture has already created at output location so this call must return error.
        var genResult = generator.GenerateConsoleAppSolution(SolutionName, FixtureSolutionOutput, writeFiles:true);
        
        genResult.IsError.ShouldBeTrue();
    }

    private ProjectModel GetMainProjectModel()
    {
        var projModel = _solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == MainProjectName);
        projModel.ShouldNotBeNull();
        return projModel;
    }
}