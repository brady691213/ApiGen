namespace Reflection.Tests.Unit;

public class AliasToTypeTheoryData: TheoryData<string, Type>
{
    public AliasToTypeTheoryData()
    {
        foreach (var kvp in TypeAliasing.AliasLookup)
        {
            Add(kvp.Key, kvp.Value);
        }
    }
}