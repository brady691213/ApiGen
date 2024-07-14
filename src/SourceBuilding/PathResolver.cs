namespace SourceBuilding;

/// <summary>
/// Tool to resolve and determine paths for API generation templates.
/// </summary>
public class PathResolver(string apiSolutionFolder)
{
    // The root folder for all files required by the API to build and be tested.
    public string ApiSolutionFolder { get; set; } = apiSolutionFolder;

    public string GetDtoOutputFolder()
    {
        return $"{apiSolutionFolder}/src/";
    }
}