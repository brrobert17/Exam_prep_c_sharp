//constructor

using System.Runtime.InteropServices;

var t1 = new Tuple<string,int,double>("hello", 10, 10.0);
//de-construction
(string a, int b, double c) = t1;
//using discard
(_,int d, double e) = t1;
//Create method
var t2 = Tuple.Create("stringValue", 100, 10F);
//constructor
var t3 = (1, "hello", 20F);
//access
Console.WriteLine($"My Tuple: {t1.Item1} and {t1.Item2} and {t1.Item3}");
//specify return type
(int, string) ReturnTuple() { return (10, "hello"); }
//named tuple properties
(int a, string b) ReturnTuple2() { return (a:10, b:"hello"); }

int number = 10;
Console.WriteLine($"original: {number}");
// 10
static void AddRef(ref int refNumber)
{
    refNumber += 15;
}
AddRef(ref number);
Console.WriteLine($"after refMethod: {number}");
// 25
static void AddOut(out int outNumber)
{
    outNumber = 0;
    outNumber += 50;
}
AddOut(out number);
Console.WriteLine($"after outMethod: {number}");
// 50
void AddIn(in int inNumber)
{
    number = inNumber;
}
AddIn(100);
Console.WriteLine($"after inMethod: {number}");
// 100

void MyMethod(string s1, string s2, string s3)
{ Console.WriteLine($"{s1}, {s2}, {s3}"); }

MyMethod("bob", "what's up?", "hello");
// bob, what's up?, hello
MyMethod(s2: "bob", s3: "what's up?", s1: "hello");
// hello, bob, what's up?

void MyOptionalMethod(string s1, [Optional] int s2)
{ Console.WriteLine($"{s1},{s2 + 2}"); }

MyOptionalMethod("hello", 10);
// hello,12
MyOptionalMethod("hello");
// hello,2

void MyDefaultValueMethod(string s1, string s2 = "bamm")
{ Console.WriteLine($"{s1}, {s2}"); }

MyDefaultValueMethod("hello");
// hello, bamm
MyDefaultValueMethod("hello", "no bamm");
// hello, no bamm