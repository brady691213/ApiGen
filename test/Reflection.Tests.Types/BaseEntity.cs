namespace Reflection.Tests.Types;

public class BaseEntity<T>(T id)
{
    public T Id { get; set; } = id;

    public virtual bool IsDeleted { get; set; }
}