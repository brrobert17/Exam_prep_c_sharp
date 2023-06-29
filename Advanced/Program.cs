var t1 = Task.Run(() =>
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"Task 1: {i}");
    }
});
var t2 = Task.Run(() =>
{
    int sum = 0;
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"Task 2: {i}");
        sum +=i;
    }
    return sum;
});
var t3 = Task.Run(() =>
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"Task 3: {i}");
    }
});
Task.WaitAll(t1, t3);

var t4 = Task.Run(() =>
{
    var awaiter = t2.GetAwaiter();
    awaiter.OnCompleted(() =>
    {
        Console.WriteLine($"Result of t2 count: {awaiter.GetResult()}");
    });
    
});


async Task<int> Method1()
{
    var count = 0;
    await Task.Run(() =>
    {
        for (int i = 0; i < 100; i++)
        {
            Task.Delay(10);
            Console.WriteLine($"Method 1 count: {count++}");
        }
    });
    return count;
}

Console.WriteLine($"Final count: {await Method1()}");