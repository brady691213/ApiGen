namespace CodeBuilder;

public class ProjectBuilder
{
    public string BuildProjectFile(string repriseVersion, string tfm)
    {
        var template = TemplateLoader.LoadCsprojTemplate();

        var model = new ProjectFileModel();
        model.ProjectFrameworkMoniker = tfm;
        model.RepriseVersion = repriseVersion;

        var csprojText = template.Render(new { model = model });

        return csprojText;
    }
}