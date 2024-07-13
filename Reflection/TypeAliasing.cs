using System.Reflection;
using System.Text.RegularExpressions;

namespace Reflection;

public class TypeAliasing
{
    private static Dictionary<string, Type> _aliasLookup;
    private static Dictionary<Type, string> _typeLookup;

    static TypeAliasing()
    {
        _aliasLookup = new Dictionary<string, Type>
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
        };

        _typeLookup = new Dictionary<Type, string>
        {
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
        };
    }
    
    public static string GetTypeAlias(Type type)
    {
        if (_typeLookup.ContainsKey(type))
            return _typeLookup[type];
        // TASKT: Log not found
        return type.Name;
    }

    private string GetTypeName(string alias)
    {
        if (_aliasLookup.TryGetValue(alias, out Type? value))
            return value.Name;
        // TASKT: Log not found.
        return alias;
    }
}