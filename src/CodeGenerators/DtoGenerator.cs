using System.CodeDom.Compiler;
using CodeGenerators.Templates;

namespace CodeGenerators;

public class DtoGenerator
{
    public string GenerateDto()
    {
        var template =
            TemplateLoader.LoadFromFile(@"C:\Users\brady\projects\ApiGen\src\CodeGenerators\Templates\ApiDto.cs.txt");
        var model = new DtoModel();
        
        model.Properties.Add(new PropertyModel("string", "FirstName"));
        model.Properties.Add(new PropertyModel("string", "LastName"));
        model.Properties.Add(new PropertyModel("int", "Age"));

        var code = template.Render(new { model = model });

        return code;
    }
}