using System.Diagnostics;
using CodeGenerators.Applications;
using CodeGenerators.Errors;
using CodeGenerators.Templates;

namespace CodeGenerators;

public class SolutionGenerator(ILogger logger)
{
    private const string TemplateName = "SolutionFile.sln";
    
    /// <summary>
    /// Create a .NET solution file and directory.
    /// </summary>
    /// <param name="model">Model tha defines the solution to create.</param>
    /// <param name="outputLocation">Location to place the generated output. If not specified, the current directory will be used.</param>
    /// <param name="projectModels">Collection of models defining the projects to include in the solution.</param>
    public Result<SolutionModel> GenerateSolution(SolutionModel model, string outputLocation, bool writeFiles)
    {
        logger.Information("Generating solution {SolutionName} at location {OutputLocation}", model.Name,
            outputLocation);

        // Ensure we have a solution directory.
        var pathResult = EnsureSolutionDirectory(model, outputLocation, writeFiles);
        if (pathResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(pathResult);
            return Err<SolutionModel>($"Failed to create solution directory in {outputLocation}: {msg}");
        }
        var solutionPath = pathResult.Unwrap();       
        
        // Now create project directories and files.
        var projectsResult = GenerateProjects(model, solutionPath, writeFiles);
        if (projectsResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(projectsResult);
            return Err<SolutionModel>($"Failed to generate all projects in solution: {msg}");
        }        
        
        // Finally, we can create a valid solution file once other files have been created.
        var templateResult = RenderTemplate(model);
        if (templateResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(templateResult);
            return Err<SolutionModel>($"Failed to render solution file template: {msg}");
        }
        var slnContent = templateResult.Unwrap();
        
        var filePath = Path.Combine(solutionPath, $"{model.Name}.sln");
        if (writeFiles && File.Exists(filePath))
        {
            return Err<SolutionModel>(
                $"Solution file {filePath} already exists. This module may not overwrite existing files");
        }
        if (writeFiles)
        {
            File.WriteAllText(filePath, slnContent);
        }
        logger.Debug("Created solution file {SolutionFilePath}", solutionPath);
        
        logger.Information("Generated solution {SolutionName} in {Location}", model.Name, outputLocation);
        return Ok(model);
    }

    private Result<SolutionModel> GenerateProjects(SolutionModel model, string outputLocation, bool writeFiles)
    {
        var sourcePath = Path.Combine(outputLocation, "src");
        var projectGenerator = new ProjectGenerator(logger);
        foreach (var project in model.ProjectModels)
        {
            var result = projectGenerator.GenerateProject(project, sourcePath, writeFiles);
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

        return Ok(model);
    }
    
    private Result<string> EnsureSolutionDirectory(SolutionModel model, string outputLocation, bool writeFiles)
    {
        var solutionPath = $"{outputLocation}/{model.Name}";
        if (writeFiles)
        {
            if (Directory.Exists(solutionPath))
            {
                return Err<string>(
                    $"Solution directory {solutionPath} already exists in output location {Path.GetFullPath(outputLocation)}");
            }
            Directory.CreateDirectory(solutionPath);
        }
        logger.Debug("Created solution directory at {SolutionPath}", solutionPath);
        return solutionPath;
    }

    /// <summary>
    /// Load and render the Scriban template for a Solution file (.sln) based on a <seealso cref="SolutionModel"/>.
    /// </summary>
    private Result<string> RenderTemplate(SolutionModel model)
    {
        var result = TemplateLoader.LoadSolutionTemplate(TemplateName);
        if (result.IsError)
        {
            var msg = RascalErrors.ErrorMessage(result);
            return Err<string>(msg);
        }

        var text = result.Unwrap();
        logger.Verbose("Solution template {TemplateName} rendered as {TemplateText}", text, TemplateName);

        var content = Try(() =>
        {
            // ReSharper disable once ConvertToLambdaExpression
            return text.Render(new { model = model });
        });
        
        logger.Verbose("Solution template rendered {SolutionFileContent}", content);
        return content;
    }
}