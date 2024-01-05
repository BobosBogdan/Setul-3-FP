internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Introduceti elementele vectorului (separate printr-un spatiu): ");
        var vector = CitesteVect();

        int valoareMin = int.MaxValue;
        int valoareMax = int.MinValue;
        int frecvMin = 0;
        int frecvMax = 0;

        foreach (var element in vector)
        {
            if (element < valoareMin)
            {
                valoareMin = element;
                frecvMin = 1;
            }
            else if (element == valoareMin)
            {
                frecvMin++;
            }

            if (element > valoareMax)
            {
                valoareMax = element;
                frecvMax = 1;
            }
            else if (element == valoareMax)
            {
                frecvMax++;
            }
        }

        Console.WriteLine($"Valoarea minima din vector este {valoareMin} si apare de {frecvMin} ori.");
        Console.WriteLine($"Valoarea maxima din vector este {valoareMax} si apare de {frecvMax} ori.");
    }

    static int[] CitesteVect()
    {
        string[] input = Console.ReadLine().Split(" ");
        int[] vector = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            vector[i] = int.Parse(input[i]);
        }

        return vector;
    }
}
