using System;

namespace Course
{
    //Ex, receber entrada de dados na mesma linha, de diferentes tipos, e printalas nos tipos corretos
    class Program
    {
        static void Main(string[] args)
        {
            //Nome Idade H/M altura
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int idade = int.Parse(vet[1]);
            char sexo = char.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine(name + ' ' + idade + ' ' + sexo + ' ' + altura);


        }
    }
}