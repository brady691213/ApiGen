using CTSCore.Models;
using Shouldly;

namespace Reflection.Tests.Integration;

public class DbContextReflectorTests
{
    private const string dbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";
    private const string dbContextName = "CTSDBContext";

    private DbContextReflector _reflector = new();
    
    [Fact]
    public void GetDbSetEntitiesReturnsAllDbSetsInList()
    {
        var expectedNames = File.ReadAllLines("CtsCoreDbSetTypeList");

        var actualTypes = _reflector.GetDbSetTypesFromAssembly(dbContextAsmPath, dbContextName);
        
        var actualNames = actualTypes.Select(t => t.Name);
        actualNames.ShouldBe(expectedNames, ignoreOrder:true);
    }
}