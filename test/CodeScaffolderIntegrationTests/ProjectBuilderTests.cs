﻿using CodeGenerators;
using Shouldly;
using Xunit;

namespace CodeScaffolderIntegrationTests;

public class ProjectBuilderTests
{
    private const string SolutionName = "SolutionForTests";
    private const string ProjectName = "ProjectForTests";
    
    
    [Fact]
    public void CreateProjectThrowsOnDirExists()
    {
        var projDir = GetProjectDirectory(ProjectName);
        FileSystemTools.EnsureDirectoryExists(projDir);
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectGenerator();

        Should.Throw<InvalidOperationException>(() =>
        {
            builder.GenerateProject(model, TestConstants.OutputDirectory, false);
        });
    }

    [Fact]
    public void CreateProjectCreatesProjectDir()
    {
        FileSystemTools.EnsureEmptyOutputDir();
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectGenerator();
        
        builder.GenerateProject(model, TestConstants.OutputDirectory, false);

        var projDir = GetProjectDirectory(ProjectName);
        var exists = Directory.Exists(projDir);
        exists.ShouldBeTrue();
    }

    [Fact]
    public void CreateProjectCreatesCsproj()
    {
        FileSystemTools.EnsureEmptyOutputDir();
        var model = new ProjectModel(ProjectName);
        var builder = new ProjectGenerator();
        
        builder.GenerateProject(model, TestConstants.OutputDirectory, false);

        var filePath = Path.Combine(GetProjectDirectory(ProjectName), $"{ProjectName}.csproj");
        var exists = File.Exists(filePath);
    }
    
    private string GetProjectDirectory(string projectName)
    {
        return Path.Combine(TestConstants.OutputDirectory, projectName);
    }
}