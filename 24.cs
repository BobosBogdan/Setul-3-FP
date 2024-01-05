using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Elementele se vor separa prin virgula.");
        Console.WriteLine("Elementele se vor reprezenta ca vectori cu valori binare (1 sau 0).");
        bool[] v1 = CitesteV("Introduceti elementele din v1: ");
        bool[] v2 = CitesteV("Introduceti elementele din v2: ");

        var intersectie = Intersectie(v1, v2);
        Console.WriteLine("Intersectie: " + string.Join(", ", intersectie.Select(b => b ? 1 : 0)));

        var reuniune = Reuniune(v1, v2);
        Console.WriteLine("Reuniune: " + string.Join(", ", reuniune.Select(b => b ? 1 : 0)));

        var difV1V2 = Diferenta(v1, v2);
        var difV2V1 = Diferenta(v2, v1);

        Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", difV1V2.Select(b => b ? 1 : 0)));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", difV2V1.Select(b => b ? 1 : 0)));
    }

    static bool[] CitesteV(string msg)
    {
        Console.Write(msg);
        string input = Console.ReadLine();
        return input.Split(',').Select(x => x.Trim() == "1").ToArray();
    }

    static IEnumerable<bool> Intersectie(bool[] v1, bool[] v2)
    {
        return v1.Zip(v2, (a, b) => a && b);
    }

    static IEnumerable<bool> Reuniune(bool[] v1, bool[] v2)
    {
        return v1.Zip(v2, (a, b) => a || b);
    }

    static IEnumerable<bool> Diferenta(bool[] v1, bool[] v2)
    {
        return v1.Zip(v2, (a, b) => a && !b);
    }
}
