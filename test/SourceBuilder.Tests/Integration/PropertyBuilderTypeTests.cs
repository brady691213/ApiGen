using System.Reflection;
using Reflection;
using Shouldly;
using Xunit;

namespace SourceBuilder.Tests.Integration;

public class PropertyBuilderTypeTests
{
    private const string DbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";
    private const string DbContextName = "CTSDBContext";
    private PropertyBuilder _propertyBuilder = new();

    [Fact]
    public void GetAllPropsGivesBigList()
    {
        var props = GetUniquePropTypeStrings();
        
        props.ShouldNotBeEmpty();
    }
    
    public List<PropertyInfo> GetUniquePropTypeStrings()
    {
        var propinfos = new List<PropertyInfo>();
        var reflector = new Reflector();

        var entities = reflector.GetEntityTypesFromAssembly(DbContextAsmPath, DbContextName);

        foreach (var entity in entities)
        {
            propinfos.AddRange(entity.GetProperties());
        }

        // return propinfos.Select(i =>
        // {
        //     var desc = i.PropertyType.FullName;
        // });
        return propinfos.ToList();
    }
}