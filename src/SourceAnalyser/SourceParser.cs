using System.Text.RegularExpressions;
using Reflection;
using SourceBuilder;

namespace SourceAnalyser;

public class SourceParser
{
    private Regex propRegex = new(@"(?'access'\w+) +(?'type'[\w\?\[\]<>, ]+) +(?'id'\w+) (?'getset'\{ get; set; \})(?'init' = [^;]+;)?");
    private PropertyBuilder _propertyBuilder = new PropertyBuilder();
    
    public List<PropertySourceDec> GetDecsFromAssembly()
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

    public List<PropertyModel> GetModelsFromAssembly()
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
            var decType = allTypes.Where(t => t.Name == tname);

            foreach (var type in decType)
            {
                var props = type.GetProperties();

                foreach (var prop in props)
                {
                    var m = _propertyBuilder.PropertyModelFromInfo(prop);
                    models.Add(m);
                }
            }
        }

        return models;
    }
}