using System.ComponentModel.DataAnnotations;

namespace GenericRing;

public class Human : Character
{

    public Human(int level, string name)
    {
        Level = level;
        Name = name;
        Race = "HUMAN";
    }
    

    public override void Attack(Character otherCharacter)
    {
        Console.WriteLine($"The human {Name} attacks " +
                          $"{otherCharacter.Name} of {otherCharacter.Race} " +
                          $"for {CalculateDamage()} damage!");
    }
}