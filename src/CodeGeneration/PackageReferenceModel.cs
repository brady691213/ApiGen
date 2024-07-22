using System.Reflection;
using Semver;

namespace CodeGenerators;

/// <summary>
/// Models Nuget package references as required for building a project (.csproj) file.
/// </summary>
/// <param name="Name">Name of a Nuget package</param>
/// <param name="Version">Version of the Nuget package.</param>
public record PackageReferenceModel(string Name, string Version)
{
    public string Name { get; set; } = Name;

    public string Version { get; set; } = Version;
}