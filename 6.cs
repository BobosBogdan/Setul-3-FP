internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Introduceti lungimea vectorului: ");
        int n = int.Parse(Console.ReadLine());

        float[] array = new float[n];
        CitesteVec(array);

        Console.Write("Introduceti pozitia k de la care doriti sa stergeti elementul: ");
        int k = int.Parse(Console.ReadLine()) - 1; 

        if (PozValida(k, n))
        {
            StergeElem(array, ref n, k);

            Console.Write("Noua ordine a elementelor vectorului: ");
            AfisVect(array, n);
        }
        else
        {
            Console.WriteLine($"Pozitia introdusa este inexistenta ");
        }
    }

    static void CitesteVec(float[] vector)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = float.Parse(Console.ReadLine());
        }
    }

    static bool PozValida(int pozitie, int lungime)
    {
        return pozitie >= 0 && pozitie < lungime;
    }

    static void StergeElem(float[] vector, ref int lungime, int pozitie)
    {
        for (int i = pozitie + 1; i < lungime; i++)
        {
            vector[i - 1] = vector[i];
        }

        lungime--;
    }

    static void AfisVect(float[] vector, int lungime)
    {
        for (int i = 0; i < lungime; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }
}
