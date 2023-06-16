class MyClass
{
    public int Value;
}
struct MyStruct
{
    public int Value;
}
class Program2
{
    static void Main()
    {
        MyClass classObj1 = new MyClass();
        classObj1.Value = 10;

        MyClass classObj2 = classObj1; // Copying the reference
        classObj2.Value = 20;

        Console.WriteLine(classObj1.Value); // Output: 20

        MyStruct structObj1 = new MyStruct();
        structObj1.Value = 10;

        MyStruct structObj2 = structObj1; // Copying the entire struct
        structObj2.Value = 20;

        Console.WriteLine(structObj1.Value); // Output: 10
    }
}
