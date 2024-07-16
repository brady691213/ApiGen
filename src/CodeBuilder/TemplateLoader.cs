using Scriban;

namespace CodeBuilder;

/// <summary>
/// A helper that loads template text from a file and uses Scriban to parse a <see cref="Template"/> object.
/// </summary>
public class TemplateLoader
{
    private static string _dtoTemplatePath = @"Templates\ProjectFile.sb";
    
    public static Template LoadTemplate(string filePath)
    {
        var templateText = File.ReadAllText(filePath);
        var parsedTemplate = Template.Parse(templateText);
        return parsedTemplate;
    }
}