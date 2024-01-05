using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti s1: ");
        string s1 = Console.ReadLine();

        Console.Write("Introduceti s2: ");
        string s2 = Console.ReadLine();

        int nrSuprap = NrSuprap(s1, s2);
        Console.WriteLine($"Numarul de suprapuneri este: {nrSuprap}");
    }

    static int NrSuprap(string s1, string s2)
    {
        int nrSuprapuneri = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            for (int j = 0; j < s2.Length && s1[RotireIndex(i, j, s1.Length)] == s2[j]; j++) nrSuprapuneri++;
        }

        return nrSuprapuneri;
    }

    static int RotireIndex(int i, int j, int lung)
    {
        return (i + j) % lung;
    }
}
