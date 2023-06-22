namespace Event;

public class Logic
{
    public event EventHandler? ProcessCompleted;
    private void OnProcessCompleted(EventArgs e)
    {
        ProcessCompleted?.Invoke(this, e);
    }
    public void StartProcess()
    {
        Console.WriteLine("started...");
        OnProcessCompleted(EventArgs.Empty);
    }

    
}