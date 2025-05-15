namespace PrototypePatternConsole;

public class Address : IPrototype<Address>
{
    public string Street { get; set; }
    public string City { get; set; }

    public Address Clone()
    {
        return new Address
        {
            Street = this.Street,
            City = this.City
        };
    }
}
