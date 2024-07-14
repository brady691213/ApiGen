using CodeBuilder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Oakton;

namespace RepriseCmd.Commands;

[Description("Build a simple type")]
public class BuildTypeCommand: OaktonCommand<InputForBuildType>
{
    private ILogger<BuildTypeCommand> _logger;
    
    public BuildTypeCommand()
    {
        //_logger = logger;
        // Usage("Build a type in the current directory").Arguments(x => x.TypeName);
        // Usage("Build a type in the given outputDirectory").Arguments(x => x.TypeName, x => x.OutputDirectory);
    }
    
    public override bool Execute(InputForBuildType input)
    {
        //_logger.LogInformation($"Building type {input.TypeName} with output to {input.OutputDirectory}");

        var bld = new ConsoleAppBuilder();
        var code = bld.BuildHelloWorldApp();
        
        Console.WriteLine(code);
        return true;
    }
}