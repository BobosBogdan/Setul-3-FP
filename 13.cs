internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int dim = int.Parse(Console.ReadLine());

            int[] v = new int[dim];

            Console.WriteLine($"Introduceti {dim} elemente pentru a completa vectorul:");

            for (int i = 0; i < dim; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            SortInsertie(v);

            Console.WriteLine("Vectorul sortat:");

            for (int i = 0; i < dim; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
    }

        static void SortInsertie(int[] vector)
        {
            for (int i = 1; i < vector.Length; ++i)
            {
                int cheie = vector[i];
                int j = i - 1;

                while (j >= 0 && vector[j] > cheie)
                {
                    vector[j + 1] = vector[j];
                    j = j - 1;
                }

                vector[j + 1] = cheie;
            }
        }
}
