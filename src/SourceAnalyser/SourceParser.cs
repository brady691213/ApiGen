using System.Text.RegularExpressions;
using Reflection;
using SourceBuilder;

namespace SourceAnalyser;

public class SourceParser
{
    private Regex propRegex =
        new(@"(?'access'\w+) (?:virtual\s+)?(?'type'\w+(?:<[^>]+>)?) (?'id'\w+) \{ get; set; \}(?'init' = [^;]+;)?");

    private PropertyBuilder _propertyBuilder = new PropertyBuilder();

    public List<InputPropertyDeclaration> GetDecsFromAssembly()
    {
        var files = Directory.GetFiles(@"C:\Users\brady\projects\ApiGen\CTSCoreDecomp", "*.cs",
            SearchOption.AllDirectories);
        var decs = new List<InputPropertyDeclaration>();

        foreach (var filePath in files)
        {
            var source = File.ReadAllText(filePath);
            var matches = propRegex.Matches(source);

            foreach (Match match in matches)
            {
                decs.Add(new InputPropertyDeclaration(
                    Path.GetFileName(filePath),
                    match.Groups["access"].Value,
                    match.Groups["isVirtual"].Value,
                    match.Groups["type"].Value,
                    match.Groups["name"].Value,
                    match.Groups["getset"].Value,
                    match.Groups["isVirtual"].Value
                ));
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
            var parts = line.Replace("{ get; set; }", "").Split(new char[] { ' ', '\t', ':' },
                StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
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