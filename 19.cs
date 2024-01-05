using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea s: ");
        int n = int.Parse(Console.ReadLine());

        int[] s = new int[n];
        Console.WriteLine("Introduceti elementele s:");
        for (int i = 0; i < n; i++) s[i] = int.Parse(Console.ReadLine());

        Console.Write("Introduceti lungimea p: ");
        int m = int.Parse(Console.ReadLine());

        int[] p = new int[m];
        Console.WriteLine("Introduceti elementele p:");
        for (int i = 0; i < m; i++) p[i] = int.Parse(Console.ReadLine());

        int contor = Contor(s, p);
        Console.WriteLine($"Vectorul p apare in vectorul s de {contor} ori.");
    }

    static int Contor(int[] s, int[] p)
    {
        int contor = 0;

        if (s.Length < p.Length) return 0;

        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            bool x = true;

            for (int j = 0; j < p.Length; j++)
            {
                if (s[i + j] != p[j])
                {
                    x = false;
                    break;
                }
            }

            if (x) contor++;
        }

        return contor;
    }
}
