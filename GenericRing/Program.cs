using System.ComponentModel.DataAnnotations;
using GenericRing;

Fellowship<Character> CreateFellowship()
{
    var fellowship = new Fellowship<Character>();
    fellowship.AddMember(new Human(10, "Tim"));
    fellowship.AddMember(new Dwarf(12, "Zoltan"));
    fellowship.AddMember(new Elf(15, "Emmanuel"));
    return fellowship;
}

var fellowship = CreateFellowship();
var dummy = new Character() { Name = "DUMMY", Level = 0, Race = "INANIMATE" };


if (fellowship.Members != null)
    foreach (var c in fellowship.Members)
    {
        c.Attack(dummy);
    }


Dwarf[] a1 = { new Dwarf(20, "gg"), new Dwarf(21, "hh") };
Character[] a2 = a1;



List<Human> l2 = new List<Human> {new Human(10, "aa"), new Human(11, "bb")};
IEnumerable<Character> l3 = l2;
List<Character> l4 = l3.ToList();
foreach (var c in l4)
{
   Console.WriteLine(c.GetType());
}
    