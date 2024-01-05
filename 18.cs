using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti gradul polinomului: ");
        int n = int.Parse(Console.ReadLine());

        double[] coefi = new double[n + 1];

        Console.WriteLine("Introduceti coeficientii polinomului, de la cel mai putin semnificativ la cel mai semnificativ:");
        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Coeficientul pentru x^{i}: ");
            coefi[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Introduceti valoarea punctului x: ");
        double x = double.Parse(Console.ReadLine());

        double rezultat = CalculValPol(coefi, x);

        Console.WriteLine($"Valoarea polinomului in punctul {x} este: {rezultat}");
    }

    static double CalculValPol(double[] coefi, double x)
    {
        double result = 0;

        for (int i = 0; i < coefi.Length; i++) result += coefi[i] * Math.Pow(x, i);

        return result;
    }
}
