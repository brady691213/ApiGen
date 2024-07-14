namespace CodeBuilder;

/// <summary>
/// Settings used to define the structure used to output scaffolded code. 
/// </summary>
public class CodeOutputConfig(string outputFolder)
{
    public string OutputFolder { get; set; } = outputFolder;

    public string? RootNamespace { get; set; }
}