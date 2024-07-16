using CodeBuilder;
using Oakton;
using Serilog;
using ILogger = Serilog.ILogger;

namespace RepriseCmd.Commands;

[Description("Build a simple type")]
public class BuildAppCommand: OaktonCommand<InputForBuildType>
{
    internal ILogger Logger = Log.ForContext<BuildAppCommand>();
    
    public BuildAppCommand()
    {
        //_logger = logger;
        // Usage("Build a type in the current directory").Arguments(x => x.TypeName);
        // Usage("Build a type in the given outputDirectory").Arguments(x => x.TypeName, x => x.OutputDirectory);
    }
    
    public override bool Execute(InputForBuildType input)
    {
        Logger.Information($"Building type {input.TypeName} with output to {input.OutputDirectory}");

        var bld = new ConsoleAppBuilder();
        bld.BuildHelloWorldApp(@"C:\Users\brady\projects\ApiGen\test-output");
        
        return true;
    }
}