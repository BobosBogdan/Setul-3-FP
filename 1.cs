internal class Program
{
    private static void Main(string[] args)
    {

            Console.WriteLine("Introduceti lungimea vectorului: ");
            int lungime;

            while (!int.TryParse(Console.ReadLine(), out lungime) || lungime <= 0)
            {
                Console.WriteLine("Introduceti o valoare valida si pozitiva pentru lungimea vectorului.");
            }

            int[] vector = CitesteVector(lungime);
            int suma = CalcSuma(vector);

            Console.WriteLine($"Suma elementelor vectorului este: {suma}");
        }

        static int[] CitesteVector(int lungime)
        {
            int[] vector = new int[lungime];

            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");

                while (!int.TryParse(Console.ReadLine(), out vector[i]))
                {
                    Console.WriteLine("Introduceti o valoare valida pentru elementul vectorului.");
                }
            }

            return vector;
        }

        static int CalcSuma(int[] vector)
        {
            int suma = 0;

            foreach (int element in vector)
            {
                suma += element;
            }

            return suma;
        }
}
