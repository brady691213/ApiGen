using Oakton;
using RepriseCmd.Commands;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console() // + file or centralized logging
    .CreateLogger();


return CommandExecutor.ExecuteCommand<BuildWebApiCommand>(args);



    
