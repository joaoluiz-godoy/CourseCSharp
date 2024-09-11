using System;
using System.Security.Cryptography.X509Certificates;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        
        Calc c = new Calc();

        //Uso do método Div
        Console.WriteLine("Vamos usar o método Div, favor inserir valores de numerador e divisor");
        Console.WriteLine("Favor seguir a ordem acima separando os valores de inteiro por ,");

        int dividendo = int.Parse(Console.ReadLine());
        int divisor = int.Parse(Console.ReadLine());
        int result, resto; //apenas sendo instanciados

        c.Dividir(dividendo, divisor, out result, out resto); //nos espaços de out, as var result e resto vão armazenar as respostas

        //Uso do método Triple
        int num = 3;
        c.Triple(ref num); //parametro do Triple tem que ser uma ref da var para que seja possível altera-lá diretamente. Não sua cópia

    }
}
