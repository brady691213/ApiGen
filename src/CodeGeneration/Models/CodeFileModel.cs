using CodeGenerators.Models;

namespace CodeGenerators;

/// <summary>
/// Represents a source code file to be created as part of a project.
/// </summary>
/// <param name="fileName">Name of the code file.</param>
/// <param name="content">Source code content of the file.</param>
public class CodeFileModel(string fileName, string content, string ns)
{
    public string? Namespace { get; set; } = ns;

    public string FileName { get; set; } = fileName;

    public string Content { get; set; } = content;
}