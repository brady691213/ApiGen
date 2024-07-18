using Scriban;

namespace CodeBuilder;

/// <summary>
/// A helper for preparing <see cref="Scriban"/> templates. 
/// </summary>
public static class TemplateLoader
{
    /// <summary>
    /// Loads template text from a file and returns a parsed template object.
    /// </summary>
    public static Template LoadTemplate(string filePath)
    {
        var templateText = File.ReadAllText(filePath);
        var parsedTemplate = Template.Parse(templateText);
        return parsedTemplate;
    }

    private static void LogTemplateErrors(Template tempalte)
    {
        // TASKT: Implment this properly.
        // Keep for more specific tests.    
        // var actualMsgs = template.Messages
        //     .Where(m => m.Type == ParserMessageType.Error)
        //     .Select(m => m.Message)
        //     .ToList();
        //
    }
}