using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RepriseCmd.Commands;
using Serilog;

namespace RepriseCmd;

public class RepriseHostBuilder
{
    internal static IHost BuildHost()
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();
        
        // Specifying the configuration for serilog
        Log.Logger = new LoggerConfiguration() // initiate the logger configuration
            .ReadFrom.Configuration(builder.Build()) // connect serilog to our configuration folder
            .Enrich.FromLogContext() //Adds more information to our logs from built in Serilog 
            .WriteTo.Console() // decide where the logs are going to be shown
            .CreateLogger(); //initialise the logger

        Log.Logger.Information("Application Starting");

        var host = Host.CreateDefaultBuilder() // Initialising the Host 
            .ConfigureServices((context, services) => { // Adding the DI container for configuration
                services.AddTransient<InputForBuildType>();
                services.AddTransient<BuildAppCommand>();
            })
            .UseSerilog() // Add Serilog
            .Build(); // Build the Host

        return host;
    }
}