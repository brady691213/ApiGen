using CodeGenerators;
using CodeGenerators.Models;
using Shouldly;
using Xunit;

namespace CodeGeneratorTests.FastEndpoints;

public class FastEndpointsGeneratorTests: IClassFixture<FastEndpointsSolutionFixture>
{
    private const string SolutionName = "FastEndpoints";
    private const string SolutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";
    
    string apiNamespace = $"{SolutionName}.Api";

    private readonly SolutionModel _solutionModel;
    
    // ReSharper disable once ConvertToPrimaryConstructor
    public FastEndpointsGeneratorTests(FastEndpointsSolutionFixture solutionFixture)
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
    public void ApiProjectHasProgramFile()
    {
        var project = GetApiProjectModel();
        var program = project.CodeModels.FirstOrDefault(m => m.FileName == "Program.cs");
        program.ShouldNotBeNull();
    }
    
    [Fact]
    public void ProgramNamespaceCorrect()
    {
        var project = GetApiProjectModel();
        var program = project.CodeModels.FirstOrDefault(m => m.FileName == "Program.cs");
        
        program.ShouldNotBeNull();
        program.Namespace.ShouldBe(apiNamespace);
    }
    
    [Fact]
    public void ApiProjectModelHasEndpoint()
    {
        var projModel = GetApiProjectModel();
        var epFile = projModel.CodeModels.FirstOrDefault(c => c.FileName == "MyEndpoint.cs");
        epFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void EndpointNamespaceCorrect()
    {
        var projModel = GetApiProjectModel();
        var epFile = projModel.CodeModels.FirstOrDefault(c => c.FileName == "MyEndpoint.cs");
        epFile.ShouldNotBeNull();
        epFile.Namespace.ShouldBe(apiNamespace);
    }
    
    [Fact]
    public void ApiProjectModelHasRequestDtoFile()
    {
        var projModel = GetApiProjectModel();
        var dtoFile = projModel.CodeModels.FirstOrDefault(c => c.FileName == "MyRequest.cs");
        dtoFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void RequestDtoNamespaceCorrect()
    {
        var projModel = GetApiProjectModel();
        var dtoFile = projModel.CodeModels.FirstOrDefault(c => c.FileName == "MyRequest.cs");
        dtoFile.ShouldNotBeNull();
        dtoFile.Namespace.ShouldBe(apiNamespace);
    }
    
    [Fact]
    public void ApiProjectModelHasResponseDtoFile()
    {
        var projModel = GetApiProjectModel();
        var progFile = projModel.CodeModels.FirstOrDefault(c => c.FileName == "MyResponse.cs");
        progFile.ShouldNotBeNull();
    }
    
    [Fact]
    public void ResponseDtoNamespaceCorrect()
    {
        var projModel = GetApiProjectModel();
        var dtoFile = projModel.CodeModels.FirstOrDefault(c => c.FileName == "MyResponse.cs");
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