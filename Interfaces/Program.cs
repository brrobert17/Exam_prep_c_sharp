namespace Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        IShape rectangle = new Rectangle(4, 5);
        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
        Console.WriteLine("Rectangle Perimeter: " + rectangle.CalculatePerimeter());

        IShape circle = new Circle(3);
        Console.WriteLine("Circle Area: " + Math.Round(circle.CalculateArea(), 2));
        Console.WriteLine("Circle Perimeter: " + Math.Round(circle.CalculatePerimeter(), 2));
        rectangle.Spin();
        circle.Spin();

        IObject circle2 = new Circle(4);
        circle2.Spin();

        Circle c2 = new Circle(4);
        //c2.Spin(); 
        c2.CalculateArea();

        TakeAction d1 = ConsolePrint;
        var d2 = new TakeAction(ConsolePrint);
        TakeAction d3 = text => Console.WriteLine(text);
        
        d1.Invoke("Hello World!");
        d2("What's up?");
        d3("All good.");

        var d4 = d1 + d2;
        d4("All together now!");

    }
    private delegate void TakeAction(string text);
    private static void ConsolePrint(string text)
    {
        Console.WriteLine(text);
    }
}