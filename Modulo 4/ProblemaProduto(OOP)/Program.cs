using System;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();

        Console.WriteLine("Entre os dados do produto: ");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine());
        Console.Write("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados do produto: " + p);

        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qteA = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qteA);
        Console.WriteLine("Dados do produto: " + p);

        Console.Write("Digite o número de produtos a ser removido ao estoque: ");
        int qteR = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qteR);
        Console.WriteLine("Dados do produto: " + p);

    }
}