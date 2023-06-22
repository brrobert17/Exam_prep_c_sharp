// See https://aka.ms/new-console-template for more information

using test1;

Console.WriteLine("Hello, World!");

var u1 = new User();
u1.Username= "aaa";
u1.Password= "000";

var u2 = new User
{
    Username = "bbb",
    Password= "111"
};

var u3 = new User("ccc", "222");
Console.WriteLine("objPrint: "+ u3);

var ur1 = new UserRecord("admin", "admin");
Console.WriteLine(ur1);

var us1 = new User
{
    Username = "tim",
    Password = "000"
};
var us2 = us1;
us1.Username = "TIM2";
Console.WriteLine(us1.Username);
Console.WriteLine(us2.Username);