namespace Reflection.Tests.SampleTypes;

public class Person(Guid id) : BaseEntity<Guid>(id)
{
    public virtual string Surname { get; set; }
    
    public virtual string FirstName { get; set; }
}