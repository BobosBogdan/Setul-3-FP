internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            Console.Write("Introduceti elementul pentru cautare (x): ");
            int x = int.Parse(Console.ReadLine());

            CitesteVec(vector);

            int pozitie = CautaElement(vector, x, 0, n - 1);

            if (pozitie != -1)
            {
                Console.WriteLine($"Elementul {x} a fost gasit pe pozitia {pozitie}");
            }
            else
            {
                Console.WriteLine($"Elementul {x} nu a fost gasit in vector.");
            }
    }

        static void CitesteVec(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }

        static int CautaElement(int[] vector, int element, int stanga, int dreapta)
        {
            while (stanga <= dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;

                if (vector[mijloc] == element)
                {
                    return mijloc;
                }
                else if (vector[mijloc] < element)
                {
                    stanga = mijloc + 1; 
                }
                else
                {
                    dreapta = mijloc - 1; 
                }
            }

            return -1; 
        }
}
    