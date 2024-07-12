using System.Reflection;
using System.Text.RegularExpressions;

namespace Reflection;

public class PropertyReflector
{
    private Regex nullableTypeRx = new Regex("Nullable<(?'type'\\w+)>");
    private Dictionary<string, Type> _typeAliasLookup;

    public PropertyReflector()
    {
        _typeAliasLookup = new Dictionary<string, Type>
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

    public PropertyModel GetPropertyModel(PropertyInfo info, bool skipAliases = false)
    {
        // TASKT: Map Nullable<T> to T?

        var model = new PropertyModel(info.PropertyType.Name, info.Name);
        model.TypeDeclaration = BuildTypeDeclaration(info.PropertyType, skipAliases);
        if (IsMarkedAsNullable(info))
        {
            model.TypeDeclaration += "?";
        }

        return model;
    }

    private string BuildTypeDeclaration(Type propType, bool skipAlias = false)
    {
        if (!propType.IsGenericType)
        {
            return skipAlias ? propType.Name : GetTypeAlias(propType);
        }

        var names = new List<string>();
        foreach (var genericTypeArgument in propType.GenericTypeArguments)
        {
            names.Add(BuildTypeDeclaration(genericTypeArgument, skipAlias));
        }

        return $"{propType.Name.Split('`')[0]}<{string.Join(",", names)}>";
    }
    
    bool IsMarkedAsNullable(PropertyInfo p)
    {
        // https://stackoverflow.com/a/72586919/8741
        // Comment adds to check ReadState not WriteState, for get only. Maybe check for each method.
        return new NullabilityInfoContext().Create(p).WriteState is NullabilityState.Nullable;
    }

    private string GetTypeAlias(Type type)
    {
        var alias = _typeAliasLookup.SingleOrDefault(p => p.Value == type).Key;
        return alias ?? type.Name;
    }

    private string? GetFullTypeName(string alias)
    {
        _typeAliasLookup.TryGetValue(alias, out Type? type);
        return type?.Name;
    }

    private string GetAliasForNullable(string nullableTypeName)
    {
        var groups = nullableTypeRx.Match(nullableTypeName).Groups;
        return groups["0"].Captures[0].Value;

    }
}