namespace test1;

public struct UserStruct
{
    private string username;

    public string Username
    {
        get => username;
        set => username = value;
    }
    
    public string Password { get; set; }

    public UserStruct(string username, string password)
    {
        this.username = username;
        Password = password;
    }
    
    public UserStruct(){}

}