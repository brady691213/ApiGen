namespace CodeGenerators;

public class SolutionModel(string solutionName, List<ProjectModel>? projectModels = null)
{
    public Guid SolutionId { get; } = Guid.NewGuid();
    
    public string Name { get; set; } = solutionName;

    public List<ProjectModel> ProjectModels { get; set; } = projectModels ?? [];
}