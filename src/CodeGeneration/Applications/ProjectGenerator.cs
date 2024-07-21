using CodeGenerators.Templates;

namespace CodeGenerators;

public class ProjectGenerator(ILogger logger)
{
    private const string TemplateName = "ProjectFile.csproj";

    /// <summary>
    /// Create a .NET project with a project (.csproj) file and C# source code (.cs) files.
    /// </summary>
    /// <param name="model">Model that defines the project to create.</param>
    /// <param name="outputLocation">Location to place the generated output. The parent directory for the created project directory.</param>
    public Result<GenerationTaskInfo> GenerateProject(ProjectModel model, string outputLocation, bool skipWrite)
    {
        var genInfo = new GenerationTaskInfo(Diags.GetCurrentMethod(), outputLocation);
        logger.Information("Generating project {ProjectName} at location {OutputLocation}", model.ProjectName, outputLocation);

        var template = TemplateLoader.LoadProjectFileTemplate(TemplateName);
        logger.Information("Using template {TemplateName}", TemplateName);

        var projContent = RenderTemplate(model);
        if (projContent is null)
        {
            return Err<GenerationTaskInfo>("Failed to render project file template");
        }
        logger.Debug("Project template rendered {ProjectFileContent}", projContent);
        
        var projectPath = Path.Combine(outputLocation, model.ProjectName);
        if (Directory.Exists(projectPath))
        {
            return Err<GenerationTaskInfo>(
                $"Project output location {projectPath} already exists. `{nameof(model.ProjectName)}` must specify a non-existent directory within {outputLocation}.");
        }

        if (!skipWrite)
        {
            Directory.CreateDirectory(projectPath);
        }
        logger.Debug("Created project directory at {ProjectPath}", projectPath);

        // Write code files before project file, so we don't create an invalid project file in case a code file write fails.
        foreach (var codeFile in model.CodeFileModels)
        {
            var codePath = Path.Combine(projectPath, codeFile.FileName);
            if (!skipWrite)
            {
                File.WriteAllText(codePath, codeFile.Content);
            }
            logger.Debug("Created code file at {codePath}", codePath);

            genInfo.FilesCreated.Add(codePath);
        }
        logger.Debug("{SourceCount} source files written to {ProjectPath}", genInfo.FilesCreated.Count, projectPath);
        
        // Finally write the project file once all source files have been written.
        var filePath = Path.Combine(projectPath, $"{model.ProjectName}.csproj");
        if (!skipWrite)
        {
            File.WriteAllText(filePath, projContent);
        }
        logger.Debug("Created project file at {FilePath}", filePath);
        
        return Ok(genInfo);
    }
    
    private string? RenderTemplate(ProjectModel model)
    {
        var result = TemplateLoader.LoadProjectFileTemplate(TemplateName);
        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var templateError);
            logger.Error("Error rendering project file template {TemplateName}: {Error}", TemplateName,templateError);
            return null;
        }

        var template = result.Unwrap();
        var content = template.Render(new {model = model});

        return content;
    }
}