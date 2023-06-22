using Imperative_Structures;

Vector v1 = new Vector(2, 3);
Vector v2 = new Vector(4, 5);
Vector sum = v1 + v2;
Console.WriteLine("Sum: ({0}, {1})", sum.X, sum.Y);
var coordinate = v1?.X;


int? nullableInt = null;
Nullable<int> nullableInt2 = null;

Person? p1 = null;
var p2 = new Person();
var p3 = new Person("tim");

p1?.GetPossibleName(); 
p2.GetPossibleName();
p3.GetPossibleName();

var v3 = $"{p1?.Name} Hello";
var v4 = "hello" + p1?.Name;

Console.WriteLine(v4);

const string name = "John";
const int age = 30;
const decimal salary = 5000.50m;

var message = $"{"Name",-10} {name}\n{"Age",-10} {age:x8}\n{"Salary",-10} {salary:F1}";
Console.WriteLine(message);

var m2 = "\\localhost\n:8080";
var m3 = @"\\localhost\n:8080";
Console.WriteLine(m2);
Console.WriteLine(m3);

var html = """
    <script>alert("hello world")</script>
    """;
Console.WriteLine(html);

var myNum = 3;
string s = myNum switch
{
    5 => "perfect",
    6 => "too much",
    _ => "else"
};
Console.WriteLine(s);

switch (myNum)
{
    case 3: Console.WriteLine("very little");
        break;
    case >3 and <10: Console.WriteLine("very nice");
        break;
    default: Console.WriteLine("its magic");
        break;
}

var m5 = 3;
var m6 = 3;

var ms = m5 + m6;

Console.WriteLine(ms);

string m7 = "4";

var m9 = Convert.ToInt32(m7);

Console.WriteLine(m9.GetType());

string s1 = "hello";
var s2 = "hello";
var p10 = new Person("soheil");
if (p10 is { Name: "soheil" })
{
    Console.WriteLine("yesItIs a person Stat");
}

static void MMM(object o)
{
    if (o is Person{ Name: "soheil" })
    {
        Console.WriteLine("yesItIs a person Method");
    }
}

MMM(p10);

