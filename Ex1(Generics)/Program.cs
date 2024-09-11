using Ex1_Generics_.Entities;
using System;

class Program
{
    static void Main(string[] args)
    {
        PrintService<int> printService = new PrintService<int>();
        Console.WriteLine("How many values? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            printService.AddValue(x);

        }

        printService.Print();
        Console.WriteLine("First " + printService.First()); //Método First retorna o primeiro item da, definido no PrintService
    }
}