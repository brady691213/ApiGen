using System.Diagnostics;
using CodeGenerators.Templates;

namespace CodeGenerators;

public class SolutionGenerator
{
    private readonly ILogger _logger = Log.ForContext<SolutionGenerator>();

    /// <summary>
    /// Create a .NET solution file and directory.
    /// </summary>
    /// <param name="solutionModel">Model tha defines the solution to create.</param>
    /// <param name="outputLocation">Location to place the generated output. If not specified, the current directory will be used.</param>
    public Result<CodeBuildInfo> GenerateSolution(SolutionModel solutionModel, string outputLocation, List<ProjectModel>? projectModels = null)
    {
        var template =
            TemplateLoader.LoadFromFile(
                @"C:\Users\brady\projects\ApiGen\src\CodeGenerators\Templates\SolutionFile.sln.txt");
        var content = template.Render(new { model = solutionModel });
        
        var solutionDirectory = $"{outputLocation}/{solutionModel.SolutionName}";
        if (Directory.Exists(solutionDirectory))
        {
            return Err<CodeBuildInfo>(
                $"Solution directory {solutionDirectory} already exists in output location {Path.GetFullPath(outputLocation)}");
        }
        Directory.CreateDirectory(solutionDirectory);
        
        var filePath = Path.Combine(solutionDirectory, $"{solutionModel.SolutionName}.sln");
        if (File.Exists(filePath))
        {
            return Err<CodeBuildInfo>($"Solution file {filePath} already exists. This module may not overwrite existing files");
        }
        
        File.WriteAllText(filePath, content);

        var sourceLocation = $"{solutionDirectory}/src";
        var projectBuilder = new ProjectGenerator();
        foreach (var project in projectModels ?? [])
        {
            var result = projectBuilder.GenerateProject(project, sourceLocation);
            if (result.IsError)
            {
                var hasErr = result.TryGetError(out var error);
                // For now, we bail if any project fails to build. We are only concerned with one at tne moment.
                Debug.Assert(error != null, nameof(error) + " != null");
                _logger.Error($"Failed to scaffold project {project.ProjectName}", hasErr ? error.Message : "Unable to read error message from result");
            }
        }

        return Ok(new CodeBuildInfo());
    }
}