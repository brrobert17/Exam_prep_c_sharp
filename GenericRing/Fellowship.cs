namespace GenericRing;

public class Fellowship<T>
{
    public List<T>? Members { get; }

    public Fellowship()
    {
        Members = new List<T>();
    }

    public void AddMember(T member)
    {
        Members?.Add(member);
    }
    
    public void RemoveMember(T member)
    {
        Members?.Remove(member);
    }

    public List<T>? GetMembers()
    {
        return Members;
    }
}