namespace FactoryPattern;

public static class InstrumentFactory
{
    public static IInstrument CraftInstrument(int numberOfStrings)
    {
        switch (numberOfStrings)
        {
            case 4:
                return new Bass();
            case 5:
                return new Banjo();
            case 6:
                return new Guitar();
            case 7:
                return new ProgRockGuitar();
            default:
                return null;
        }
    }
}