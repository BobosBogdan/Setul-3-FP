internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Introduceti un numar natural n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Numarul introdus nu este valid.");
                return;
            }

            PrimePanaLaN(n);
    }

        static void PrimePanaLaN(int n)
        {
            int[] v = new int[n];

            for (int i = 2; i < n / 2; i++)
            {
                if (v[i] == 0)
                {
                    for (int j = 2; i * j < n; j++)
                    {
                        v[i * j] = 1;
                    }
                }
            }

            Console.WriteLine($"Numerele prime pana la {n} sunt:");
            for (int i = 2; i < n; i++)
            {
                if (v[i] == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
}

