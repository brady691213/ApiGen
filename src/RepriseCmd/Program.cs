using System.Reflection;
using CodeBuilder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Oakton;
using RepriseCmd.Commands;

// using IHost host = Host.CreateDefaultBuilder(args)
//     .ConfigureHostConfiguration(configHost =>
//     {
//         configHost.SetBasePath(Directory.GetCurrentDirectory());
//         configHost.AddJsonFile("appsettings.json", optional: true);
//     })
//     .ConfigureServices(services =>
//     {
//     })
//     .Build();
    
return CommandExecutor.ExecuteCommand<BuildTypeCommand>(args);


    
