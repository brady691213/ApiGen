using CodeGenerators;
using CodeGenerators.Applications;
using Rascal;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests;

public class FastEndpointAppGeneratorTests
{
    private const string SolutionName = "FastEndpoints";
    private const string SolutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";

    private readonly FastEndpointAppGenerator _generator = new FastEndpointAppGenerator();
    
    [Fact]
    public void SolutionHasApiProjectModel()
    {
        var solutionModel = GenerateApiSolution();
        
        var projModel = solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == $"{SolutionName}.Api");
        
        projModel.ShouldNotBeNull();
    }
    
    [Fact]
    public void ApiProjectModelHasProgramFile()
    {
        var solutionModel = GenerateApiSolution();
        
        var projModel = GetApiProjectModel(solutionModel);
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "Program");
        progFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void ApiProjectModelHasRequestDtoFile()
    {
        var solutionModel = GenerateApiSolution();
        
        var projModel = GetApiProjectModel(solutionModel);
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyRequest");
        progFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void ApiProjectModelHasResponseDtoFile()
    {
        var solutionModel = GenerateApiSolution();
        
        var projModel = GetApiProjectModel(solutionModel);
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyResponse");
        progFile.ShouldNotBeNull();
    }

    private SolutionModel GenerateApiSolution()
    {        
        var solutionResult = _generator.GenerateApiSolution(SolutionName, SolutionOutputLocation, writeFiles: false);
        solutionResult.IsOk.ShouldBeTrue($"Result of {nameof(FastEndpointAppGenerator.GenerateApiSolution)} is not OK");
        return solutionResult.Unwrap();
    }

    private ProjectModel GetApiProjectModel(SolutionModel solutionModel)
    {
        var projModel = solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == $"{SolutionName}.Api");
        projModel.ShouldNotBeNull();
        return projModel;
    }
}