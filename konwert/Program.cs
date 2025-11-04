namespace konwerter
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperaturaCelsjusz = 25;
            double farenheit = (temperaturaCelsjusz * 9 / 5) + 32;
            temperaturaCelsjusz = (farenheit - 32) * 5 / 9;
            Console.WriteLine($"temperatura w farenheitach: {Math.Round(farenheit, 2)}");
            Console.WriteLine($"Konwersjaz powrotem do celsjusza:{Math.Round(temperaturaCelsjusz, 2)}")
            if (temperaturaCelsjusz < 0)
            {
                Console.WriteLine("uwazaj temperatura ponizej zera");
            }
        }
    }

}
