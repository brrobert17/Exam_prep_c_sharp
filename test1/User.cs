namespace test1;

public struct User
{
    private string username;

    public string Username
    {
        get => username;
        set => username = value;
    }
    
    public string Password { get; set; }

    public User(string username, string password)
    {
        this.username = username;
        Password = password;
    }
    
    public User(){}

}