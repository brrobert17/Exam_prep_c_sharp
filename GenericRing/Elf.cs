namespace GenericRing;

public class Elf : Character
{
    public Elf(int level, string name)
    {
        Level = level;
        Name = name;
        Race = "ELF";
    }
    public override void Attack(Character otherCharacter)
    {
        Console.WriteLine($"The elf {Name} attacks " +
                          $"{otherCharacter.Name} of {otherCharacter.Race} " +
                          $"for {CalculateDamage()} damage!");
    }
}