using System;

namespace Course;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Quantos Produtos?");
        int n = int.Parse(Console.ReadLine());

        Product[] vectProducts = new Product[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Produto " + i + ": ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Valor: ");
            double price = double.Parse(Console.ReadLine());
            vectProducts[i] = new Product { Name = name, Price = price };
        }

        double sum = 0.0;
        for (int i = 0; i < n; i++)
        {
            sum += vectProducts[i].Price;
        }

        double avg = sum/n;

        Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2"));



    }

}