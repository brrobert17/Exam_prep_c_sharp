using System.ComponentModel.DataAnnotations;

namespace Attributes;

public class Computer
{
    [Required]
    public string Brand { get; set; }
    
    [Range(1000, 5000)]
    public int CPU { get; set; }

    [MyCustomAttribute (Data = "Hi!")]
    public void SayHello()
    {
        Console.WriteLine($"Hello @ {CPU}");
    }
}