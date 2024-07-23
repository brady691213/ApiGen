using CodeGenerators;
using CodeGenerators.Applications;
using Shouldly;
using Xunit.Sdk;

namespace CodeGeneratorTests;

public class GeneratedSolutionFixture: IDisposable
{
    private readonly FastEndpointAppGenerator _generator = new();
    
    internal string SolutionName = "FastEndpoints";
    internal string SolutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";

    internal bool WriteFiles { get; set; } = true;
    internal bool RemoveGeneratedSolution { get; set; } = true;
    
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
        var solutionResult = _generator.GenerateApiSolution(SolutionName, SolutionOutputLocation, writeFiles: WriteFiles);
        if (!solutionResult.IsOk)
            throw new TestClassException("Solution not generated");
        //solutionResult.IsOk.ShouldBeTrue($"Result of {nameof(FastEndpointAppGenerator.GenerateApiSolution)} is not OK");
        return solutionResult.Unwrap();
    }
}