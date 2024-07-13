using System.Text.RegularExpressions;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;

namespace Decompiler;

public class SourceParser
{
    private Regex propRegex = new Regex(@"public (?:virtual\s+)?\w+(?:<[\w<>]+>)?\??\s+\w+\??");
    
    public List<PropertySourceDec> GetEntityProperties()
    {
        var files = Directory.GetFiles(@"C:\Users\brady\projects\ApiGen\CTSCoreDecomp", "*.cs", SearchOption.AllDirectories);
        var decs = new List<PropertySourceDec>();
        
        foreach (var path in files)
        {
            var source = File.ReadAllText(path);
            var matches = propRegex.Matches(source);

            foreach (Match match in matches)
            {
                decs.Add(new PropertySourceDec(path, match.Value));
            }
        }

        return decs;
    }
}