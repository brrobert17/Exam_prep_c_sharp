using System.Linq;
using LINQ;

Console.WriteLine("Hello, Language-Integrated Query!");
List<Employee> employees = new List<Employee>
{
    new Employee { Name = "John", Department = "Sales", Salary = 50000.00m },
    new Employee { Name = "Emily", Department = "HR", Salary = 45000.00m },
    new Employee { Name = "Michael", Department = "Sales", Salary = 55000.00m },
    new Employee { Name = "Sarah", Department = "Sales", Salary = 48000.00m },
    new Employee { Name = "David", Department = "IT", Salary = 60000.00m },
    new Employee { Name = "Jessica", Department = "Sales", Salary = 52000.00m },
    new Employee { Name = "Brian", Department = "Sales", Salary = 47000.00m },
    new Employee { Name = "Michelle", Department = "HR", Salary = 43000.00m },
    new Employee { Name = "Kevin", Department = "Sales", Salary = 51000.00m },
    new Employee { Name = "Linda", Department = "Sales", Salary = 49000.00m },
    new Employee { Name = "Tim", Department = "HR", Salary = 49000.00m },
    new Employee { Name = "Saf", Department = "Sales", Salary = 42000.00m },
    new Employee { Name = "Sam", Department = "Sales", Salary = 42000.00m },
    new Employee { Name = "Monica", Department = "Sales", Salary = 70000.00m }
};

List<Employee> sales = employees.Where(e => e.Department == "Sales").ToList();
List<string?> salesNames = 
    employees.Where(e => e.Department == "Sales").Select(e=> e.Name).ToList();
List<Employee> ascSalary = sales.OrderBy(e => e.Salary).ThenBy(e => e.Name).ToList();
Employee lowest = ascSalary.First();
Employee highest = ascSalary.Last();

int count = sales.Count;

Console.WriteLine("First Employee: " + lowest.Name);
Console.WriteLine("Last Employee: " + highest.Name);
Console.WriteLine("Employee Count: " + count);
Console.WriteLine("Minimum Salary: " + lowest.Salary);
Console.WriteLine("Maximum Salary: " + highest.Salary);

List<string> animals = new List<string> { "cat", "dog", "magpie", "snake" };

IEnumerable<string> longNames = 
    from animal in animals
    where animal.Length >= 5
    orderby animal.Length
    select animal;

foreach (var str in longNames)
{
    Console.WriteLine(str);
}

var g = animals.GroupBy(name => name.Length);

var d = g.ToDictionary(g => g.Key, g => g.ToList());

foreach (var kvp in d)
{
    int key = kvp.Key;
    List<string> values = kvp.Value;

    Console.WriteLine($"Name length: {key}");

    foreach (string value in values)
    {
        Console.WriteLine($"Name: {value}");
    }
}


// Custom extension method
List<Book> books = new List<Book>
{
    new Book { Author = "Hunter S. Thompson", Title = "Fear and loathing in Las Vegas" },
    new Book { Author = "Dostoyevsky", Title = "Crime and punishment" },
    new Book { Author = "Dostoyevsky", Title = "Devils" }
};

var myBooks = books.OrderByAuthor("Dostoyevsky");
foreach (Book b in myBooks)
{
    Console.WriteLine(b.Title);
}



internal class Employee
{
    public string? Name { get; set; }
    public string? Department { get; set; }
    public decimal Salary { get; set; }
}