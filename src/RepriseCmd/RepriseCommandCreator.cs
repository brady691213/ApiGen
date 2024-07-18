using Microsoft.Extensions.DependencyInjection;
using Oakton;
using RepriseCmd.Commands;
using Serilog;

namespace RepriseCmd;

/// <summary>
/// Implementation as per Oakton docs with the goal of injecting loggers into commands when created but simply not working.
/// </summary>
public class RepriseCommandCreator : ICommandCreator
{
    private readonly IServiceProvider _services;

    public RepriseCommandCreator(IServiceProvider services)
    {
        _services = services;
    }

    public IOaktonCommand CreateCommand(Type commandType)
    {
        // var cmd = (IOaktonCommand)_services.GetRequiredService(commandType);
        var logger = Log.ForContext<BuildAppCommand>();
        // cmd.
        return (IOaktonCommand)_services.GetRequiredService(commandType);
    }

    public object CreateModel(Type modelType)
    {
        return _services.GetService(modelType);
    }
}