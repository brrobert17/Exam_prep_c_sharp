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
    
    