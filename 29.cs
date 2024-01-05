using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea: ");
        int lungimeV = int.Parse(Console.ReadLine());

        int[] v = new int[lungimeV];

        Console.WriteLine("Introduceti elementele: ");

        for (int i = 0; i < lungimeV; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            v[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVectorul nesortat:");
        Afisare(v);

        MergeSort(v, 0, v.Length - 1);

        Console.WriteLine("\nVectorul sortat:");
        Afisare(v);
    }

    static void MergeSort(int[] v, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;

            MergeSort(v, stanga, mijloc);
            MergeSort(v, mijloc + 1, dreapta);

            Interclasare(v, stanga, mijloc, dreapta);
        }
    }

    static void Interclasare(int[] v, int stanga, int mijloc, int dreapta)
    {
        int n1 = mijloc - stanga + 1;
        int n2 = dreapta - mijloc;

        int[] vStanga = new int[n1];
        int[] vDreapta = new int[n2];

        Array.Copy(v, stanga, vStanga, 0, n1);
        Array.Copy(v, mijloc + 1, vDreapta, 0, n2);

        int i = 0, j = 0, k = stanga;

        while (i < n1 && j < n2)
        {
            if (vStanga[i] <= vDreapta[j])
            {
                v[k] = vStanga[i];
                i++;
            }
            else
            {
                v[k] = vDreapta[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            v[k] = vStanga[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            v[k] = vDreapta[j];
            j++;
            k++;
        }
    }

    static void Afisare(int[] v)
    {
        foreach (var element in v) Console.Write(element + " ");
        Console.WriteLine();
    }
}
