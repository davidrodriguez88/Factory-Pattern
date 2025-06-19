namespace FactoryPattern;

public class Bass : IInstrument
{
    public void Play()
    {
        Console.WriteLine("Crafting a new Bass!");
    }
}