internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int dim = int.Parse(Console.ReadLine());

            int[] vec = new int[dim];

            for (int i = 0; i < dim; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                vec[i] = int.Parse(Console.ReadLine());
            }

            olaSf(vec);

            Console.WriteLine("Rezultat:");

            for (int i = 0; i < dim; i++)
                Console.Write($"{vec[i]} ");
            Console.WriteLine();
    }
        static void olaSf (int[] vec)
        {
            int i = 0;
            int j = vec.Length - 1;

            while (i <= j)
            {
                if (vec[i] == 0)
                {
                    if (vec[j] != 0)
                    {
                        Schimb(vec, i, j);
                        i++;
                        j--;
                    }
                    else
                    {
                        j--;
                    }
                }
                else
                {
                    i++;
                }
            }
        }
        static void Schimb(int[] vec, int i1, int i2)
        {
            int temp = vec[i1];
            vec[i1] = vec[i2];
            vec[i2] = temp;
        }
}

           