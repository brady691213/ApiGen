using CodeGenerators.Applications;
using Oakton;
using Serilog;
using ILogger = Serilog.ILogger;

namespace RepriseCmd.Commands;

[Description("Build a FastEndpoints based web API")]
public class BuildWebApiCommand: OaktonCommand<InputForBuildWebApi>
{
    private readonly ILogger _logger = Log.ForContext<BuildWebApiCommand>();
    
    public BuildWebApiCommand()
    {
        Usage("Build a web API in the given output directory").Arguments(x => x.OutputDirectory);
    }
    
    public override bool Execute(InputForBuildWebApi input)
    {
        _logger.Information($"Building started for web API. Source files will be written to {input.OutputDirectory}.");

        var builder = new FastEndpointAppGenerator();
        // TASKT: Get a param for name.
        var result = builder.GenerateApiSolution("FastEndpoints", input.OutputDirectory, input.WriteFiles);
        
        _logger.Information($"Building completed for web API. Source written to {input.OutputDirectory}.");

        return result.IsOk;
    }
}