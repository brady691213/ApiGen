using Scriban;

namespace EntityDecompiler;

public class TemplateBuilder
{
    private const string DtoTemplatePath = @"Templates\dto.txt";
    
    public Template ParseDtoTemplate()
    {
        var templateText = File.ReadAllText(DtoTemplatePath);

        var parsedTemplate = Template.Parse(templateText);

        return parsedTemplate;
    }
}