﻿using System.Reflection;

namespace CodeGenerators.Models;

public class ProjectModel(string projectName, string? templateName = null, List<CodeArtifactModel>? codeFileModels = null)
{
    // Temp until I sort out why packahe refs in standard template aren't rendering properly.
    public string TemplateName { get; set; } = templateName ?? "ProjectFile.csproj";
    
    public Guid ProjectId { get; } = Guid.NewGuid();
    
    public string ProjectName { get; set; } = projectName;

    public List<PackageReferenceModel> PackageReferences { get; set; } = new();

    public List<CodeArtifactModel> CodeModels { get; set; } = codeFileModels ?? [];

    // Just a default for now.
    public string ProjectFrameworkMoniker { get; set; } = "net9.0";
    
    // Just a default for now.
    public string RepriseVersion { get; } = GetExecutingVersion();

    private static string GetExecutingVersion()
    {
        return Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "0.0.0";
    }
    
    public List<string> FilesCreated { get; set; } = [];
}