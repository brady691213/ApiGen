using System.Net;
using System.Text.RegularExpressions;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using Reflection;
using SourceBuilder;

namespace Decompiler;

public class SourceParser
{
    private Regex propRegex = new Regex(@"public (?:virtual\s+)?\w+(?:<[\w<>]+>)?\??\s+\w+\??");
    private PropertyBuilder _propertyBuilder = new PropertyBuilder();
    
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

    public List<PropertyModel> GetUniqueProps()
    {
        var loader = new AssemblyLoader();
        
        var propLines = File.ReadAllLines("properties.txt");
        var asm = loader.LoadAssembly(@"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll");
        var allTypes = asm.GetTypes();

        var models = new List<PropertyModel>();

        foreach (var line in propLines.Where(l => !l.Contains("class ")))
        {
            var parts = line.Replace("{ get; set; }", "").Split(new char[] {' ', '\t', ':'}, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            var tname = parts[0];
            var decType = allTypes.SingleOrDefault(t => t.Name == tname);

            var props = decType?.GetProperties();

            foreach (var prop in props)
            {
                var m = _propertyBuilder.PropertyModelFromInfo(prop);
                models.Add(m);
            }
        }

        return models;
    }
}