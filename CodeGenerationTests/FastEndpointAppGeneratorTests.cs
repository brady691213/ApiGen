using CodeGenerators.Applications;

namespace CodeGeneratorTests;

public class FastEndpointAppGeneratorTests
{
    private string solutionName = "FastEndpoints";
    private string solutionOutputLocation = @"C:\Users\brady\projects\ApiGen\test-output";
    
    [Fact]
    public void FeApiProjectModelHasCorrectPackageRefs()
    {
        var generator = new FastEndpointAppGenerator();

        var solutionResult = generator.GenerateApiSolution(solutionName, solutionOutputLocation, writeFiles: false);

        var solutionModel = solutionResult.Unwrap();
        var projText = solutionModel.ProjectModels[0].CodeFileModels[2].Content;

    }
}