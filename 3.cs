internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Introduceti lungimea vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];
        int pozitieMin = -1;
        int pozitieMax = -1;

        Console.WriteLine("Introduceti elementul 1: ");
        int primulElement = int.Parse(Console.ReadLine());

        v[0] = primulElement;
        int i;

        if (primulElement < v[0])
        {
            pozitieMin = 0;
            pozitieMax = 0;
        }
        else
        {
            pozitieMin = -1;
            pozitieMax = 0;
        }

        for (i = 1; i < n; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1}: ");
            v[i] = int.Parse(Console.ReadLine());

            if (v[i] < v[i - 1])
            {
                pozitieMin = i;
            }
            else if (v[i] > v[i - 1])
            {
                pozitieMax = i;
            }
        }

        Console.WriteLine($"Elementul maxim {v[pozitieMax]} se afla pe pozitia {pozitieMax + 1}");
        Console.WriteLine($"Elementul minim {v[pozitieMin]} se afla pe pozitia {pozitieMin + 1}");
    }
}    