namespace Interfaces;
public class Rectangle : IShape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
        this._length = length;
        this._width = width;
    }

    public void Spin()
    {
        Console.WriteLine("bumpy");
    }

    public double CalculateArea()
    {
        return _length * _width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (_length + _width);
    }
}