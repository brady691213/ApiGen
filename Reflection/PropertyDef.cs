namespace Reflection.Tests;

public record PropertyDef
{
    public required string TypeName { get; set; } 

    public required string PropertyName { get; set; } 

    public bool IsOverride { get; set; } 
}