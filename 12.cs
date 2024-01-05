internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int dim = int.Parse(Console.ReadLine());

            int[] v = new int[dim];
            int i, j, k;

            for (i = 0; i < dim; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < dim; i++)
            {
                k = i;
                for (j = i + 1; j < dim; j++)
                {
                    if (v[j] < v[k])
                        k = j;
                }
                Schimba(v, i, k);
            }

            Console.WriteLine("Vectorul sortat:");

            for (i = 0; i < dim; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
    }

        static void Schimba(int[] vector, int i1, int i2)
        {
            int temp = vector[i1];
            vector[i1] = vector[i2];
            vector[i2] = temp;
        }
}
