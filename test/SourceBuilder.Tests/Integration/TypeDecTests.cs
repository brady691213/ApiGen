using System.Reflection;
using Reflection;
using Shouldly;
using SourceAnalyser;
using Xunit;

namespace SourceBuilder.Tests.Integration;

public class TypeDecTests
{
    private const string DbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";
    private const string DbContextName = "CTSDBContext";

    [Theory]
    [ClassData(typeof(MassTypeDecTheoryData))]

    public void GetAllPropsGivesBigList()
    {
        
        //props.ShouldNotBeEmpty();
    }
}

public class MassTypeDecTheoryData : TheoryData<string, string>
{
    private const string DbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";

    public MassTypeDecTheoryData()
    {
        var parser = new SourceParser();
        var allSourceDecs = parser.GetDecsFromAssembly();

        var reflector = new Reflector();
        var ctx = reflector.GetDbContextType(DbContextAsmPath, "CTSDBContext");

        var builder = new PropertyBuilder();
        var entities = reflector.GetEntityTypes(ctx);
        foreach (var entityType in entities)
        {
            var generatedModels = reflector.GetEntityProperties(entityType)
                .Select(p => builder.PropertyModelFromInfo(p))
                .ToList();
            var generatedDecs = generatedModels
                .Select(m => $"public {m.TypeDeclaration}")
                .ToList();
            
            var expectedDec = allSourceDecs
                .Select(d => d.DeclaringFile == entityType.Name && d.MatchedDec)
        }
    }
}