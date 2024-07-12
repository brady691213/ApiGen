using Scriban;

namespace ModelBuilder;

public class TemplateBuilder
{
    private const string DtoTemplatePath = @"C:\Users\brady\projects\ApiGen\ModelBuilder\Templates\dto.txt";
    
    public Template ParseDtoTemplate()
    {
        var templateText = File.ReadAllText(DtoTemplatePath);

        var parsedTemplate = Template.Parse(templateText);

        return parsedTemplate;
    }
}