using System.Diagnostics;

namespace Reflection;

/// <summary>
/// Provides mapping between C# types and their keyword aliases.
/// E.g. the alias for <see cref="Boolean"/> is <see cref="bool"/>, that for <see cref="Int32"/>
/// and <see cref="Int64"/> is <see cref="int"/>, etc.
/// </summary>
public static class CSharpTypeMaps
{
    /// <summary>
    /// Dictionary that maps C# types to keyword aliases used for these types.
    /// </summary>
    public static readonly Dictionary<Type, string> TypeKeyedDictionary;

    static CSharpTypeMaps()
    {
        TypeKeyedDictionary = new Dictionary<Type, string>
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
    
    /// <summary>
    /// Looks up the C# keyword alias for a given <see cref="Type"/>. 
    /// </summary>
    public static string GetAliasForType(Type type)
    {
        var lookupType = type.Name.EndsWith("[]") ? Type.GetType($"System.{type.Name[..^2]}") : type;

        Debug.Assert(lookupType != null, nameof(lookupType) + " != null");
        return TypeKeyedDictionary.TryGetValue(lookupType, out var value) ? value : type.Name;
    }
}