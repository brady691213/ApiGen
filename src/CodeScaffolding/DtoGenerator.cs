using System.CodeDom;
using System.CodeDom.Compiler;

namespace CodeScaffolding;

public class DtoGenerator
{
    private CodeDomProvider _provider = CodeDomProvider.CreateProvider("CSharp");
    private CodeGeneratorOptions _generateOptions = new();
    
    public string GenerateDto()
    {
        var template =
            TemplateLoader.LoadFromFile(@"C:\Users\brady\projects\ApiGen\src\CodeScaffolding\Templates\ApiDto.cs.txt");
        var model = new DtoModel();
        
        model.Properties.Add(new PropertyModel("string", "FirstName"));
        model.Properties.Add(new PropertyModel("string", "LastName"));
        model.Properties.Add(new PropertyModel("int", "Age"));

        var code = template.Render(new { model = model });

        return code;
    }
}