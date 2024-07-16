namespace CodeBuilder;

public class SolutionBuilder
{
    // TASKT: Install Serilog
    //private object _logger = Log.ForContext<SolutionBuilder>();

    /// <summary>
    /// Create a .NET solution with projects.
    /// </summary>
    /// <param name="solutionModel">Model tha defines the solution to create.</param>
    /// <param name="outputLocation">Location to place the generated output. If not specified, the current directory will be used.</param>
    public void CreateSolution(SolutionModel solutionModel, string? outputLocation = null)
    {
        var template =
            TemplateLoader.LoadTemplate(
                @"C:\Users\brady\projects\ApiGen\src\CodeBuilder\Templates\SolutionFile.sln.txt");
        var content = template.Render(new { model = solutionModel });
        
        var solutionDirectory = $"{outputLocation}/{solutionModel.SolutionName}";
        if (Directory.Exists(solutionDirectory))
        {
            throw new InvalidOperationException(
                $"Solution output location {solutionDirectory} already exists. {solutionModel.SolutionName} must specify a non-existent directory within {outputLocation}.");
        }
        
        Directory.CreateDirectory(solutionDirectory);

        var filePath = Path.Combine(solutionDirectory, $"{solutionModel.SolutionName}.sln");
        File.WriteAllText(filePath, content);
    }
}