using Oakton;

namespace RepriseCmd.Commands;

public record InputForBuildType
{
    [FlagAlias('o')]
    [Description("Directory to write scaffolded files to. Default is the current directory.")]
    public string OutputDirectory { get; set; } = Directory.GetCurrentDirectory();
    
    [FlagAlias('n')]
    [Description("Type name to use for the model. Required")]
    public string TypeName { get; set; }
}