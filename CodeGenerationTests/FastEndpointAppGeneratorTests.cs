using CodeGenerators.Applications;

namespace CodeGeneratorTests;

public class FastEndpointAppGeneratorTests
{
    private string solutionName = "FastEndpoints";
    private string solutionOutputLocation = Directory.GetCurrentDirectory();
    
    [Fact]
    public void FeApiProjectModelHasCorrectPackageRefs()
    {
        var generator = new FastEndpointAppGenerator();

        var solutionResult = generator.GenerateApiSolution(solutionName, solutionOutputLocation, skipWrite: true);

        var solutionModel = solutionResult.Unwrap();
        var csproj =
            File.ReadAllText(
                $"{solutionModel.Name}/src/{solutionModel.ProjectModels[0].ProjectName}/{solutionModel.ProjectModels[0].ProjectName}.csproj");
    }
}