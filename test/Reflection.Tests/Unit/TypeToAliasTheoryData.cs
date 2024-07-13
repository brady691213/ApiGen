namespace Reflection.Tests.Unit;

public class TypeToAliasTheoryData: TheoryData<Type, string>
{
    public TypeToAliasTheoryData()
    {
        foreach (var kvp in TypeAliasing.TypeLookup)
        {
            Add(kvp.Key, kvp.Value);
        }
    }
}