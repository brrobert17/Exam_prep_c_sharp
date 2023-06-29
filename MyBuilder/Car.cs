namespace MyBuilder;

public class Car
{
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int? Year { get; set; }
    
    public List<string>? Owners { get; set; } 

    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Brand??Brand}, Model: {Model??Model}, Year: {Year??Year}");
        if (Owners == null || Owners.Count == 0) return;
        Console.WriteLine($"Owners:");
        foreach (var owner in Owners)
        {
            Console.WriteLine(owner);
        }
    }
}