namespace Reflection.Tests.SampleTypes;

public class SuperGeneric
{
    public Nullable<Guid> Anullable { get; set; }

    // ReSharper disable once ConvertNullableToShortForm
    public List<Nullable<int>>? ListOfNullables { get; set; }
}