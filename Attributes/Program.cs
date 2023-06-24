using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Attributes;

var c1 = new Computer()
{
    Brand = "HP",
    CPU = 6000
};
var context = new ValidationContext(c1);
var result = new List<ValidationResult>();
bool ok = Validator.TryValidateObject(c1, context, result, true);
Console.WriteLine(ok); //false

var c2 = new Computer()
{
    CPU = 4000
};
var context2 = new ValidationContext(c2);
var result2 = new List<ValidationResult>();
bool ok2 = Validator.TryValidateObject(c2, context2, result2, true);
Console.WriteLine(ok2); //false

var c3 = new Computer()
{
    Brand = "Dell",
    CPU = 4000
};
var context3 = new ValidationContext(c3);
var result3 = new List<ValidationResult>();
bool ok3 = Validator.TryValidateObject(c3, context3, result3, true);
Console.WriteLine(ok3); //true

MethodInfo methodInfo = typeof(Computer).GetMethod("SayHello");
MyCustomAttribute myCustomAttribute = (MyCustomAttribute)methodInfo
    .GetCustomAttributes(typeof(MyCustomAttribute), false)
    .FirstOrDefault();

if (myCustomAttribute != null)
{
    Console.WriteLine($"Annotation: {myCustomAttribute.Data}");
}

var propertyInfo = typeof(Computer).GetProperties();
foreach (var p in propertyInfo)
{
    var attributes = p.GetCustomAttributes(false);
    
    foreach (var o in attributes)
    {
        Console.WriteLine(o.GetType().GetTypeInfo());
    }
}