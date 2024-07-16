namespace CodeBuilder;

public class SolutionModel
{
    public Guid SolutionId { get; } = Guid.NewGuid();

    public List<ProjectModel> ProjectModels { get; set; } = [];
    public string SolutionName { get; set; }
}