using Vogen;

namespace CodeGenerators.Next;

/// <summary>
/// Indicates whether a DTO is used for a Request or a Response.
/// </summary>
[ValueObject<string>]
// ReSharper disable once StructCanBeMadeReadOnly
public partial struct DtoDirection
{
    public static readonly DtoDirection Request = From("Request");
    public static readonly DtoDirection Response = From("Response");
    private static string NormalizeInput(string input)
    {
        // Remove whitespace and make Titlecase.
        var trimmed = input.Trim().ToLowerInvariant();
        var titleCase = string.Join("", trimmed[0], trimmed.Substring(1, trimmed.Length - 1));
        return titleCase;
    }
    
    private static Validation Validate(string input)
    {
        var isProvided = !string.IsNullOrWhiteSpace(input) ? Validation.Ok : Validation.Invalid($"{nameof(input)} is required");
        string[] values = ["Request", "Response"];
        return !values.Contains(input.Trim())
            ? Validation.Ok
            : Validation.Invalid($"{nameof(input)} must be one of {string.Join('|', values)}");
    }
} 