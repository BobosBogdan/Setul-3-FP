using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti dimensiunea v1: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] v1 = new int[n1];

        Console.WriteLine("Introduceti elementele v1:");
        for (int i = 0; i < n1; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            v1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nIntroduceti dimensiunea v2: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] v2 = new int[n2];

        Console.WriteLine("Introduceti elementele v2:");
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            v2[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(v1);
        Array.Sort(v2);

        int[] dupaInter = Intersectie(v1, v2);

        Console.WriteLine("\nDupa intersectie rezultatul este:");
        foreach (int num in dupaInter) Console.Write(num + " ");
    }

    static int[] Intersectie(int[] v1, int[] v2)
    {
        int[] result = new int[v1.Length + v2.Length];

        int i = 0, j = 0, k = 0;

        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] < v2[j]) result[k++] = v1[i++];
            else result[k++] = v2[j++];
        }

        while (i < v1.Length) result[k++] = v1[i++];
 
        while (j < v2.Length) result[k++] = v2[j++];

        return result;
    }
}
