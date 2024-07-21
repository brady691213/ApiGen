using System.CodeDom.Compiler;
using CodeGenerators.Models;
using CodeGenerators.Templates;

namespace CodeGenerators;

public class DtoBuilder
{
    public string? GenerateDto()
    {
        var result = TemplateLoader.LoadApiDtoTemplate();
        var model = new DtoModel();
        
        model.Properties.Add(new PropertyModel("string", "FirstName"));
        model.Properties.Add(new PropertyModel("string", "LastName"));
        model.Properties.Add(new PropertyModel("int", "Age"));

        if (result.IsOk)
        {
            var okValue = result.TryGetValue(out var template);
            return okValue ? template!.Render(model) : null;
        }

        return null;
    }
}