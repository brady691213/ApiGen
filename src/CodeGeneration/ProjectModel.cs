using System.Reflection;

namespace CodeGenerators;

public class ProjectModel(string projectName, List<CodeFileModel>? codeFileModels = null)
{
    public Guid ProjectId { get; } = Guid.NewGuid();
    
    public string ProjectName { get; set; } = projectName;

    public List<PackageReferenceModel> PackageReferences { get; set; } = new();

    public List<CodeFileModel> CodeFileModels { get; set; } = codeFileModels ?? [];

    // Just a default for now.
    public string ProjectFrameworkMoniker { get; set; } = "net9.0";
    
    // Just a default for now.
    public string RepriseVersion { get; } = GetExecutingVersion();

    private static string GetExecutingVersion()
    {
        return Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "0.0.0";
    }
}