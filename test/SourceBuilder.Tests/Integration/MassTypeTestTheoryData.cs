using System.Reflection;
using Reflection;
using SourceReader;
using Xunit;

namespace SourceBuilder.Tests.Integration;

public class MassTypeTestTheoryData : TheoryData<PropertyInfo, InputPropertyDeclaration>
{
    private const string DbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";

    public MassTypeTestTheoryData()
    {
        // Read all prop declarations from the decompiled source for the CTSCore assembly.
        var parser = new SourceParser();
        var allInputDecs = parser.GetDecsFromAssembly();

        // Now get all entity types from the original, compiled CTSCore assembly.
        var reflector = new Reflector();
        var context = reflector.GetDbContextType(DbContextAsmPath, "CTSDBContext");

        // Then get all property infos for each entity type.
        var allProps = new List<PropertyInfo>();
        var entities = reflector.GetEntityTypes(context);
        foreach (var entityType in entities)
        {
            allProps.AddRange(reflector.GetEntityProperties(entityType));
        }
        
        // Each PropertyInfo should result in a PropertyModel having the same type string as that property parsed from the source.
        foreach (var info in allProps)
        {
            var dec = allInputDecs
                .SingleOrDefault(d => d.DeclaringFile == info.DeclaringType?.Name
                                      && d.Name == info.Name);
            Add(info, dec!);
        }
    }
}