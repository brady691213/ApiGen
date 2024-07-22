using System.Diagnostics;
using System.Text;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;

namespace CodeGeneratorTests;

internal class DotnetOutput(string error, string standard)
{
    internal string Error { get; set; } = error;
    internal string Standard { get; set; } = standard;
}

public class CodeCompiler
{
    private const string DotNetCliPath = @"C:\Program Files\dotnet\dotnet.exe";

    internal static DotnetOutput BuildSolution(string solutionPath)
    {
        var start = new ProcessStartInfo(DotNetCliPath, ["build", solutionPath])
        {
            CreateNoWindow = true,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            WorkingDirectory = solutionPath
        };

        var standard = new StringBuilder();
        var error = new StringBuilder();

        var cliProc = new Process();
        cliProc.StartInfo = start;
        cliProc.OutputDataReceived += (sender, args) => standard.Append(args.Data);
        cliProc.ErrorDataReceived += (sender, args) => error.Append(args.Data);

        cliProc.Start();
        cliProc.BeginOutputReadLine();
        cliProc.BeginErrorReadLine();
        cliProc.WaitForExit();

        return new DotnetOutput(error.ToString(), standard.ToString());
    }

    public void BuildSolution2()
    {
        // Still a big work in progress. Later, maybe. 
        // Working off: https://stackoverflow.com/a/42816251/8741
        
        // string projectFileName = "C:\\Users...\\MySolution.sln"; // <--- Change here can be another
        // //      Visual Studio type.
        // //      Example: .vcxproj
        //
        // BasicLogger Logger = new BasicLogger();
        // var projectCollection = new ProjectCollection();
        // var buildParamters = new BuildParameters(projectCollection);
        // buildParamters.Loggers = new List<Microsoft.Build.Framework.ILogger>() { Logger };
        // var globalProperty = new Dictionary<String, String>();
        // globalProperty.Add("Configuration", "Debug"); //<--- change here
        // globalProperty.Add("Platform", "x64");//<--- change here
        // BuildManager.DefaultBuildManager.ResetCaches();
        // var buildRequest = new BuildRequestData(projectFileName, globalProperty, null, new String[] { "Build" }, null);
        // var buildResult = BuildManager.DefaultBuildManager.Build(buildParamters, buildRequest);
        // if (buildResult.OverallResult == BuildResultCode.Failure)
        // {
        //     // Catch result ...
        // }
        // //MessageBox.Show(Logger.GetLogString()); 
    }
}