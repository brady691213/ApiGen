using System.Reflection;
using Oakton;
using RepriseCmd;
using RepriseCmd.Commands;

var host = RepriseHostBuilder.BuildHost();
var executor = CommandExecutor.For(_ =>
{
    _.RegisterCommands(typeof(Program).GetTypeInfo().Assembly);
    _.DefaultCommand = typeof(BuildTypeCommand);
}, new RepriseCommandCreator(host.Services));

//return await host.RunOaktonCommands(args);
//return CommandExecutor.ExecuteCommand<BuildTypeCommand>(args);
return executor.Execute(args);


    
