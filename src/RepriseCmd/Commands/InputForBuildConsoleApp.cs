using Oakton;

namespace RepriseCmd.Commands;

public record InputForBuildConsoleApp
{
    [FlagAlias('o')]
    [Description("Directory to write generated files to. Default is the current directory.")]
    public string OutputDirectory { get; set; } = Directory.GetCurrentDirectory();
    
    [FlagAlias('s')]
    [Description("Name for the generated solution.")]
    public string SolutionName { get; set; } = Directory.GetCurrentDirectory();
    
    [Description("Set to true to only log generation but not create files")]
    public bool DryRun { get; set; }
}