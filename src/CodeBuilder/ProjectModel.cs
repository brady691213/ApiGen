using System.Runtime.CompilerServices;

namespace CodeBuilder;

public class ProjectModel
{
    public ProjectModel(string projectName)
    {
        ProjectName = projectName;
        ProjectPath = $"src/{projectName}";
    }
    
    internal Guid ProjectId { get; } = Guid.NewGuid();
    
    public string ProjectName { get; set; }

    // Set by convention.
    public string ProjectPath { get; }     

    // Just a default for now.
    public string ProjectFrameworkMoniker { get; set; } = "0.0.1";
    
    // Just a default for now.
    public string RepriseVersion { get; set; } = "net9.0";

}