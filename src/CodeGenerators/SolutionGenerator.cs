using System.Data.SqlTypes;
using System.Diagnostics;
using CodeGenerators.Templates;
using Scriban;

namespace CodeGenerators;

public class SolutionGenerator
{
    private readonly ILogger _logger = Log.ForContext<SolutionGenerator>();

    /// <summary>
    /// Create a .NET solution file and directory.
    /// </summary>
    /// <param name="solutionModel">Model tha defines the solution to create.</param>
    /// <param name="outputLocation">Location to place the generated output. If not specified, the current directory will be used.</param>
    public Result<GenerationTaskInfo> GenerateSolution(SolutionModel solutionModel, string outputLocation, List<ProjectModel>? projectModels = null)
    {
        var genInfo = new GenerationTaskInfo(Diags.GetCurrentMethod(), outputLocation);

        var templateResult = RenderTemplate(solutionModel);
        if (templateResult.IsError)
        {
            var hasErr = templateResult.TryGetError(out var templateError);
            _logger.Error("Error rendering solution file template: {Error}", templateError);
            return Err<GenerationTaskInfo>("Failed to render solution file template");
        }
        // Unwrap may throw, but only for a really exceptional condition.
        var slnContent = templateResult.Unwrap();
        _logger.Debug("Solution file template rendered as {SolutionFileContent}", slnContent);
        
        var solutionDirectory = $"{outputLocation}/{solutionModel.SolutionName}";
        if (Directory.Exists(solutionDirectory))
        {
            return Err<GenerationTaskInfo>(
                $"Solution directory {solutionDirectory} already exists in output location {Path.GetFullPath(outputLocation)}");
        }
        Directory.CreateDirectory(solutionDirectory);
        _logger.Debug("Created solution directory {SolutionDirectory}", solutionDirectory);
        
        var filePath = Path.Combine(solutionDirectory, $"{solutionModel.SolutionName}.sln");
        if (File.Exists(filePath))
        {
            return Err<GenerationTaskInfo>($"Solution file {filePath} already exists. This module may not overwrite existing files");
        }
        File.WriteAllText(filePath, slnContent);
        _logger.Debug("Created solution file {SolutionFilePath}", solutionDirectory);

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
                _logger.Error($"Failed to generate project {project.ProjectName}", hasErr ? error.Message : "Unable to read error message from result");
            }
            else
            {
                _logger.Information($"Generated project {project.ProjectName}");
            }
        }

        return Ok(genInfo);
    }

    private Result<string> RenderTemplate(SolutionModel model)
    {
        // TASKT: Logging!
        var result = TemplateLoader.LoadFromFile("SolutionFile");
        if (result.IsError)
        {
            return Err<string>("Failed to render template");
        }

        if (result.TryGetValue(out var template))
        {
            var content = template.Render(new { model = model });
            return content;
        }

        return Err<string>("Really unexpected!");
    }
}