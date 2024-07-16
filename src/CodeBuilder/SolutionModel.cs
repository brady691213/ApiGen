namespace CodeBuilder;

public class SolutionModel(string solutionName, List<ProjectModel>? projectModels = null)
{
    public Guid SolutionId { get; } = Guid.NewGuid();
    
    public string SolutionName { get; set; } = solutionName;

    public List<ProjectModel> ProjectModels { get; set; } = projectModels ?? [];
}