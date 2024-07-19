namespace CodeScaffolding;

/// <summary>
/// Info about a code building operation such as 
/// </summary>
public class CodeBuildInfo
{
    public string OperationName { get; set; }

    public List<string> FilesCreated { get; set; } = new();
}