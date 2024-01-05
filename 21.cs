using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Elementele/Sirurile vor fi separate prin spatiu.");
        Console.WriteLine("Introduceti primul vector de siruri:");
        string i1 = Console.ReadLine();
        string[] v1 = i1.Split(' ');

        Console.WriteLine("Introduceți al doilea vector de siruri:");
        string i2 = Console.ReadLine();
        string[] v2 = i2.Split(' ');

        int comparare = ComparareLexi(v1, v2);

        if (comparare < 0) Console.WriteLine("Vectorul 1 apare primul în ordine lexicografica.");

        else if (comparare > 0) Console.WriteLine("Vectorul 2 apare primul în ordine lexicografica.");

        else Console.WriteLine("Vectorii sunt egali în ordine lexicografica.");
    }

    static int ComparareLexi(string[] v1, string[] v2)
    {
        for (int i = 0; i < Math.Min(v1.Length, v2.Length); i++)
        {
            int comparare = v1[i].CompareTo(v2[i]);
            if (comparare != 0) return comparare;
        }

        return v1.Length.CompareTo(v2.Length);
    }
}
