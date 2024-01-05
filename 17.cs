using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti nr in baza 10: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Introduceti baza de conversie (2 <= b <= 16): ");
        int b = int.Parse(Console.ReadLine());

        if (b < 2 || b > 16) Console.WriteLine("Baza trebuie sa fie intre 2 si 16.");
        else
        {
            string result = ConvertToBase(n, b);
            Console.WriteLine($"Nr {n} in baza {b} este: {result}");
        }
    }

    static string ConvertToBase(int n, int b)
    {
        char[] cifra = "0123456789ABCDEF".ToCharArray();

        string result = "";

        while (n > 0)
        {
            int rest = n % b;

            result = cifra[rest] + result;

            n /= b;
        }

        return result;
    }
}
