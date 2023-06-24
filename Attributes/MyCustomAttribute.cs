namespace Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class MyCustomAttribute : Attribute
{
    public string Data { get; set; }
}