using System;

class QuickSort
{
    static void Main()
    {
        Console.Write("Introduceti lungimea: ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        Console.WriteLine("Introduceți elementele: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            v[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVectorul nesortat:");
        afisare(v);

        SortRapid(v, 0, v.Length - 1);

        Console.WriteLine("\nVectorul sortat:");
        afisare(v);
    }

    static void SortRapid(int[] v, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            int iPartitie = partitie(v, stanga, dreapta);

            SortRapid(v, stanga, iPartitie - 1);
            SortRapid(v, iPartitie + 1, dreapta);
        }
    }

    static int partitie(int[] v, int stanga, int dreapta)
    {
        int p = v[dreapta];
        int i = stanga - 1;

        for (int j = stanga; j < dreapta; j++)
        {
            if (v[j] < p)
            {
                i++;
                schimbaElem(v, i, j);
            }
        }

        schimbaElem(v, i + 1, dreapta);
        return i + 1;
    }

    static void schimbaElem(int[] v, int i, int j)
    {
        int temp = v[i];
        v[i] = v[j];
        v[j] = temp;
    }

    static void afisare(int[] v)
    {
        foreach (var element in v) Console.Write(element + " ");
        Console.WriteLine();
    }
}
