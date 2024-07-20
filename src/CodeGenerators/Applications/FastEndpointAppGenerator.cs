// using CodeGenerators.Errors;
// using CodeGenerators.Templates;
//
// namespace CodeGenerators.Applications;
//
// public class FastEndpointAppGenerator
// {
//     private readonly ILogger _logger = Log.ForContext<FastEndpointAppGenerator>();
//     
//     /// <summary>
//     /// Generate the main application for a FastEndpoints web API.
//     /// </summary>
//     /// <param name="solutionName"></param>
//     /// <returns></returns>
//     public Result<GenerationTaskInfo> GenerateApp(string solutionName, string outputLocation)
//     {
//         var genInfo = new GenerationTaskInfo(Diags.GetCurrentMethod(), outputLocation);
//         
//         // For now, we just use the solution name as a project name and path.
//         var projectName = solutionName;
//         var apiNamespace = projectName;
//         
//         var progSource = BuildProgramClass(apiNamespace);
//         var programModel = new CodeFileModel("Program.cs", progSource);
//         
//         var dto = BuildRequestDto();
//         var dtoModel = new CodeFileModel("Request.cs", dto);
//         
//         var projectModel = new ProjectModel(projectName, [programModel, dtoModel]);
//
//         return new NotFinishedError("Not fully implemented.");
//     }
//     
//     private string BuildProgramClass(string @namespace)
//     {
//         var result =
//             TemplateLoader.LoadFromFile(
//                 @"C:\Users\brady\projects\ApiGen\src\CodeGenerators\Templates\FastEndpointsProgramClass.cs.txt");
//         if (result.IsError)
//         {
//             var hasErr = result.TryGetError(out var templateError);
//             _logger.Error("Error rendering solution file template {TemplateName}: {Error}", templateName,templateError);
//             return null;
//         }
//
//         return code;
//     }
//
//     private string BuildRequestDto()
//     {
//         var code = """
//                    public class MyRequest
//                    {
//                        public string FirstName { get; set; }
//                        public string LastName { get; set; }
//                        public int Age { get; set; }
//                    }
//                    """;
//         return code;
//     }
// }