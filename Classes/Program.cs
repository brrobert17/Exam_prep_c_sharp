using System;
using Classes;


// Base class
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

// Derived classes
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Shape();
        shapes[1] = new Circle();
        shapes[2] = new Rectangle();

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
        
        //Object initializers use the following syntax:
        var p2 = new Person
        {
            Name = "tim",
            Age = 20
        };

        Person p3 = new Person("Tom", 33);

        Person p4 = new Person("Dan");
        Person p5 = new Person("Soheil");
        p5.education = "highschool";
        var p6 = new Person("bob", 20, "uni");
        Console.WriteLine(p4.ToString());
        Console.WriteLine(p5.ToString());
        
        Car car = new Car("Toyota", 2022, "Camry");
        Vehicle vehicle = new Vehicle("BMW", 1999);
        vehicle.RunEngine();
        car.RunEngine();
        Console.WriteLine($"Manufacturer: {car.Manufacturer}, Year: {car.Year}, Model: {car.Model}");
    }
}