namespace Imperative_Structures;

public class Person
{
    public string? Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
    
    public Person() {}

    public void GetPossibleName()
    {
        Console.WriteLine(Name ?? "Anonymus");
    }
}