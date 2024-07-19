namespace CodeBuilder;

public class ProjectBuilder
{
    /// <summary>
    /// Create a .NET project with source code files.
    /// </summary>
    /// <param name="model">Model that defines the project to create.</param>
    /// <param name="outputLocation">Location to place the generated output. If not specified, the current directory will be used.</param>
    /// <exception cref="InvalidOperationException"></exception>
    public Result<CodeBuildInfo> CreateProject(ProjectModel model, string outputLocation)
    {
        var buildInfo = new CodeBuildInfo();
        
        var template = TemplateLoader.LoadFromFile(@"C:\Users\brady\projects\ApiGen\src\CodeBuilder\Templates\ProjectFile.csproj.txt");
        var content = template.Render(new { model = model });

        var projectDirectory = Path.Combine(outputLocation, model.ProjectName);
        if (Directory.Exists(projectDirectory))
        {
            return Err<CodeBuildInfo>(
                $"Project output location {projectDirectory} already exists. `{nameof(model.ProjectName)}` must specify a non-existent directory within {outputLocation}.");
        }

        Directory.CreateDirectory(projectDirectory);

        // Write code files before project file, so we don't create an invalid project file.
        foreach (var codeFile in model.CodeFileModels)
        {
            var codePath = Path.Combine(projectDirectory, codeFile.FileName);
            File.WriteAllText(codePath, codeFile.Content);
            buildInfo.FilesCreated.Add(codePath);
        }
        
        // Finally write the project file.
        var filePath = Path.Combine(projectDirectory, $"{model.ProjectName}.csproj");
        File.WriteAllText(filePath, content);
        buildInfo.FilesCreated.Add(filePath);
        
        return Ok(buildInfo);
    }
}