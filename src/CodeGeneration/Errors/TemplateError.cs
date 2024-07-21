namespace CodeGenerators.Errors;

/// <summary>
/// Error for template loading and parsing.
/// </summary>
public class TemplateError(string message, List<string>? parseMessages) : Error
{
    public override string Message { get; } = message;

    public List<string> ParseMessages { get; set; } = parseMessages ?? [];
}