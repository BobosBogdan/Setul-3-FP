internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Introduceti lungimea vectorului: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Lungimea introdusa nu este valida.");
                return;
            }

            int[] vector = new int[n];
            CitesteVector(vector);

            InversVector(vector);

            Console.WriteLine("Vectorul inversat:");
            AfiseazaVector(vector);
    }

        static void CitesteVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = CitesteVal($"Introduceti elementul {i + 1}: ");
            }
        }

        static void InversVector(int[] vector)
        {
            int i = 0;
            int j = vector.Length - 1;

            while (i <= j)
            {
                int aux = vector[i];
                vector[i] = vector[j];
                vector[j] = aux;
                j--;
                i++;
            }
        }

        static void AfiseazaVector(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.WriteLine(element);
            }
        }

        static int CitesteVal(string prompt)
        {
            int valoare;
            bool valid;
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out valoare);
                if (!valid)
                {
                    Console.WriteLine("Valoare introdusa invalida. Incearca din nou.");
                }
            } while (!valid);

            return valoare;
        }
}
