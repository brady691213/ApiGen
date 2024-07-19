using CodeScaffolding;
using CodeScaffolding.Applications;
using Oakton;
using Serilog;
using ILogger = Serilog.ILogger;

namespace RepriseCmd.Commands;

[Description("Build a console app that prints \"Hello World\"")]
public class BuildConsoleAppAppCommand: OaktonCommand<InputForBuildConsoleApp>
{
    private readonly ILogger _logger = Log.ForContext<BuildConsoleAppAppCommand>();
    
    public BuildConsoleAppAppCommand()
    {
        Usage("Build a console app in the given output directory").Arguments(x => x.OutputDirectory);
    }
    
    public override bool Execute(InputForBuildConsoleApp input)
    {
        _logger.Information($"Building started for console application. Source files will be written to {input.OutputDirectory}.");

        var builder = new ConsoleAppScaffolder();
        var result = builder.BuildHelloWorldApp(input.OutputDirectory);
        
        _logger.Information($"Building completed for console application. Source written to {input.OutputDirectory}.");
        
        return result;
    }
}