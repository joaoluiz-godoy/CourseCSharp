using System;

namespace Course;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nome do Aluno");
        Console.WriteLine("Digite três notas do aluno");

        Aluno a = new Aluno();
        a.nota1 = double.Parse(Console.ReadLine());
        a.nota2 = double.Parse(Console.ReadLine());
        a.nota3 = double.Parse(Console.ReadLine());

        a.CalcFinal();
        Console.WriteLine("NOTA FINAL = " + a.notaFinal);

        if (a.Passou())
        {
            Console.WriteLine("APROVADO");
        }
        else
        {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM " + a.FaltouPontos().ToString("F2") + "PONTOS");
        }
    }
}