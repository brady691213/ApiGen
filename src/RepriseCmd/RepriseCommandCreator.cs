using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Oakton;

namespace RepriseCmd;

public class RepriseCommandCreator : ICommandCreator
{
    private readonly IServiceProvider _services;

    public RepriseCommandCreator(IServiceProvider services)
    {
        _services = services;
    }

    public IOaktonCommand CreateCommand(Type commandType)
    {
        return (IOaktonCommand)_services.GetRequiredService(commandType);
    }

    public object CreateModel(Type modelType)
    {
        return _services.GetService(modelType);
    }
}