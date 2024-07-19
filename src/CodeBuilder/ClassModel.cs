namespace CodeBuilder;

/// <summary>
/// A facade that simplifies defining classes for building code with the <see cref="System.CodeDom"/> namespace.  
/// </summary>
public class ClassModel
{
    public string ClassName { get; set; }
    
    public string NamespaceName { get; set; }
}