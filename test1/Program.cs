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