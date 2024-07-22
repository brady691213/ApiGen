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
        var projText =
            File.ReadAllText(
                $"{solutionModel.Name}/src/{solutionModel.ProjectModels[0].ProjectName}/{solutionModel.ProjectModels[0].ProjectName}.csproj");
    }
}