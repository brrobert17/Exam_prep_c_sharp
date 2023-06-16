namespace Classes;

public class Vehicle
{
    public string Manufacturer { get; set; }
    public int Year { get; set; }

    public Vehicle(string manufacturer, int year)
    {
        Manufacturer = manufacturer;
        Year = year;
    }

    public virtual void RunEngine()
    {
        Console.WriteLine($"{Manufacturer} {Year} Engine running");
    }
}