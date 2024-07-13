namespace Reflection.Tests.Unit;

public class TypeAliasingTests
{
    private readonly Dictionary<string, Type> _aliasLookup;

    public TypeAliasingTests()
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
    }
}