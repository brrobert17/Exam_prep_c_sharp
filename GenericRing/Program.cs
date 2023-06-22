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

var v1 = new Human(4,"bob")
{
    Bullets = 200
};
Console.WriteLine(Validator.TryValidateObject(v1, 
    new ValidationContext(v1), 
    new List<ValidationResult>()));



if (fellowship.Members != null)
    foreach (var c in fellowship.Members)
    {
        c.Attack(dummy);
    }
    
    