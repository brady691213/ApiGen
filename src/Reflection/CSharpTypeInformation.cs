using System.Diagnostics;

namespace Reflection;

public class CSharpTypeInformation
{
    public static readonly Dictionary<Type, string> TypeKeyedLookup;

    static CSharpTypeInformation()
    {
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
        };
    }
    
    public static string GetAliasForType(Type type)
    {
        var lookupType = type.Name.EndsWith("[]") ? Type.GetType($"System.{type.Name[..^2]}") : type;

        Debug.Assert(lookupType != null, nameof(lookupType) + " != null");
        return TypeKeyedLookup.TryGetValue(lookupType, out var value) ? value : type.Name;
    }
}