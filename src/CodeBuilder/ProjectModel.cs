using System.Runtime.CompilerServices;

namespace CodeBuilder;

public class ProjectModel
{
    public ProjectModel(string projectName)
    {
        ProjectName = projectName;
    }
    
    public Guid ProjectId { get; } = Guid.NewGuid();
    
    public string ProjectName { get; set; }

    // Just a default for now.
    public string ProjectFrameworkMoniker { get; set; } = "net9.0";
    
    // Just a default for now.
    public string RepriseVersion { get; set; } = "0.0.1";

}