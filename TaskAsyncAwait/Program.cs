using System.Diagnostics;

var watch = Stopwatch.StartNew();
async Task<int> Task1Async(int num)
{
    Console.WriteLine($"start1 @ {watch.Elapsed}");
    //simulate processing time
    await Task.Delay(200);
    Console.WriteLine($"end1 @ {watch.Elapsed}");
    return num * 2;
}
Console.WriteLine(Task1Async(10).Result);

async Task<int> Task2Async(int num)
{
    Console.WriteLine($"start2 @ {watch.Elapsed}");
    //simulate processing time
    await Task.Delay(200);
    Console.WriteLine($"end2 @ {watch.Elapsed}");
    return num * 10;
}
Console.WriteLine(Task2Async(await Task1Async(20)).Result);
