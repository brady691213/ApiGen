namespace CodeScaffolderIntegrationTests;

public class FileSystemTools
{
    public static void EnsureDirectoryExists(string path)
    {
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    }
    
    public static void EnsureEmptyOutputDir()
    {
        Directory.Delete(TestConstants.OutputDirectory, true);
        Directory.CreateDirectory(TestConstants.OutputDirectory);
    }
    
    public static string GetSolutionDirectory(string solutionName)
    {
        return Path.Combine(TestConstants.OutputDirectory, solutionName);
    }
}