using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea vectorilor: ");
        int n = int.Parse(Console.ReadLine());

        (int E, int W)[] vCombinat = new (int E, int W)[n];

        Console.WriteLine("Introduceti elementele E:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"E[{i}]: ");
            vCombinat[i].E = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Introduceti elementele W (ponderi):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"W[{i}] (ponderea pentru E[{i}]): ");
            vCombinat[i].W = int.Parse(Console.ReadLine());
        }

        Array.Sort(vCombinat, (x, y) =>
        {
            int compE = x.E.CompareTo(y.E);
            if (compE == 0) return y.W.CompareTo(x.W);

            return compE;
        });

        Console.WriteLine("Vectorii sortati:");

        foreach (var pair in vCombinat) Console.WriteLine($"E: {pair.E}, W: {pair.W}");
    }
}
