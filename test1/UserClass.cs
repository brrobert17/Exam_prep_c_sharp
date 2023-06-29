namespace test1;

public class UserClass
{
    public string Username { get; set; }
    public string Password { get; set; }

    public UserClass(string username, string password)
    {
        Username = username;
        Password = password;
    }
}