using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        Console.WriteLine("Introduceti elementele vectorului:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elem {i}: ");
            v[i] = int.Parse(Console.ReadLine());
        }

        int major = gasesteMajor(v);

        if (EsteMajor(v, major)) Console.WriteLine($"Elem majoritar: {major}");
        else Console.WriteLine("Nu exista");

    }

    static int gasesteMajor(int[] v)
    {
        int candidat = v[0];
        int contor = 1;

        for (int i = 1; i < v.Length; i++)
        {
            if (contor == 0)
            {
                candidat = v[i];
                contor = 1;
            }
            else if (v[i] == candidat) contor++;
            else contor--;

        }

        return candidat;
    }

    static bool EsteMajor(int[] v, int candidat)
    {
        int contor = 0;

        foreach (var element in v)
        {
            if (element == candidat)
                contor++;
        }

        return contor > v.Length / 2;
    }
}
