namespace Reflection.Tests;

public class PropertyReflectorTests
{
    public class BaseEntity
    {
        protected string ProtectedStringProp { get; set; }
        public string Prop2 { get; set; }
    }
    
    public void GetEntityPropertiesReturnsPublicProps()
    {
        
    }
}