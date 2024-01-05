using System;
using System.Collections.Generic;

class Program
{
    static List<int> ConvtLaCifre(string nr)
    {
        List<int> cif = new List<int>();
        for (int i = nr.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(nr[i])) cif.Add(nr[i] - '0');
            else throw new ArgumentException("Input invalid. Introduceti doar cifre.");
        }
        return cif;
    }

    static List<int> Adunare(List<int> nr1, List<int> nr2)
    {
        List<int> result = new List<int>();
        int transport = 0;

        for (int i = 0; i < Math.Max(nr1.Count, nr2.Count); i++)
        {
            int cif1 = (i < nr1.Count) ? nr1[i] : 0;
            int cif2 = (i < nr2.Count) ? nr2[i] : 0;

            int suma = cif1 + cif2 + transport;
            result.Add(suma % 10);
            transport = suma / 10;
        }

        if (transport > 0) result.Add(transport);

        return result;
    }

    static List<int> Scadere(List<int> nr1, List<int> nr2)
    {
        List<int> result = new List<int>();
        int imprumut = 0;

        for (int i = 0; i < nr1.Count; i++)
        {
            int cif1 = nr1[i];
            int cif2 = (i < nr2.Count) ? nr2[i] : 0;

            int diferenta = cif1 - cif2 - imprumut;

            if (diferenta < 0)
            {
                diferenta += 10;
                imprumut = 1;
            }
            else imprumut = 0;

            result.Add(diferenta);
        }

        while (result.Count > 1 && result[result.Count - 1] == 0) result.RemoveAt(result.Count - 1);

        return result;
    }

    static List<int> Inmulteste(List<int> nr1, List<int> nr2)
    {
        List<int> result = new List<int>(new int[nr1.Count + nr2.Count]);

        for (int i = 0; i < nr1.Count; i++)
        {
            int transport = 0;

            for (int j = 0; j < nr2.Count || transport > 0; j++)
            {
                int prod = result[i + j] + (i < nr1.Count ? nr1[i] : 0) * (j < nr2.Count ? nr2[j] : 0) + transport;
                result[i + j] = prod % 10;
                transport = prod / 10;
            }
        }

        while (result.Count > 1 && result[result.Count - 1] == 0) result.RemoveAt(result.Count - 1);

        return result;
    }

    static void Main()
    {
        try
        {
            Console.Write("Introduceti primul nr: ");
            string i1 = Console.ReadLine();
            List<int> nr1 = ConvtLaCifre(i1);

            Console.Write("Introduceti al doilea nr: ");
            string it2 = Console.ReadLine();
            List<int> nr2 = ConvtLaCifre(it2);

            List<int> sum = Adunare(nr1, nr2);
            Console.WriteLine("Suma: " + string.Join("", sum));

            List<int> dif = Scadere(nr1, nr2);
            Console.WriteLine("Diferența: " + string.Join("", dif));

            List<int> prod = Inmulteste(nr1, nr2);
            Console.WriteLine("Produsul: " + string.Join("", prod));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Eroare: " + ex.Message);
        }
    }
}
