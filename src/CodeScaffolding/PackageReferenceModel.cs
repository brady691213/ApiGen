namespace CodeScaffolding;

public record PackageReferenceModel(string Name, string Version)
{
    public string Name { get; set; } = Name;

    public string Version { get; set; } = Version;
}