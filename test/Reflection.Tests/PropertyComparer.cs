using System.Reflection;

namespace Reflection.Tests;

public class PropertyComparer: IEqualityComparer<PropertyInfo>
{
    public bool Equals(PropertyInfo x, PropertyInfo y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.CustomAttributes.Equals(y.CustomAttributes) && Equals(x.DeclaringType, y.DeclaringType) && x.IsCollectible == y.IsCollectible && x.MetadataToken == y.MetadataToken && x.Module.Equals(y.Module) && x.Name == y.Name && Equals(x.ReflectedType, y.ReflectedType) && x.Attributes == y.Attributes && x.CanRead == y.CanRead && x.CanWrite == y.CanWrite && Equals(x.GetMethod, y.GetMethod) && x.IsSpecialName == y.IsSpecialName && x.MemberType == y.MemberType && x.PropertyType.Equals(y.PropertyType) && Equals(x.SetMethod, y.SetMethod);
    }

    public int GetHashCode(PropertyInfo obj)
    {
        var hashCode = new HashCode();
        hashCode.Add(obj.CustomAttributes);
        hashCode.Add(obj.DeclaringType);
        hashCode.Add(obj.IsCollectible);
        hashCode.Add(obj.MetadataToken);
        hashCode.Add(obj.Module);
        hashCode.Add(obj.Name);
        hashCode.Add(obj.ReflectedType);
        hashCode.Add((int)obj.Attributes);
        hashCode.Add(obj.CanRead);
        hashCode.Add(obj.CanWrite);
        hashCode.Add(obj.GetMethod);
        hashCode.Add(obj.IsSpecialName);
        hashCode.Add((int)obj.MemberType);
        hashCode.Add(obj.PropertyType);
        hashCode.Add(obj.SetMethod);
        return hashCode.ToHashCode();
    }
}