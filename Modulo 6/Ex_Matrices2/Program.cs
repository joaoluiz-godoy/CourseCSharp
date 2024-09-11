using System;

namespace Couse;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please give values of M, rows, and N, columns ");
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        int[,] mat = new int[M, N];

        Console.WriteLine("Favor insira uma linha da matriz, separada por ' ' ");

        for (int i = 0; i < M; i++) //vai repetir num de rows apenas
        {
            string[] linhas = Console.ReadLine().Split(' ');

            for (int j = 0; j < N; j++)
            {
                mat[i, j] = int.Parse(linhas[j]);
            }
        }


        Console.WriteLine("Favor inserir numero na matriz que deseja encontrar os dados");
        int find = int.Parse(Console.ReadLine());

        for (int i2 = 0; i2 < M; i2++)
        {
            for (int j2 = 0; j2 < N; j2++)
            {
                if (mat[i2, j2] == find)
                {
                    Console.WriteLine($"Position: {i2}, {j2}");

                    //Left
                    if (j2 > 0) //se j=0, valor ta no max esquerda, ent sem valores mais a esquerda
                        Console.WriteLine($"Left: {mat[i2, j2 - 1]}");//se na pos 1,1. Left so muda o column, j-1, 1,0

                    //Right
                    if (j2 < N-1) //se j=N-1 (pois começa do index 0), max column),
                                  //valor ta no max direita, ent sem valores mais a direita
                        Console.WriteLine($"Right: {mat[i2, j2 + 1]}");//portanto right será j+1

                    //Up
                    if (i2 > 0) //se i=0, valor ta no topo, ent sem valores acima
                        Console.WriteLine($"Up: {mat[i2 - 1, j2]}");//up mexe i-1 no row, pois menor o i mais alto ta o valor

                    //Down
                    if (i2 < M-1) //se i=M-1 (pois começa do index 0), valor ta no bottom, ent sem valores mais abaixo
                        Console.WriteLine($"Down: {mat[i2 + 1, j2]}");//com isso, down é i+1
                }
            }
        }
    }

}