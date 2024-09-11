using System;

namespace Course;

class ExWhile
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine());

        while (num >= 0.0)
        {
            Console.WriteLine(Math.Sqrt(num).ToString("F3"));
            Console.Write("Digite outro número: ");
            num = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Número negativo!");

    }
}
