using CodeScaffolding;
using Shouldly;
using Xunit;

namespace CodeScaffolderIntegrationTests;

public class TemplateTests
{
    [Theory]
    [ClassData(typeof(TemplatesTheoryData))]
    public void TemplatesParseNoErrors(string templatePath)
    {
        var expectedMessages = new List<string>();
        
        var template = TemplateLoader.LoadFromFile(templatePath);

        template.HasErrors.ShouldBeFalse($"Template {Path.GetFileName(templatePath)} has errors.");
    }
}

public class TemplatesTheoryData: TheoryData<string>
{
    public TemplatesTheoryData()
    {
        var files = Directory.GetFiles(@"src/CodeScaffolding/Templates");
        foreach (var file in files)
        {
            Add(Path.GetFullPath(file));
        }
    }
}