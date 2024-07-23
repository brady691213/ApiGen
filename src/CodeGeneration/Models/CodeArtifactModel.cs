﻿using System.CodeDom;
using System.Reflection;
using CodeGenerators.Models;

namespace CodeGenerators;

/// <summary>
/// Represents a source code file to be created as part of a project.
/// </summary>
/// <param name="fileName">Name of the code file.</param>
/// <param name="content">Source code content of the file.</param>
public class CodeArtifactModel(string className, string fileName, string? codeNamespace = null)
{
    /// <summary>
    /// Name for a class.
    /// </summary>
    public string ClassName { get; set; } = className;

    /// <summary>
    /// Namespace that a class belongs to.
    /// </summary>
    public string? Namespace { get; set; } = codeNamespace;
    
    /// <summary>
    /// Namespaces required by a class. 
    /// </summary>
    /// <remarks>Defaults to just <c>System</c>.</remarks>
    /// <remarks>
    /// Always use at least <c>System</c> because we expect all imports to be explicit,
    /// because implicit usings depend on how this code is compiled.
    /// </remarks>
    public List<string> Imports { get; set; } = ["System"];
    
    public CodeTypeMemberCollection Members { get; set; } = [];
    
    
    private TypeAttributes classAttributes = TypeAttributes.Public;
    
    public string FileName { get; set; } = fileName;

    public string? Content { get; set; } 
}