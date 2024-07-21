using System.Diagnostics;
using CodeGenerators.Templates;

namespace CodeGenerators;

public class SolutionGenerator(ILogger logger)
{
    /// <summary>
    /// Create a .NET solution file and directory.
    /// </summary>
    /// <param name="solutionModel">Model tha defines the solution to create.</param>
    /// <param name="outputLocation">Location to place the generated output. If not specified, the current directory will be used.</param>
    /// <param name="projectModels">Collection of models defining the projects to include in the solution.</param>
    public Result<SolutionModel> GenerateSolution(SolutionModel solutionModel, string outputLocation, bool skipWrite)
    {
        logger.Information("Generating solution {SolutionName} at location {OutputLocation}", solutionModel.Name,
            outputLocation);

        var slnContent = RenderTemplate(solutionModel);
        if (slnContent is null)
        {
            return Err<SolutionModel>("Failed to render solution file template");
        }

        logger.Debug("Solution file template rendered as {SolutionFileContent}", slnContent);

        var solutionDirectory = $"{outputLocation}/{solutionModel.Name}";
        if (!skipWrite && Directory.Exists(solutionDirectory))
        {
            return Err<SolutionModel>(
                $"Solution directory {solutionDirectory} already exists in output location {Path.GetFullPath(outputLocation)}");
        }

        Directory.CreateDirectory(solutionDirectory);
        logger.Debug("Created solution directory {SolutionDirectory}", solutionDirectory);

        var filePath = Path.Combine(solutionDirectory, $"{solutionModel.Name}.sln");
        if (!skipWrite && File.Exists(filePath))
        {
            return Err<SolutionModel>(
                $"Solution file {filePath} already exists. This module may not overwrite existing files");
        }

        if (!skipWrite)
        {
            File.WriteAllText(filePath, slnContent);
        }
        logger.Debug("Created solution file {SolutionFilePath}", solutionDirectory);

        var sourceLocation = $"{solutionDirectory}/src";
        var projectGenerator = new ProjectGenerator(logger);
        foreach (var project in solutionModel.ProjectModels)
        {
            var result = projectGenerator.GenerateProject(project, sourceLocation, skipWrite);
            if (result.IsError)
            {
                var hasErr = result.TryGetError(out var error);
                // For now, we bail if any project fails to build. We are only concerned with one at tne moment.
                Debug.Assert(error != null, nameof(error) + " != null");
                logger.Error($"Failed to generate project {project.ProjectName}", error.Message);
                return Err<SolutionModel>(error);
            }
            logger.Information($"Generated project {project.ProjectName}");
        }

        logger.Information("Generated solution {SolutionName} in {Location}", solutionModel.Name, outputLocation);
        return Ok(solutionModel);
    }

    private string? RenderTemplate(SolutionModel model)
    {
        var templateName = "SolutionFile";
        var result = TemplateLoader.LoadSolutionTemplate("SolutionFile.sln");
        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var templateError);
            logger.Error("Error rendering solution file template {TemplateName}: {Error}", templateName,
                templateError);
            return null;
        }

        var template = result.Unwrap();
        var content = template.Render(new { model = model });

        return content;
    }
}