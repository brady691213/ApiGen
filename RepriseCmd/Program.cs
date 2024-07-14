using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

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
    
// dotnet add package Serilog --version 2.12.0
// dotnet add package Serilog.Settings.Configuration --version 7.0.0
// dotnet add package Serilog.Extensions.Hosting --version 7.0.0
// dotnet add package Serilog.Sinks.Console --version 4.1.0