namespace Classes;

public class Car : Vehicle
{
    public string Model { get; set; }

    public Car(string manufacturer, int year, string model) : base(manufacturer, year)
    {
        Model = model;
    }
}