using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea: ");
        int lungVec = Convert.ToInt32(Console.ReadLine());

        int[] v = new int[lungVec];

        Console.WriteLine("Introduceti elementele:");

        for (int i = 0; i < lungVec; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            v[i] = Convert.ToInt32(Console.ReadLine());
        }

        v = EliminaDuplicate(v);

        Console.WriteLine("Vectorul dupa eliminare:");
        foreach (var element in v)
        {
            Console.Write(element + " ");
        }
    }

    static int[] EliminaDuplicate(int[] v)
    {
        HashSet<int> elementeUnice = new HashSet<int>();
        List<int> vFiltrat = new List<int>();

        foreach (var element in v)
        {
            if (elementeUnice.Add(element))
            {
                vFiltrat.Add(element);
            }
        }

        return vFiltrat.ToArray();
    }
}
