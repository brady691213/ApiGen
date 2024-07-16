namespace CodeBuilder;

public class SolutionBuilder
{
    public string BuilSolutionDefintion(List<ProjectFileModel> projectFileModels)
    {
        var template = TemplateLoader.LoadTemplate(@"C:\Users\brady\projects\ApiGen\src\CodeBuilder\Templates\ProjectFile.csproj.txt");

        var model = new SolutionFileModel();
        model.SolutionId = Guid.NewGuid();
        
        model.ProjectFileModels.AddRange(projectFileModels);

        var slnText = template.Render(new { model = model });

        return slnText;
    }
}