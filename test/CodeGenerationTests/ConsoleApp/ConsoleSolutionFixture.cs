using CodeGenerators;
using CodeGenerators.Applications;
using Xunit.Sdk;

namespace CodeGeneratorTests.ConsoleApp;

public class ConsoleSolutionFixture: IDisposable
{    
    private readonly ConsoleAppGenerator _generator = new();
    internal string SolutionName = "HelloWorld";
    internal string SolutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";
    internal bool WriteFiles { get; set; } = true;
    internal bool RemoveGeneratedSolution { get; set; } = true;
    internal SolutionModel SolutionModel { get; private set; }

    public ConsoleSolutionFixture()
    {
        DeleteSolutionDirectory();
        SolutionModel = GenerateApiSolution();
    }
    
    private SolutionModel GenerateApiSolution()
    {        
        var solutionResult = _generator.GenerateHelloWorldSolution(SolutionName, SolutionOutputLocation, writeFiles: WriteFiles);
        if (!solutionResult.IsOk)
            throw new TestClassException("Solution not generated");
        return solutionResult.Unwrap();
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
}