namespace Reflection;

public class GenericsReflector
{
    public static List<Type> GetGenericArguments(Type genericType)
    {
        // TASKT: Replace exceptions/checks with result pattern.
        if (genericType == null)
        {
            throw new ArgumentNullException(nameof(genericType));
        }

        if (!genericType.IsGenericType)
        {
            throw new ArgumentException("The provided type is not a generic type.", nameof(genericType));
        }

        return genericType.GetGenericArguments().ToList();
    }
}