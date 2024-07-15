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
    // Automatically discover and register
    // all OaktonCommand's in this assembly
    _.RegisterCommands(typeof(Program).GetTypeInfo().Assembly);
        
    // You can also add commands explicitly from
    // any assembly
    _.RegisterCommand<HelloCommand>();
        
    // In the absence of a recognized command name,
    // this is the default command to try to 
    // fit to the arguments provided
    _.DefaultCommand = typeof(ColorCommand);

        
    _.ConfigureRun = run =>
    {
        // you can use this to alter the values
        // of the inputs or actual command objects
        // just before the command is executed
    };
        
    // This is strictly for the as yet undocumented
    // feature in stdocs to generate and embed usage information
    // about console tools built with Oakton into
    // stdocs generated documentation websites
    _.SetAppName("MyApp");
}, new RepriseCommandCreator(container));

//return await HostProvider.AppStartup().RunOaktonCommands(args);
    
return CommandExecutor.ExecuteCommand<BuildTypeCommand>(args);


    
