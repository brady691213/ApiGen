using System.Reflection;
using Reflection;

namespace EntityDecompiler;

public class ModelSourceProvider(DbContextReflector reflector)
{
    private DbContextReflector _reflector = reflector;

    public string BuildEntityPropertyDeclarations(Type entityType)
    {
        var props = _reflector;
    }
}