using System.Reflection;
using CodeBuilder;
using Oakton;
using RepriseCmd;
using RepriseCmd.Commands;

var appBuilder = new ConsoleAppBuilder();

appBuilder.BuildHelloWorldApp(@"C:\Users\brady\projects\ApiGen\test-output\");

// var host = RepriseHostBuilder.BuildHost();
// var executor = CommandExecutor.For(_ =>
// {
//     _.RegisterCommands(typeof(Program).GetTypeInfo().Assembly);
//     _.DefaultCommand = typeof(BuildAppCommand);
// }, new RepriseCommandCreator(host.Services));
//
// //return await host.RunOaktonCommands(args);
// return CommandExecutor.ExecuteCommand<BuildAppCommand>(args);
// //return executor.Execute(args);


    
