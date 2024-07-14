using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Oakton;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureHostConfiguration(configHost =>
    {
        configHost.SetBasePath(Directory.GetCurrentDirectory());
        configHost.AddJsonFile("appsettings.json", optional: true);
    })
    .ConfigureServices(services =>
    {
    })
    .Build();
    
    var logger = host.Services.GetRequiredService<ILogger<Program>>();
    // TASKT: How to get real name of this console app.
    logger.LogInformation("{cliName} started", "RepriseCmd");
    
    var executor = CommandExecutor.For(_ =>
    {
        _.RegisterCommands(typeof(Program).GetTypeInfo().Assembly);
    });

    return executor.Execute(args);
    
