using System.Diagnostics.Metrics;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many strings are on the instrument you wish to build?");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int stringCount))
            {
                IInstrument instrument = InstrumentFactory.CraftInstrument(stringCount);

                if (instrument != null)
                {
                    instrument.Play();
                }
                else
                {
                    Console.WriteLine("That number of strings doesn't match an instrument we can create.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
