namespace Event;

class EventHandlerTest
{
    public static void Main(string[] args)
    {
        var l1 = new Logic();
        l1.ProcessCompleted += l1_ProcessCompleted;
        l1.StartProcess();
    }

    private static void l1_ProcessCompleted(object? sender, EventArgs e)
    {
        Console.WriteLine("Completed!");
    }
}