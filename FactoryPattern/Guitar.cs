namespace FactoryPattern;

public class Guitar : IInstrument
{
    public void Play()
    {
        Console.WriteLine("Crafting a new Guitar!");
    }
}