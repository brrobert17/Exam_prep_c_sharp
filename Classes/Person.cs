namespace Classes;

public class Person
{
    private string? _name;
    private const string gender = "male";
    public string education;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        this._name = name;
        Age = age;
    }

    public Person(string name) : this(name, 0)
    {
    }
    
    public Person(){}
    
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Gender: {gender}";
    }
}