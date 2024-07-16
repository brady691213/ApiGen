namespace CodeBuilder;

public class SolutionBuilder
{
    // TASKT: Install Serilog
    //private object _logger = Log.ForContext<SolutionBuilder>();

    /// <summary>
    /// Create files and directories to make up a solution for a console application.
    /// </summary>
    /// <param name="solutionModel">Model tha defines the solution to create.</param>
    /// <param name="outputLocation">Location to place the generated output. If not specified, the current directory will be used.</param>
    public void CreateConsoleAppSolution(SolutionModel solutionModel, string? outputLocation = null)
    {
        var solutionDirectory = $"{outputLocation}/{solutionModel.SolutionName}";
        if (Directory.Exists(solutionDirectory))
        {
            throw new InvalidOperationException(
                $"Solution output location {solutionDirectory} already exists. {solutionModel.SolutionName} must specify a non-existent directory within {outputLocation}.");
        }
        
        
    }

    private void WriteSolutionFile(string path)
    {
        try
        {
            Directory.CreateDirectory(path);
        }
        catch (Exception ex)
        {
            var msg =
                $"Failed to create solution file ";
            // TASKT: Log error.
            throw;
        }
    }

    public bool ValidateOutputLocation(string givenLocation)
    {
        if (Directory.Exists(givenLocation))
        {
            var msg =
                $"Given output directory {givenLocation} already exists. Please provide a name for a new directory";
            // TASKT: Log error.
            throw new InvalidOperationException(msg);
        }
        return true;
    } 
    
    public string BuildSolutionDefinition(string solutionName, List<ProjectModel> projectModels)
    {
        var template = TemplateLoader.LoadTemplate(@"C:\Users\brady\projects\ApiGen\src\CodeBuilder\Templates\SolutionFile.sln.txt");

        var model = new SolutionModel();
        model.SolutionName = solutionName;
        model.ProjectModels.AddRange(projectModels);
        
        var slnText = template.Render(new { model = model });

        return slnText;
    }
}