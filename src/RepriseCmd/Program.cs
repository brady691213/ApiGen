using System.Reflection;
using CodeBuilder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Oakton;
using RepriseCmd;
using RepriseCmd.Commands;

var executor = CommandExecutor.For(_ =>
{
    _.RegisterCommands(typeof(Program).GetTypeInfo().Assembly);
        
    // TASKT: Arrive at a suitable default command.
    _.DefaultCommand = typeof(BuildTypeCommand);
    
    _.ConfigureRun = run =>
    {
        // you can use this to alter the values of the inputs or actual command objects just before the command is executed
    };
}, new RepriseCommandCreator(container));

//return await HostProvider.AppStartup().RunOaktonCommands(args);
    
return CommandExecutor.ExecuteCommand<BuildTypeCommand>(args);


    
