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
            CitesteVect(vector);

            Rotire(vector);

            Console.WriteLine("Vectorul rotit la stanga:");
            AfisareVect(vector);
    }

        static void CitesteVect(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = CitesteVal($"Introduceti elementul {i + 1}: ");
            }
        }

        static void Rotire(int[] vector)
        {
            int primulElement = vector[0];

            for (int i = 0; i < vector.Length - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            vector[vector.Length - 1] = primulElement;
        }

        static void AfisareVect(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
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
                    Console.WriteLine("Valoare introdusa invalida. Incearca din nou. ");
                }
            } while (!valid);

            return valoare;
        }
}
