using CodeGenerators.Templates;

namespace CodeGenerators;

public class ProjectGenerator
{
    private const string TemplateName = "ProjectFile";
    
    private readonly ILogger _logger = Log.ForContext<ProjectGenerator>();

    /// <summary>
    /// Create a .NET project with a project (.csproj) file and C# source code (.cs) files.
    /// </summary>
    /// <param name="model">Model that defines the project to create.</param>
    /// <param name="outputLocation">Location to place the generated output. The parent directory for the created project directory.</param>
    public Result<GenerationTaskInfo> GenerateProject(ProjectModel model, string outputLocation)
    {
        var genInfo = new GenerationTaskInfo(Diags.GetCurrentMethod(), outputLocation);
        _logger.Information("Generating project {ProjectName} into location {OutputLocation}", model, outputLocation);

        var template = TemplateLoader.LoadProjectFileTemplate();
        _logger.Information("Using template {TemplateName} from file.", TemplateName);

        var projContent = RenderTemplate(model);
        if (projContent is null)
        {
            return Err<GenerationTaskInfo>("Failed to render project file template");
        }
        _logger.Debug("Project template rendered {ProjectFileContent}", projContent);
        
        var projectPath = Path.Combine(outputLocation, model.ProjectName);
        if (Directory.Exists(projectPath))
        {
            return Err<GenerationTaskInfo>(
                $"Project output location {projectPath} already exists. `{nameof(model.ProjectName)}` must specify a non-existent directory within {outputLocation}.");
        }
        Directory.CreateDirectory(projectPath);
        _logger.Debug("Created project directory at {ProjectPath}", projectPath);

        // Write code files before project file, so we don't create an invalid project file in case a code file write fails.
        foreach (var codeFile in model.CodeFileModels)
        {
            var codePath = Path.Combine(projectPath, codeFile.FileName);
            File.WriteAllText(codePath, codeFile.Content);
            genInfo.FilesCreated.Add(codePath);
        }
        _logger.Debug("{SourceCount} source files written to {ProjectPath}", genInfo.FilesCreated.Count, projectPath);
        
        // Finally write the project file once all source files have been written.
        var filePath = Path.Combine(projectPath, $"{model.ProjectName}.csproj");
        File.WriteAllText(filePath, projContent);
        genInfo.FilesCreated.Add(filePath);
        _logger.Debug("Created project file at {FilePath}", filePath);
        
        return Ok(genInfo);
    }
    
    private string? RenderTemplate(ProjectModel model)
    {
        var templateName = "ProjectFile";
        var result = TemplateLoader.LoadProjectFileTemplate();
        if (result.IsError)
        {
            var hasErr = result.TryGetError(out var templateError);
            _logger.Error("Error rendering project file template {TemplateName}: {Error}", templateName,templateError);
            return null;
        }

        var template = result.Unwrap();
        var content = template.Render(new {model = model});

        return content;
    }
}