using CodeGenerators;
using CodeGenerators.Applications;
using Shouldly;

namespace CodeGeneratorTests;

public class GeneratedSolutionFixture: IDisposable
{
    private readonly FastEndpointAppGenerator _generator = new();
    
    internal string SolutionName = "FastEndpoints";
    internal string SolutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";
    
    internal bool RemoveGeneratedSolution { get; set; }
    
    internal SolutionModel SolutionModel { get; private set; }

    public GeneratedSolutionFixture()
    {
        DeleteSolutionDirectory();
        SolutionModel = GenerateApiSolution();
    }
    
    public void Dispose()
    {
        DeleteSolutionDirectory();
    }

    private void DeleteSolutionDirectory()
    {
        if (!RemoveGeneratedSolution) return;
        if (Directory.Exists(Path.Combine(SolutionOutputLocation, SolutionName)))
            Directory.Delete(Path.Combine(SolutionOutputLocation, SolutionName), recursive:true);
    }
    
    private SolutionModel GenerateApiSolution()
    {        
        var solutionResult = _generator.GenerateApiSolution(SolutionName, SolutionOutputLocation, writeFiles: true);
        solutionResult.IsOk.ShouldBeTrue($"Result of {nameof(FastEndpointAppGenerator.GenerateApiSolution)} is not OK");
        return solutionResult.Unwrap();
    }
}