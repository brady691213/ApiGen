using System.Text.RegularExpressions;
using SourceReader;

namespace SourceParsing;

public partial class SourceParser
{
    [GeneratedRegex(@"(?'access'\w+)\s+(?'class_type'(?:class)|(?:record))\s+(?'class_name'\w+)")]
    private static partial Regex ClassRegex();
    
    [GeneratedRegex(@"(?'access'\w+)\s+(?:virtual\s+)?(?'type'\w+(\[\])?\??(?:<[^>]+>)?)\s+(?'name'\w+)\s+(?'getset'\{ get; set; \})(?'init' = [^;]+;)?")]
    private static partial Regex PropertyRegex();   
    
    private readonly Regex _classRegex = ClassRegex();
    private readonly Regex _propRegex = PropertyRegex();

    public List<InputPropertyDeclaration> GetDecsFromAssembly()
    {
        var files = Directory.GetFiles(@"C:\Users\brady\projects\ApiGen\CTSCoreDecomp", "*.cs",
            SearchOption.AllDirectories);
        var decs = new List<InputPropertyDeclaration>();

        foreach (var filePath in files)
        {
            var source = File.ReadAllText(filePath);
            
            var classMatches = _classRegex.Matches(source);
            if (classMatches.Count > 1)
            {
                throw new InvalidOperationException("More than one class in file");
            }
            
            var propertyMatches = _propRegex.Matches(source);
            foreach (Match match in propertyMatches)
            {
                decs.Add(new InputPropertyDeclaration(
                    match.Value,
                    Path.GetFileName(filePath),
                    classMatches[0].Groups["class_name"].Value,
                    match.Groups["access"].Value,
                    match.Groups["isVirtual"].Value,
                    match.Groups["type"].Value,
                    match.Groups["name"].Value,
                    match.Groups["getset"].Value,
                    match.Groups["init"].Value
                ));
            }
        }

        return decs;
    }
}