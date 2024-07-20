using CodeGenerators.Templates;

namespace CodeGenerators.Applications;

public class FastEndpointAppGenerator
{
    public Result<CodeBuildInfo> GenerateApp(string solutionName)
    {
        // For now, we just use the solution name as a project name and path.
        var projectName = solutionName;
        var apiNamespace = projectName;
        
        var progSource = BuildProgramClass(apiNamespace);
        var programModel = new CodeFileModel("Program.cs", progSource);
        
        var dto = BuildRequestDto();
        var dtoModel = new CodeFileModel("Request.cs", dto);
        
        var projectModel = new ProjectModel(projectName, [programModel, dtoModel]);

        return Err<CodeBuildInfo>("Not fully implemented.");
    }
    
    private string BuildProgramClass(string @namespace)
    {
        var template =
            TemplateLoader.LoadFromFile(
                @"C:\Users\brady\projects\ApiGen\src\CodeGenerators\Templates\FastEndpointsProgramClass.cs.txt");
        var code = template.Render();

        return code;
    }

    private string BuildRequestDto()
    {
        var code = """
                   public class MyRequest
                   {
                       public string FirstName { get; set; }
                       public string LastName { get; set; }
                       public int Age { get; set; }
                   }
                   """;
        return code;
    }
}