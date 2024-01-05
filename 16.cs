using System;

class Program
{

    static int CalculCMMDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int VectorCMMDC(int[] v)
    {
        if (v.Length == 0) throw new ArgumentException("Vectorul nu poate fi gol.");

        int cmmdc = v[0];

        for (int i = 1; i < v.Length; i++) cmmdc = CalculCMMDC(cmmdc, v[i]);

        return cmmdc;
    }

    static void Main()
    {
        Console.Write("Introduceti lungimea: ");
        if (int.TryParse(Console.ReadLine(), out int lungime) && lungime > 0)
        {
            int[] v = new int[lungime];

            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introduceti nr natural {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int element) && element >= 0) v[i] = element;
                else
                {
                    Console.WriteLine("Introducere invalida. Introduceti un nr natural.");
                    i--;
                }
            }

            try
            {
                int rezultat = VectorCMMDC(v);
                Console.WriteLine($"Cel mai mare divizor comun al elementelor este: {rezultat}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else Console.WriteLine("Introducere invalida.");
    }
}
