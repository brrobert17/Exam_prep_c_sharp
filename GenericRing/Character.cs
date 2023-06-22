namespace GenericRing;

public class Character
{
    public string? Name { get; set; }
    public string? Race { get; set; }
    public int? Level { get; set; }

    public virtual void Attack(Character otherCharacter)
    {
        
    }

    protected int? CalculateDamage()
    {
        return Level * 10;
    }
}
