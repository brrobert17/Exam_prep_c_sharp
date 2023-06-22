namespace Interfaces;

public class Circle : IShape, IObject
{
    private double _radius;
    public Circle(double radius)
    {
        this._radius = radius;
    }
    void IShape.Spin()
    {
        Console.WriteLine("smooth");
    }
    void IObject.Spin()
    {
        Console.WriteLine("spinning smooth");
    }
    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * _radius;
    }
}