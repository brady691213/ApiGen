using CTSCore.Models;
using Shouldly;

namespace Reflection.Tests;

public class DbContextReflectorTests
{
    private const string dbContextAsmPath = @"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll";

    private DbContextReflector _reflector = new DbContextReflector();

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
        // var knownEntityTypes = File.ReadAllLines("CtsCoreDbSetList");
        // var dbct = _reflector.GetDbContextType("Reflection/library/CTSCore.dll", "CTSDBContext");
        //
        // var actualTypes = _reflector.
    }
}