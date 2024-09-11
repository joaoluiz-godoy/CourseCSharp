using ExercíciosOOP;
using System;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo();

        Console.WriteLine("Entre a largura e altura do retângulo:");
        r.Altura = double.Parse(Console.ReadLine());
        r.Largura = double.Parse(Console.ReadLine());

        Console.WriteLine("AREA = " + r.Area().ToString("F2"));
        Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2"));
        Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2"));
    }
}