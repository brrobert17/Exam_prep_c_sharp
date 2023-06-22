namespace GenericRing;

public class Dwarf : Character
{
    public Dwarf(int level, string name)
    {
        Level = level;
        Name = name;
        Race = "DWARF";
    }
    
    public override void Attack(Character otherCharacter)
    {
        Console.WriteLine($"The dwarf {Name} attacks " +
                          $"{otherCharacter.Name} of {otherCharacter.Race} " +
                          $"for {CalculateDamage()} damage!");
    }
}