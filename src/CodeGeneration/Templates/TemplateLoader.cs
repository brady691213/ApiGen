using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
using CodeGenerators.Errors;
using Scriban;
using Scriban.Parsing;

namespace CodeGenerators.Templates;

/// <summary>
/// A helper for preparing <see cref="Scriban"/> templates. 
/// </summary>
public class TemplateLoader
{
    private const string TemplateDirectory = @"C:\Users\brady\projects\ApiGen\src\CodeGeneration\Templates";
    
    private static readonly ILogger _logger = Log.ForContext<TemplateLoader>();

    public static Result<Template> LoadProjectFileTemplate(string templateName)
    {
        return LoadFromFile(GetTemplatePath(templateName));
    }

    public static Result<Template> LoadApiDtoTemplate()
    {
        return LoadFromFile(GetTemplatePath("ApiDto.cs"));
    }
    
    public static Result<Template> LoadSolutionTemplate(string templateName)
    {
        return LoadFromFile(GetTemplatePath(templateName));
    }
    
    /// <summary>
    /// Loads template text from a file and returns a parsed template object.
    /// </summary>
    public static Result<Template> LoadFromFile(string templatePath)
    {
        var content = File.ReadAllText(templatePath);
        _logger.Verbose("Loaded template {TemplateContent} from {TemplatePath}", content, templatePath);
        
        var template = Template.Parse(content);
        if (!template.HasErrors)
        {
            _logger.Verbose("Template {TemplateName} parsed with no errors", templatePath);
            return template;
        }

        var messages = template.Messages
            .Select(m => m.Message)
            .ToList();
        var errString = string.Join(Environment.NewLine, messages);
        _logger.Error("Template {TemplateName} parsed with error list: {ErrorList}", templatePath, errString);

        return new TemplateError("Template {TemplateName} parsed with errors.", messages);
    }

    private static string GetTemplatePath(string templateName)
    {
        return Path.Combine(TemplateDirectory, $"{templateName}.txt");
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