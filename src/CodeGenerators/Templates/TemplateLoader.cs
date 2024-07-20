using System.Diagnostics;
using System.Reflection;
using Scriban;

namespace CodeGenerators.Templates;

/// <summary>
/// A helper for preparing <see cref="Scriban"/> templates. 
/// </summary>
public static class TemplateLoader
{
    /// <summary>
    /// Loads template text from a file and returns a parsed template object.
    /// </summary>
    public static Template LoadFromFile(string filePath)
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

    private static Template LoadFromResource(string templateName)
    {
        // Shamelessly borrowed from: https://stackoverflow.com/a/3314213/8741
        
        var asm = Assembly.GetAssembly(typeof(TemplateLoader));
        Debug.Assert(asm != null, nameof(asm) + " != null");
        
        var resourceName = asm.GetManifestResourceNames()
            .SingleOrDefault(str => str == templateName);
        Debug.Assert(resourceName != null, nameof(resourceName) + " != null");
        
        using var stream = asm.GetManifestResourceStream(resourceName);
        Debug.Assert(stream != null, nameof(stream) + " != null");
        
        using var reader = new StreamReader(stream);
        var templateText = reader.ReadToEnd();

        var parsedTemplate = Template.Parse(templateText);

        return parsedTemplate;
    }
}