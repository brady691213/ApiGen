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
    logger.LogInformation("Host,logging, Di, shebang started up");
    
    var executor = CommandExecutor.For(_ =>
    {
        _.RegisterCommands(typeof(Program).GetTypeInfo().Assembly);
    });

    return executor.Execute(args);