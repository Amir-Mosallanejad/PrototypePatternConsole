using PrototypePatternConsole;

Console.WriteLine("Prototype Pattern");

Person original = new Person
{
    Name = "Alice",
    Address = new Address
    {
        Street = "123 Main St",
        City = "Metropolis"
    }
};

Console.WriteLine(original.Name);
Console.WriteLine(original.Address.City);

Person clone = original.Clone();

clone.Name = "Bob";
clone.Address.City = "Gotham";

Console.WriteLine(clone.Name);
Console.WriteLine(clone.Address.City);

Console.ReadKey();