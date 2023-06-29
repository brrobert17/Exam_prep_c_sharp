namespace MyBuilder;

public interface ICarBuilder
{
    CarBuilder AddModel(string model);
    CarBuilder AddBrand(string brand);
    CarBuilder AddYear(int year);
    Car Build();
}