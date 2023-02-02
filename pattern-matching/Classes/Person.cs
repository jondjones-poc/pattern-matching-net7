namespace pattern_matching.Classes;

public class Person
{
    public Person()
    {
        Name = string.Empty;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public Location? Location { get; set; }

    public void Deconstruct(
        out string name,
        out int age,
        out Location? location)
    {
        name = Name;
        age = Age;
        location = Location;
    }
}
