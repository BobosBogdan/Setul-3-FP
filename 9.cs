internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write(" Introduceti lungimea vectorului: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Lungime invalida.");
            return;
        }

        int[] vec = new int[n];
        CitesteVec(vec);

        Console.Write("Pozitii rotire stanga (k): ");
        if (!int.TryParse(Console.ReadLine(), out int k) || k < 0)
        {
            Console.WriteLine("Valoare k invalida.");
            return;
        }

        RotireStanga(vec, k);

        Console.WriteLine($"Vector rotit la stanga cu {k} pozitii:");
        AfiseazaVec(vec);
    }

    static void CitesteVec(int[] vec)
    {
        for (int i = 0; i < vec.Length; i++)
        {
            vec[i] = CitesteVal($"Element {i + 1}: ");
        }
    }

    static void RotireStanga(int[] vec, int k)
    {
        k = k % vec.Length;

        while (k > 0)
        {
            int primul = vec[0];

            for (int i = 0; i < vec.Length - 1; i++)
            {
                vec[i] = vec[i + 1];
            }

            vec[vec.Length - 1] = primul;
            k--;
        }
    }

    static void AfiseazaVec(int[] vec)
    {
        foreach (var el in vec)
        {
            Console.Write($"{el} ");
        }
        Console.WriteLine();
    }

    static int CitesteVal(string prompt)
    {
        int val;
        bool valid;
        do
        {
            Console.Write(prompt);
            valid = int.TryParse(Console.ReadLine(), out val);
            if (!valid)
            {
                Console.WriteLine("Valoare invalida. Reintroduceti.");
            }
        } while (!valid);

        return val;
    }
}
