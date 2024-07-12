using Scriban;

namespace ModelBuilder;

/// <summary>
/// A helper that loads template text from a file and uses Scriban to parse a <see cref="Template"/> object.
/// </summary>
public class TemplateLoader
{
    // TASKT: Make this path a variable that points to a lcoal soure text file for debugging and to the build output for runtime use.
    private const string DtoTemplatePath = @"C:\Users\brady\projects\ApiGen\ModelBuilder\Templates\dto.txt";
    
    /// <summary>
    /// Loads a Scriban template object for a Request or Response DTO from a text file.
    /// </summary>
    /// <returns>A <see cref="Template"/> based on the text content of the <see cref="DtoTemplatePath"/> text file.</returns>
    public Template LoadDtoTemplate()
    {
        var templateText = File.ReadAllText(DtoTemplatePath);

        var parsedTemplate = Template.Parse(templateText);

        return parsedTemplate;
    }
}