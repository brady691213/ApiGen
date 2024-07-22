using System.Diagnostics;
using System.Text;

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
            RedirectStandardOutput = true
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

        return new DotnetOutput(standard.ToString(), error.ToString());
    }
}