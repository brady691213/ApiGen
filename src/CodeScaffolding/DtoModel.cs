using CodeScaffolding.Next;

namespace CodeScaffolding;

public class DtoModel
{
    public string Name { get; set; }
    
    public DtoDirection Direction { get; set; }

    public string Suffix => Direction.ToString();

    public List<PropertyModel> Properties { get; set; } = new();
}