namespace CodeBuilder;

public class ProjectBuilder
{
    /// <summary>
    /// Create a .NET project with source code files.
    /// </summary>
    /// <param name="model">Model that defines the project to create.</param>
    /// <param name="outputLocation">Directory in which the project directory will be created.</param>
    /// <exception cref="InvalidOperationException"></exception>
    public void CreateProject(ProjectModel model, string outputLocation)
    {
        var projectDirectory = Path.Combine(outputLocation, model.ProjectName);
        var template = TemplateLoader.LoadTemplate(@"C:\Users\brady\projects\ApiGen\src\CodeBuilder\Templates\ProjectFile.csproj.txt");
        var content = template.Render(new { model = model });

        if (Directory.Exists(projectDirectory))
        {
            throw new InvalidOperationException(
                $"Project output location {projectDirectory} already exists. `{nameof(model.ProjectName)}` must specify a non-existent directory within {outputLocation}.");
        }

        // Make a place to create all the project's files in.
        Directory.CreateDirectory(outputLocation);

        // Write code files before project file, so we don't create an invalid project file.
        foreach (var codeFile in model.CodeFileModels)
        {
            var codePath = Path.Combine(outputLocation, codeFile.FileName);
            File.WriteAllText(codePath, codeFile.Content);
        }
        
        // Finally write the project file.
        var filePath = Path.Combine(outputLocation, $"{model.ProjectName}.csproj");
        File.WriteAllText(filePath, content);
    }
}