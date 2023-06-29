using CollectionsAndGenerics;

string[] myWords = new string[5];
string[] myWords2 = new string[3] { "dog", "cat", "snake" };
int[] myNums = { 1, 2, 3, 4 };
var myNums2 = new[] { 1, 5, 3, 4 };
var no4 = myNums2[3];

Console.WriteLine(myNums.Max());
Console.WriteLine(myNums.Min());
Console.WriteLine(myNums.Sum());
Console.WriteLine(myNums.Average());

Console.WriteLine("Sorted:");
Array.Sort(myNums2);
Array.Sort(myWords2, (x,y)=> x.Length.CompareTo(y.Length));
foreach (var n in myNums2)
{
    Console.WriteLine(n);
}

for (int i = 0; i < myWords2.Length; i++)
{
    Console.WriteLine(myWords2[i]);
}

Console.WriteLine("Reversed: ");
Array.Reverse(myWords2);
foreach (var w in myWords2)
{
    Console.WriteLine(w);
}

Console.WriteLine($"Length1: {myWords.Length}");
Array.Copy(myWords2, myWords, 3);
foreach (var w in myWords)
{
    Console.WriteLine($"Item{Array.IndexOf(myWords,w)}: {w}");
}

int[][] jagged =
{
    new[] { 1, 2, 3 },
    new[] { 4, 5, 6 },
    new[] { 7, 8 }
};

Console.WriteLine(jagged[0][2]);
int [,] multi = {{1,2,3},{4,5,6},{7,8,9}};
Console.WriteLine(multi[1,2]);

int[] myColl = { 1, 2, 3, 4, 5 };
Index x = ^1;
Console.WriteLine(x.IsFromEnd);
Console.WriteLine($"with Index: {myColl[x]}");
int[] range = myColl[1..3];
Span<int> range2 = myColl[..^1];
foreach (int n in range2)
{
    Console.WriteLine(n);
}


//indexer
var tempRecord = new TempRecord();
tempRecord[3] = 300.3F;
tempRecord[5] = 200.1F;

Console.WriteLine($"Length: {tempRecord.Length}");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Element #{i} = {tempRecord[i]}");
}

//old way
var tempRec2 = new TempRecord();
var recArr = tempRec2.Temps;

recArr[0] = 100.00F;
tempRec2.Temps = recArr;
var recArr2 = tempRec2.Temps;
Console.WriteLine("\n set:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Element #{i} = {recArr2[i]}");
}

