using System.Diagnostics;

string[] teams = {"København", "Århus", "Lyngby", "Nordsjælland", "Brøndby"};

var stopwatch = Stopwatch.StartNew();
Random r = new Random();

var t1 = Task.Run(() =>
{
    int sec = r.Next(0, 90);
    Task.Delay(TimeSpan.FromMilliseconds(sec)).Wait();
    Console.WriteLine($"Game time of {teams[0]}: {stopwatch.Elapsed}");
    Console.WriteLine($"{teams[0]} scored a goal after {sec} game minutes");
});
var t2 = Task.Run(() =>
{
    int sec = r.Next(0, 90);
    Task.Delay(TimeSpan.FromMilliseconds(sec)).Wait();
    Console.WriteLine($"Game time of {teams[1]}: {stopwatch.Elapsed}");
    Console.WriteLine($"{teams[1]} scored a goal after {sec} game minutes");
});
var t3 = Task.Run(() =>
{
    int sec = r.Next(0, 90);
    Task.Delay(TimeSpan.FromMilliseconds(sec)).Wait();
    Console.WriteLine($"Game time of {teams[2]}: {stopwatch.Elapsed}");
    Console.WriteLine($"{teams[2]} scored a goal after {sec} game minutes");
});
var t4 = Task.Run(() =>
{
    int sec = r.Next(0, 90);
    Task.Delay(TimeSpan.FromMilliseconds(sec)).Wait();
    Console.WriteLine($"Game time of {teams[3]}: {stopwatch.Elapsed}");
    Console.WriteLine($"{teams[3]} scored a goal after {sec} game minutes");
});
var t5 = Task.Run(() =>
{
    int sec = r.Next(0, 90);
    Task.Delay(TimeSpan.FromMilliseconds(sec)).Wait();
    Console.WriteLine($"Game time of {teams[4]}: {stopwatch.Elapsed}");
    Console.WriteLine($"{teams[4]} scored a goal after {sec} game minutes");
});

var teamTasks = new[] { t1, t2, t3, t4, t5 };
foreach (var tt in teamTasks)
{
    Console.WriteLine($"Task started: {stopwatch.Elapsed}");
    tt.Wait();
}
//Task.WaitAll(t1,t2,t3,t4,t5);