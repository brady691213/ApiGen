using System.ComponentModel;
using Oakton;

namespace RepriseCmd;

public class RepriseCommandCreator : ICommandCreator
{
    private readonly IContainer _container;

    public RepriseCommandCreator(IContainer container)
    {
        _container = container;
    }

    public IOaktonCommand CreateCommand(Type commandType)
    {
        return (IOaktonCommand)_container.GetInstance(commandType);
    }

    public object CreateModel(Type modelType)
    {
        return _container.GetInstance(modelType);
    }
}