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
    public void FeApiSolutionBuildNoErrors()
    {
        //var solutionModel = GenerateApiSolution();
        
       var cliOutput = CodeCompiler.BuildSolution(Path.Combine(SolutionOutputLocation, SolutionName));
        
    }
    
    [Fact]
    public void FeApiSolutionHasApiProjectModel()
    {
        var solutionModel = GenerateApiSolution();
        
        var projModel = solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == $"{SolutionName}.Api");
        
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
    
    [Fact]
    public void FeApiProjectModelHasRequestDtoFile()
    {
        var solutionModel = GenerateApiSolution();
        
        var projModel = GetApiProjectModel(solutionModel);
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyRequest");
        progFile.ShouldNotBeNull();
    }

    private SolutionModel GenerateApiSolution()
    {        
        var solutionResult = _generator.GenerateApiSolution(SolutionName, SolutionOutputLocation, writeFiles: true);
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