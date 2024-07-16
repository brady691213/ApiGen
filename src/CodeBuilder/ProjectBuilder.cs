namespace CodeBuilder;

public class ProjectBuilder
{
    public string BuildProjectDefinition(ProjectModel model)
    {
        var template = TemplateLoader.LoadTemplate(@"C:\Users\brady\projects\ApiGen\src\CodeBuilder\Templates\ProjectFile.csproj.txt");

        var csprojText = template.Render(new { model = model });
        
        return csprojText;
    }
}