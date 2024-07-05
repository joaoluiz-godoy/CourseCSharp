using System;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite número para gerar uma matriz de tamanho N, M[N,N], quadrada: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matriz = new int[N,N];

        int negNums = 0;
        int[] mainDiagonal = new int[N]; 

        Console.WriteLine($"Digite uma linha da matriz completa com separação de ' '"); //ideia é decompor input de uma linha

        for (int i = 0; i < N; i++)
        {
             string[] linhas = Console.ReadLine().Split(' '); 

            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = int.Parse(linhas[j]); //se n = 3. O loop do j vai completar j=0,j=1,j=2. Considerando
                //que j é coluna, vai preencher a linha pois o split vai gerar um vetor, array dos numeros. Ex: [10, 4, 2], os valores do
                //que vão ser pegos são: 10 depois 4 e 2. Portanto será atribuido. matriz[0,0] = 10, matriz[0,1] = 4 ...
                if (matriz[i, j] < 0)
                {
                    negNums++;
                }
            }

            mainDiagonal[i] = matriz[i, i]; //pois a diagonal principal será os valores de mesmo index, cujo tem de ser do tamanho 
            //da matriz
        }

        Console.WriteLine("Main diagonal: ");

        foreach (int i in mainDiagonal)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Negative numbers = " + negNums);

    }
}