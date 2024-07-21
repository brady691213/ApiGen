using System.Diagnostics;

namespace CodeGenerators.Errors;

/// <summary>
/// Helper functions for working with error objects from the <see cref="Rascal"/> result type library.
/// </summary>
public class RascalErrors
{
    public static string ErrorMessage<T>(Result<T> result)
    {
        var hasErr = result.TryGetError(out var error);
        Debug.Assert(hasErr, nameof(hasErr) + " true");
        Debug.Assert(error != null, nameof(error) + " != null");
        return error.Message;
    }
}