namespace FactoryPattern;

public class Banjo : IInstrument
{
    public void Play()
    {
        Console.WriteLine("Crafting a new Banjo!");
    }
}