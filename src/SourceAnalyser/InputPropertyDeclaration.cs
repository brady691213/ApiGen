namespace SourceAnalyser;

/// <summary>
/// An input property declaration, i.e. property info as read from source vs. as generated for output.
/// </summary>
/// <param name="declaringFile">Name of the file the property's declaring type is defined in.</param>
/// <param name="access">Basic, single-word access modifier, e.g. `public', `private` etc.</param>
/// <param name="isVirtual">Is this propert virtual, i.e. the `virtual` keyword follows <paramref name="access"/>.</param>
/// <param name="propType">The full <see cref="Type"/> string for this property. Includes generic params, e.g. `string`, `ICollection&lt;int&gt;` etc.</param>
/// <param name="name">The name of this property.</param>
/// <param name="getSet">The get and set accessors for this property. Currently only allows for auto-props e.g. { get; set; }</param>
/// <param name="initializer">Any lambda initializer for this property.</param>
public class InputPropertyDeclaration(string declaringFile, string access, string isVirtual, string propType, string name, string getSet, string initializer)
{
    public string DeclaringFile { get; set; } = declaringFile;

    public string Access { get; set; } = access;

    public string IsVirtual { get; set; } = isVirtual;
    
    public string PropType { get; set; } = propType;

    public string Name { get; set; } = name;
    
    public string GetSet { get; set; } = getSet;

    public string Initializer { get; set; } = initializer;
}