internal class Program
{
    private static void Main(string[] args)
    {
            Console.WriteLine("Introduceti elementele vectorului:");
            var lista = CitesteVector().ToList();

            Console.Write("Introduceti valoarea 'e' pe care doriti sa o inserati: ");
            int e = int.Parse(Console.ReadLine());

            Console.Write($"Introduceti pozitia 'k' unde doriti sa o inserati (0 <= k <= {lista.Count}): ");
            int k = int.Parse(Console.ReadLine());

            if (k >= 0 && k <= lista.Count)
            {
                lista.Insert(k, e);
                Console.WriteLine($"Vectorul dupa inserare: {string.Join(" ", lista)}");
            }
            else
            {
                Console.WriteLine("Pozitia e invalida.");
            }
    }

        static int[] CitesteVector()
        {
            string[] input = Console.ReadLine().Split();
            int[] vector = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                vector[i] = int.Parse(input[i]);
            }

            return vector;
        }
}
