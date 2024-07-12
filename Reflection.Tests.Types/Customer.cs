namespace Reflection.Tests.Types;

public class Customer(Guid id) : Person(id)
{
    public string Email { get; set; }
    
    public string Phone { get; set; }
}