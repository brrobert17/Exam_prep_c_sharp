namespace CollectionsAndGenerics;

public class TempRecord
{
    
    float[] temps = new float[10]
    {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
    };

    public int Length => temps.Length;
    
    public float this[int index]
    {
        get => temps[index];
        set => temps[index] = value;
    }

    public float[] Temps
    {
        get => temps;
        set => temps = value ?? throw new ArgumentNullException(nameof(value));
    }
}