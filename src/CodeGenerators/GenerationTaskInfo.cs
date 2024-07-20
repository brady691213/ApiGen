namespace CodeGenerators;

/// <summary>
/// Info about a code building operation such as 
/// </summary>
public record GenerationTaskInfo(string MethodName, string? OutputLocation, List<string>? FilesCreated = null)
{
    /// <summary>
    /// Name of the method called for a code generation operation. E.g. <see cref="ProjectGenerator.GenerateProject"/>
    /// </summary>
    public string MethodName { get; set; } = MethodName;
    
    public string? OutputLocation { get; set; } = OutputLocation;

    public List<string> FilesCreated { get; set; } = FilesCreated ?? [];

    public List<GenerationTaskInfo> SubTasks { get; set; } = [];
}