using Oakton;

namespace RepriseCmd.Commands;

[Description("Build a simple type")]
public class BuildTypeCommand: OaktonCommand<InputForBuildType>
{
    public override bool Execute(InputForBuildType input)
    {
        throw new NotImplementedException();
    }
}

public record InputForBuildType(string ModelName, string? OutputDirectory)
{
    [Description("Directory to write scaffolded files to. Default is the current directory.")]
    public string OutputDirectory { get; set; } = OutputDirectory ?? Directory.GetCurrentDirectory();
    
    [Description("Type name to use for the model. Required")]
    public string TypeName { get; set; } = ModelName;
}