namespace Reflection.Tests.Types;

public class NestedGenerics
{
    public Nullable<Guid> Anullable { get; set; }
    
    public List<Int32?>? ShortFormNullables { get; set; }
    
    // ReSharper disable once ConvertNullableToShortForm
    public List<Nullable<Int32>>? ExplicitNullables { get; set; }
}