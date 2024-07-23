using CodeGenerators;
using CodeGenerators.Applications;
using Rascal;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests;

public class FastEndpointAppGeneratorTests: IClassFixture<GeneratedSolutionFixture>
{
    private const string SolutionName = "FastEndpoints";
    private const string SolutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";

    private readonly SolutionModel _solutionModel;
    
    // ReSharper disable once ConvertToPrimaryConstructor
    public FastEndpointAppGeneratorTests(GeneratedSolutionFixture solutionFixture)
    {
        _solutionModel = solutionFixture.SolutionModel;
    }

    [Fact]
    public void SolutionHasApiProjectModel()
    {
        var projModel = _solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == $"{SolutionName}.Api");
        
        projModel.ShouldNotBeNull();
    }
    
    [Fact]
    public void ApiProjectModelHasProgramFile()
    {
        var projModel = GetApiProjectModel();
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "Program");
        progFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void ApiProjectModelHasRequestDtoFile()
    {
        var projModel = GetApiProjectModel();
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyRequest");
        progFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void ApiProjectModelHasResponseDtoFile()
    {
        var projModel = GetApiProjectModel();
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyResponse");
        progFile.ShouldNotBeNull();
    }

    private ProjectModel GetApiProjectModel()
    {
        var projModel = _solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == $"{SolutionName}.Api");
        projModel.ShouldNotBeNull();
        return projModel;
    }
}