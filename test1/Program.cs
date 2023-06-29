// See https://aka.ms/new-console-template for more information

using test1;

Console.WriteLine("Hello, World!");

var u1 = new UserStruct();
u1.Username= "aaa";
u1.Password= "000";

var u2 = new UserStruct
{
    Username = "bbb",
    Password= "111"
};

var u3 = new UserStruct("ccc", "222");
Console.WriteLine("objPrint: "+ u3);

var ur1 = new UserRecord("rob", "000");
var ur2 = new UserRecord("rob", "000");
var ur3 = ur1 with { username = "rob2" };
Console.WriteLine(ur1); // built-in ToString()
Console.WriteLine(ur3); // built-in ToString()
Console.WriteLine($"record comparison: {ur1.Equals(ur2)}"); // true
var user1 = new UserStruct("rob", "000");
var user2 = new UserStruct("rob", "000");
Console.WriteLine($"struct comparison: {user1.Equals(user2)}"); // true
var userClass1 = new UserClass("rob", "000");
var userClass2 = new UserClass("rob", "000");
Console.WriteLine($"class comparison: {userClass1.Equals(userClass2)}"); // false

UserClass uu3 = userClass1;
uu3.Username = "uc-rob2";
Console.WriteLine(userClass1.Username);

var us1 = new UserStruct
{
    Username = "tim",
    Password = "000"
};
var us2 = us1;
us1.Username = "TIM2";
Console.WriteLine(us1.Username);
Console.WriteLine(us2.Username);

var mw1 = 10;
var mw2 = "10";
var mw3 = mw1 + mw2;
Console.WriteLine($"type coersion: {mw3}");