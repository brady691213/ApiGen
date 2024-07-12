namespace Reflection.Tests.SampleTypes;

public class BaseEntity<T>(T id)
{
    public T Id { get; set; } = id;

    public virtual bool IsDeleted { get; set; }
}