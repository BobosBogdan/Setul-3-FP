using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int dimensiune = int.Parse(Console.ReadLine());

            int[] vOriginal = new int[dimensiune];

            for (int i = 0; i < dimensiune; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int element)) vOriginal[i] = element;               
                else
                {
                    Console.WriteLine("Introduceti un numar valid.");
                    i--;
                }
            }

            Console.Write("Introduceti indexul initial: ");
            if (int.TryParse(Console.ReadLine(), out int iInitial))
            {
                int result = ValoareSortata(vOriginal, iInitial);
                Console.WriteLine($"Valoarea cu intexul {iInitial} dupa sortare este: {result}");
            }
            else Console.WriteLine("Introduceti un index valid.");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"A aparut o exceptie: {ex.Message}");
        }
    }

    static int ValoareSortata(int[] v, int i)
    {
        int[] vClonat = (int[])v.Clone();
        Array.Sort(vClonat);

        int valDupaSortare = vClonat[i];
        return valDupaSortare;
    }
}
