
internal class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];
        int pozitie = -1;

        Console.Write("Introduceti valoarea cautata (k): ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            v[i] = int.Parse(Console.ReadLine());

            if (k == v[i])
            {
                pozitie = i;
                break;
            }
        }

        if (pozitie == -1)
        {
            Console.WriteLine($"Elementul {k} nu se afla in vector.");
        }
        else
        {
            Console.WriteLine($"Prima pozitie pe care apare {k} este: {pozitie + 1}");
        }
    }
}
