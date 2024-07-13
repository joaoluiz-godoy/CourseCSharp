using System;

namespace Course;
class Program
{
    static void Main(string[] args)
    {
        double preco = double.Parse(Console.ReadLine());

        double desconto;
        //caso normal com o if-else

        if (preco < 20.0)
        {
            desconto = preco * 0.1;
        }
        else
        {
            desconto = preco * 0.05;
        }

        double desconto2 = (preco < 20.0) ? preco * 0.1 : preco * 0.05; //mesma coisa do if-else mas resumido em uma linha 
    }



   
}