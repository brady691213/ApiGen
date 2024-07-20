using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CodeGenerators;

/// <summary>
/// Diagnostic information for logging.
/// </summary>
public class Diags
{
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetCurrentMethod()
    {
        var st = new StackTrace();
        var sf = st.GetFrame(1);

        return sf.GetMethod().Name;
    }
}