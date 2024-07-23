using CodeGenerators;
using CodeGenerators.Applications;
using Rascal;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests;

public class FeGeneratorTests: IClassFixture<GeneratedSolutionFixture>
{
    private const string SolutionName = "FastEndpoints";
    private const string SolutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";
    
    // TASKT: These values must be provided by the gen project
    string projectName = $"{SolutionName}.Api";
    string apiNamespace = $"{SolutionName}.Api";

    private readonly SolutionModel _solutionModel;
    
    // ReSharper disable once ConvertToPrimaryConstructor
    public FeGeneratorTests(GeneratedSolutionFixture solutionFixture)
    {
        solutionFixture.RemoveGeneratedSolution = false;
        _solutionModel = solutionFixture.SolutionModel;
    }

    [Fact]
    public void SolutionHasApiProjectModel()
    {
        var projModel = _solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == $"{SolutionName}.Api");
        projModel.ShouldNotBeNull();
    }

    [Fact]
    public void ApiProjectHasProgram()
    {
        var project = GetApiProjectModel();
        var program = project.CodeFileModels.FirstOrDefault(m => m.FileName == "Program");
        
        program.ShouldNotBeNull();
    }
    
    [Fact]
    public void ProgramNamespaceCorrect()
    {
        var project = GetApiProjectModel();
        var program = project.CodeFileModels.FirstOrDefault(m => m.FileName == "Program");
        
        program.ShouldNotBeNull();
        program.Namespace.ShouldBe(apiNamespace);
    }
    
    [Fact]
    public void ApiProjectModelHasProgramFile()
    {
        var projModel = GetApiProjectModel();
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "Program");
        progFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void ApiProjectModelHasEndpoint()
    {
        var projModel = GetApiProjectModel();
        var epFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyEndpoint");
        epFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void EndpointNamespaceCorrect()
    {
        var projModel = GetApiProjectModel();
        var epFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyEndpoint");
        epFile.ShouldNotBeNull();
        epFile.Namespace.ShouldBe(apiNamespace);
    }
    
    [Fact]
    public void ApiProjectModelHasRequestDtoFile()
    {
        var projModel = GetApiProjectModel();
        var dtoFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyRequest");
        dtoFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void RequestDtoNamespaceCorrect()
    {
        var projModel = GetApiProjectModel();
        var dtoFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyRequest");
        dtoFile.ShouldNotBeNull();
        dtoFile.Namespace.ShouldBe(apiNamespace);
    }
    
    [Fact]
    public void ApiProjectModelHasResponseDtoFile()
    {
        var projModel = GetApiProjectModel();
        var progFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyResponse");
        progFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void ResponseDtoNamespaceCorrect()
    {
        var projModel = GetApiProjectModel();
        var dtoFile = projModel.CodeFileModels.FirstOrDefault(c => c.FileName == "MyResponse");
        dtoFile.ShouldNotBeNull();
        dtoFile.Namespace.ShouldBe(apiNamespace);
    }

    private ProjectModel GetApiProjectModel()
    {
        var projModel = _solutionModel.ProjectModels.FirstOrDefault(p => p.ProjectName == $"{SolutionName}.Api");
        projModel.ShouldNotBeNull();
        return projModel;
    }
}