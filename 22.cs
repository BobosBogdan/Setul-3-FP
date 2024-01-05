using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Elementele se vor separa prin virgulă.");
        int[] v1 = CitesteV("Introduceti elementele din v1: ");
        int[] v2 = CitesteV("Introduceti elementele din v2: ");

        var intersectie = Intersectie(v1, v2);
        Console.WriteLine("Intersectie: " + string.Join(", ", intersectie));

        var reuniune = Reuniune(v1, v2);
        Console.WriteLine("Reuniune: " + string.Join(", ", reuniune));

        var difV1V2 = Diferenta(v1, v2);
        var difV2V1 = Diferenta(v2, v1);

        Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", difV1V2));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", difV2V1));
    }

    static int[] CitesteV(string msg)
    {
        Console.Write(msg);
        string i = Console.ReadLine();
        return i.Split(',').Select(int.Parse).ToArray();
    }

    static IEnumerable<T> Intersectie<T>(T[] v1, T[] v2)
    {
        var set1 = new HashSet<T>(v1);
        var set2 = new HashSet<T>(v2);
        set1.IntersectWith(set2);
        return set1;
    }

    static IEnumerable<T> Reuniune<T>(T[] v1, T[] v2)
    {
        var set1 = new HashSet<T>(v1);
        var set2 = new HashSet<T>(v2);
        set1.UnionWith(set2);
        return set1;
    }

    static IEnumerable<T> Diferenta<T>(T[] v1, T[] v2)
    {
        var set1 = new HashSet<T>(v1);
        var set2 = new HashSet<T>(v2);
        var diferenta = new HashSet<T>(set1);
        diferenta.ExceptWith(set2);
        return diferenta;
    }
}
