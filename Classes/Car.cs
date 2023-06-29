namespace Classes;

public class Car : Vehicle
{
    public string Model { get; set; }

    public Car(string manufacturer, int year, string model) : base(manufacturer, year)
    {
        Model = model;
    }

    public override void RunEngine()
    {
        Console.WriteLine($"{Manufacturer} {Year} {Model} Car Engine running");
    }
    
    public new void StopEngine()
    {
        Console.WriteLine("stopped vehicle.");
    }
}
