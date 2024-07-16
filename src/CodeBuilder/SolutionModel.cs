namespace CodeBuilder;

public class SolutionModel
{
    public Guid SolutionId { get; } = Guid.NewGuid();
    
    public string SolutionName { get; set; }

    public List<ProjectModel> ProjectModels { get; set; } = [];
}