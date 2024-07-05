using System;

namespace Course;
class ExFor
{
    static void Main(string[] args)
    {
        Console.Write("Quantos números inteiros você vai digitar? ");
        int x = int.Parse(Console.ReadLine());

        int soma = 0;
        for (int i = 1; i <= x; i++)
        {
            Console.Write("Valor #{0}: ", i);
            int valor = int.Parse(Console.ReadLine());
            soma += valor;
        }

        Console.WriteLine("Soma = {0}", soma);
    }
}