namespace CodeBuilder;

public class SolutionFileModel
{
    public Guid SolutionId { get; set; }

    public List<ProjectFileModel> ProjectFileModels { get; set; } = new();
}