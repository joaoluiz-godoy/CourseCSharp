using System;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        ContaBancária conta;
        
        Console.Write("Entre o número da conta:");
        int numConta = int.Parse(Console.ReadLine());
        
        Console.Write("Entre o titular da conta:");
        string titular = Console.ReadLine();
        
        
        Console.Write("Haverá depósito inicial (s/n)?");
        char depoInicial = char.Parse(Console.ReadLine());
        
        conta = new ContaBancária(numConta, titular); 
        
        Console.WriteLine();

        if (depoInicial == 's')
        {
            Console.Write("Entre um valor de depósito inical: ");
            double valor = double.Parse(Console.ReadLine());
            conta.depósito(valor);
        }

        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(conta.ToString());
        Console.WriteLine();

        Console.Write("Entre um valor para depósito: ");
        double valor2 = double.Parse(Console.ReadLine());
        conta.depósito(valor2);

        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta.ToString());
        Console.WriteLine();

        Console.Write("Entre um valor para saque: ");
        double valor3 = double.Parse(Console.ReadLine());
        conta.saque(valor3);

        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(conta.ToString());
    }
}