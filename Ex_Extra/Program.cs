using System;
using Ex_Extra.Entities;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Defina o tamanho da lista de ints random:");
        int N = int.Parse(Console.ReadLine());
        Func FMediaMaisMenos = new Func();

        //achar media, maior valor de freq e menor valor de freq com valores random(entre 1 e 15)
        double mediaRand;
        List<int> AparacemMaisRand, AparecemMenosRand;
        FMediaMaisMenos.MediaMaisMenosRandom(N, out mediaRand, out AparacemMaisRand, out AparecemMenosRand);
        FMediaMaisMenos.PrintMediaMaisMenos(mediaRand, AparacemMaisRand, AparecemMenosRand);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        double media;
        List<int> AparacemMais, AparecemMenos;
        FMediaMaisMenos.MediaMaisMenos(new List<int>() { 1, 2, 2, 3, 3}, out media, out AparacemMais,
            out AparecemMenos);
        FMediaMaisMenos.PrintMediaMaisMenos(media, AparacemMais, AparecemMenos);
    }
}