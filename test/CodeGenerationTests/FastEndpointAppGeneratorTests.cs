using CodeGenerators;
using CodeGenerators.Applications;
using Rascal;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests;

public class FastEndpointAppGeneratorTests
{
    private string solutionName = "FastEndpoints";
    private string solutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";
    
    private FastEndpointAppGenerator generator = new FastEndpointAppGenerator();

    
    [Fact]
    public void FeApiSolutionHasApiProjectModel()
    {
        var solutionModel = GenerateApiSolution();
        
        var projModel = solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == $"{solutionName}.Api");
        
        projModel.ShouldNotBeNull();
    }
    
    [Fact]
    public void FeApiProjectModelHasProgramFile()
    {
        var solutionModel = GenerateApiSolution();
        
        var projModel = GetApiProjectModel(solutionModel);
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "Program");
        progFile.ShouldNotBeNull();
    }

    private SolutionModel GenerateApiSolution()
    {        
        var solutionResult = generator.GenerateApiSolution(solutionName, solutionOutputLocation, writeFiles: false);
        solutionResult.IsOk.ShouldBeTrue($"Result of {nameof(FastEndpointAppGenerator.GenerateApiSolution)} is not OK");
        return solutionResult.Unwrap();
    }

    private ProjectModel GetApiProjectModel(SolutionModel solutionModel)
    {
        var projModel = solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == $"{solutionName}.Api");
        projModel.ShouldNotBeNull();
        return projModel;
    }
}