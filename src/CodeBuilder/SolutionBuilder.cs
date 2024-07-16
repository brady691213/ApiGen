namespace CodeBuilder;

public class SolutionBuilder
{
    public string BuildSolutionDefinition(string solutionName, List<ProjectModel> projectModels)
    {
        var template = TemplateLoader.LoadTemplate(@"C:\Users\brady\projects\ApiGen\src\CodeBuilder\Templates\SolutionFile.sln.txt");

        var model = new SolutionModel();
        model.SolutionName = solutionName;
        model.ProjectModels.AddRange(projectModels);
        
        var slnText = template.Render(new { model = model });

        return slnText;
    }
}