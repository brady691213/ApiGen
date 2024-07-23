using CodeGenerators.Applications;
using Oakton;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using ILogger = Serilog.ILogger;

namespace RepriseCmd.Commands;

[Description("Build a console app that prints \"Hello World\"")]
public class BuildConsoleAppCommand: OaktonCommand<InputForBuildConsoleApp>
{
    public BuildConsoleAppCommand()
    {
        Usage("Build a console app in the given output directory").Arguments(x => x.OutputDirectory);
    }
    
    public override bool Execute(InputForBuildConsoleApp input)
    {
        Log.Logger.Information($"Building started for console application. Source files will be written to {input.OutputDirectory}.");

        var generator = new ConsoleAppGenerator();
        var result = generator.GenerateConsoleAppSolution(input.SolutionName, input.OutputDirectory, !input.DryRun);
        
        Log.Logger.Information($"Building completed for console application. Source written to {input.OutputDirectory}.");
        
        return result.IsOk;
    }
}