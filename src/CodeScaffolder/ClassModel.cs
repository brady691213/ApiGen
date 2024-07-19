namespace CodeScaffolder;

/// <summary>
/// A facade that simplifies defining classes for building code with the <see cref="System.CodeDom"/> namespace.  
/// </summary>
public class ClassModel(string className)
{
    /// <summary>
    /// Name for a class.
    /// </summary>
    public string ClassName { get; set; } = className;

    /// <summary>
    /// Namespace that a class belongs to.
    /// </summary>
    public string? NamespaceName { get; set; } = null;
    
    /// <summary>
    /// Namespaces required by a class. 
    /// </summary>
    /// <remarks>Defaults to just <c>System</c>.</remarks>
    /// <remarks>
    /// Always use at least <c>System</c> because we expect all imports to be explicit,
    /// because implicit usings depend on how this code is compiled.
    /// </remarks>
    public List<string> Imports { get; set; } = ["System"];
}