using Oakton;

namespace RepriseCmd.Commands;

public record InputForBuildType(string ModelName, string? OutputDirectory)
{
    [FlagAlias('o')]
    [Description("Directory to write scaffolded files to. Default is the current directory.", Name = "output-directory")]
    public string OutputDirectory { get; set; } = OutputDirectory ?? Directory.GetCurrentDirectory();
    
    [FlagAlias('n')]
    [Description("Type name to use for the model. Required")]
    public string TypeName { get; set; } = ModelName;
}