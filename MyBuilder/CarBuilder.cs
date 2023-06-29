namespace MyBuilder;

public class CarBuilder : ICarBuilder
{
    private readonly Car _car;
    public CarBuilder()
    {
        _car = new Car
        {
            Owners = new List<string>()
        };
    }
    public CarBuilder AddBrand(string brand)
    {
        _car.Brand = brand;
        return this;
    }
    public CarBuilder AddModel(string model)
    {
        _car.Model = model;
        return this;
    }
    public CarBuilder AddYear(int year)
    {
        _car.Year = year;
        return this;
    }
    public CarBuilder AddOwner(string owner)
    {
        _car.Owners?.Add(owner);
        return this;
    }
    public Car Build()
    {
        return _car;
    }
}

