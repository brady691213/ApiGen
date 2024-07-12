using CTSCore.Models;
using Shouldly;

namespace Reflection.Tests.Integration;

public class DbContextReflectorTests
{
    private const string dbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";

    private DbContextReflector _reflector = new();

    [Fact]
    public void GetDbContextTypeReturnsCorrectType()
    {
        var expected = typeof(CTSDBContext);
        var actual = _reflector.GetDbContextType(dbContextAsmPath, expected.Name);
        actual.ShouldBe(expected);
    }
    
    [Fact]
    public void GetDbSetEntitiesReturnsAllDbSetsInList()
    {
        var expectedNames = File.ReadAllLines("CtsCoreDbSetTypeList");
        var dbct = _reflector.GetDbContextType(dbContextAsmPath, "CTSDBContext");
        
        var actualTypes = _reflector.GetDbSetTypes(dbct);
        
        var actualNames = actualTypes.Select(t => t.Name);
        actualNames.ShouldBe(expectedNames, ignoreOrder:true);
    }
}