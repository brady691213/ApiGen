namespace Reflection.Tests.SampleTypes;

public class SuperGeneric
{
    public Nullable<Guid> Anullable { get; set; }
    
    public List<int?>? ShortFormNullables { get; set; }
    
    // ReSharper disable once ConvertNullableToShortForm
    public List<Nullable<int>>? ExplicitNullables { get; set; }
}