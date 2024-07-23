﻿using CodeGenerators.Errors;
using CodeGenerators.Templates;

namespace CodeGenerators.Applications;

public class ProjectGenerator(ILogger logger)
{
    /// <summary>
    /// Create a .NET project with a project (.csproj) file and C# source code (.cs) files.
    /// </summary>
    /// <param name="model">Model that defines the project to create.</param>
    /// <param name="outputLocation">Location to place the generated output. The parent directory for the created project directory.</param>
    /// <param name="writeFiles">Must be True to actually write project files to disk. Otherwise, a dry run is performed.</param>
    public Result<ProjectModel> GenerateProject(ProjectModel model, string outputLocation, bool writeFiles)
    {
        logger.Information("Generating project with name {ProjectName} in location {OutputLocation}", model.ProjectName,
            outputLocation);

        // Ensure we have a directory to write project files to.
        var pathResult = EnsureProjectDirectory(model, outputLocation, writeFiles);
        if (pathResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(pathResult);
            return Err<ProjectModel>($"Failed to render project file template: {msg}");
        }

        var projectPath = pathResult.Unwrap();
        logger.Debug("Created project directory at {ProjectPath}", projectPath);

        // Write source files before project file, avoids an invalid project file in case a write fails for a source file.
        var filesResult = WriteSourceFiles(model, projectPath, writeFiles);
        if (filesResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(filesResult);
            return Err<ProjectModel>($"Failed to write source files: {msg}");
        }

        logger.Debug("Source files written to path: {ProjectPath}", projectPath);

        // Finally write the project file once all source files have been written.
        var templateResult = RenderTemplate(model);
        if (templateResult.IsError)
        {
            var msg = RascalErrors.ErrorMessage(templateResult);
            return Err<ProjectModel>($"Failed to render project file template: {msg}");
        }

        var projectXml = templateResult.Unwrap();

        var filePath = Path.Combine(projectPath, $"{model.ProjectName}.csproj");
        if (writeFiles)
        {
            File.WriteAllText(filePath, projectXml);
            // TASKT: Wrap in Try
        }

        model.CodeModels.Add(new CodeArtifactModel("Project", fileName: $"{model.ProjectName}.csproj"));

        logger.Debug("Created project file at {ProjectFilePath}", filePath);
        return Ok(model);
    }

    private Result<string> EnsureProjectDirectory(ProjectModel model, string outputLocation, bool writeFiles)
    {
        var projectPath = Path.Combine(outputLocation, model.ProjectName);
        if (writeFiles)
        {
            if (Directory.Exists(projectPath))
            {
                return Err<string>(
                    $"Project output location {projectPath} already exists. `{nameof(model.ProjectName)}`  must specify a non-existent directory within {outputLocation}.");
            }

            return Try(() =>
            {
                Directory.CreateDirectory(projectPath);
                logger.Debug("Created project directory at {ProjectPath}", projectPath);
                return projectPath;
            });
        }

        return projectPath;
    }

    private Result<ProjectModel> WriteSourceFiles(ProjectModel model, string projectPath, bool writeFiles)
    {
        Try(() =>
        {
            foreach (var codeFile in model.CodeModels)
            {
                var codePath = Path.Combine(projectPath, $"{codeFile.FileName}.cs");
                {
                    if (writeFiles)
                    {
                        File.WriteAllText(codePath, codeFile.Content);
                    }
                }
                logger.Debug("Code file create invoked for {CodeFilePath} with {FileContent}", codePath, codeFile.Content);
                model.FilesCreated.Add(codePath);
            }
            return model;
        });
        // TASKT: Look at returning something better here.
        return model;
    }

    /// <summary>
    /// Load and render the Scriban template for a Project file (.csproj) based on a <seealso cref="ProjectModel"/>.
    /// </summary>
    private Result<string> RenderTemplate(ProjectModel model)
    {
        var result = TemplateLoader.LoadProjectFileTemplate(model.TemplateName);
        if (result.IsError)
        {
            var msg = RascalErrors.ErrorMessage(result);
            return Err<string>(msg);
        }

        var text = result.Unwrap();

        return Try(() =>
        {
            // ReSharper disable once ConvertToLambdaExpression
            var prj = text.Render(new { model = model });
            logger.Verbose("Project template {TemplateName} rendered as {TemplateText}", model.TemplateName, prj);
            return prj;
        });
    }
}