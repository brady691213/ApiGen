namespace Reflection;

public class CSharpTypeInformation
{
    public static readonly Dictionary<string, Type> AliasKeyedLookup;
    public static readonly Dictionary<Type, string> TypeKeyedLookup;

    static CSharpTypeInformation()
    {
        AliasKeyedLookup = new Dictionary<string, Type>
        {
            { "bool", typeof(Boolean) },
            { "byte", typeof(Byte) },
            { "sbyte", typeof(SByte) },
            { "char", typeof(Char) },
            { "decimal", typeof(Decimal) },
            { "double", typeof(Double) },
            { "float", typeof(Single) },
            { "int", typeof(Int32) },
            { "uint", typeof(UInt32) },
            { "long", typeof(Int64) },
            { "ulong", typeof(UInt64) },
            { "object", typeof(Object) },
            { "short", typeof(Int16) },
            { "ushort", typeof(UInt16) },
            { "string", typeof(String) }
            
            // TASKT: Remove when I get runtime created types working to map array types.
            // { "bool[]",  typeof(Boolean[]) },
            // { "byte[]",  typeof(Byte[]) },
            // { "sbyte[]",  typeof(SByte[]) },
            // { "char[]",  typeof(Char[]) },
            // { "decimal[]",  typeof(Decimal[]) },
            // { "double[]",  typeof(Double[]) },
            // { "float[]",  typeof(Single[]) },
            // { "int[]",  typeof(Int32[]) },
            // { "uint[]",  typeof(UInt32[]) },
            // { "long[]",  typeof(Int64[]) },
            // { "ulong[]",  typeof(UInt64[]) },
            // { "object[]",  typeof(Object[]) },
            // { "short[]",  typeof(Int16[]) },
            // { "ushort[]",  typeof(UInt16[]) },
            // { "string[]",  typeof(String) }
        };

        TypeKeyedLookup = new Dictionary<Type, string>
        {
            { typeof(Guid), "Guid"},
            { typeof(Boolean), "bool" },
            { typeof(Byte), "byte" },
            { typeof(SByte), "sbyte" },
            { typeof(Char), "char" },
            { typeof(Decimal), "decimal" },
            { typeof(Double), "double" },
            { typeof(Single), "float" },
            { typeof(Int32), "int" },
            { typeof(UInt32), "uint" },
            { typeof(Int64), "long" },
            { typeof(UInt64), "ulong" },
            { typeof(Object), "object" },
            { typeof(Int16), "short" },
            { typeof(UInt16), "ushort" },
            { typeof(String), "string" }
            
            // TASKT: Remove when I get runtime created types working to map array types.
            // { typeof(Guid[]), "Guid[]"},
            // { typeof(Boolean[]), "bool[]" },
            // { typeof(Byte[]), "byte[]" },
            // { typeof(SByte[]), "sbyte[]" },
            // { typeof(Char[]), "char[]" },
            // { typeof(Decimal[]), "decimal[]" },
            // { typeof(Double[]), "double[]" },
            // { typeof(Single[]), "float[]" },
            // { typeof(Int32[]), "int[]" },
            // { typeof(UInt32[]), "uint[]" },
            // { typeof(Int64[]), "long[]" },
            // { typeof(UInt64[]), "ulong[]" },
            // { typeof(Object[]), "object[]" },
            // { typeof(Int16[]), "short[]" },
            // { typeof(UInt16[]), "ushort[]" },
            // { typeof(String[]), "string[]" }
        };
    }
    
    public static string? GetAliasForType(Type type)
    {
        Type? lookupType;
        if (type.Name.EndsWith("[]"))
            lookupType = Type.GetType($"System.{type.Name.Substring(0, type.Name.Length - 2)}");
        else
            lookupType = type;

        if (TypeKeyedLookup.ContainsKey(lookupType))
            return TypeKeyedLookup[lookupType];
        
        // var kvp = TypeLookup.SingleOrDefault(p => p.Key.Name == type.Name);
        // if (kvp.Value is { } alias)
        //     return alias;

        return type.Name;
    }

    public static Type? GetTypeForAlias(string alias)
    {
        return AliasKeyedLookup.GetValueOrDefault(alias);
    }
}