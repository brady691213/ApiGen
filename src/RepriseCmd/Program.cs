using Oakton;
using RepriseCmd.Commands;
using Serilog;
using Serilog.Events;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Verbose)
    .CreateLogger();


return CommandExecutor.ExecuteCommand<BuildConsoleAppCommand>(args);



    
