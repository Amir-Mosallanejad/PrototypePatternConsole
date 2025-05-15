namespace PrototypePatternConsole;

public class Person : IPrototype<Person>
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public Person Clone()
    {
        return new Person
        {
            Name = this.Name,
            Address = this.Address.Clone() // Deep copy
        };
    }
}
