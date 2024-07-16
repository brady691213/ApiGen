namespace CodeBuilder;

public class SolutionBuilder
{
    public string BuilSolutionDefintion(List<ProjectModel> projectModels)
    {
        var template = TemplateLoader.LoadTemplate(@"C:\Users\brady\projects\ApiGen\src\CodeBuilder\Templates\ProjectFile.csproj.txt");

        var model = new SolutionModel();
        model.ProjectModels.AddRange(projectModels);
        
        var slnText = template.Render(new { model = model });

        return slnText;
    }
}