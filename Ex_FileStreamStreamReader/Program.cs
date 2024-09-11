using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\code\Curso\Ex_FileManipulation.txt";
        //inicia ambos tipos stream 

        //FileStream fs = null;  
        StreamReader sr = null;

        try
        {
            //Jeito 1 de fazer
            //fs = new FileStream(path, FileMode.Open); == igual à File.OpenRead(path);
            //sr = new StreamReader(fs); //viabiliza lermos o arquivo path

            //Jeito 2 de fazer mesma ação, com menos linhas.
            sr = File.OpenText(path);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine(); //le apenas uma linha, a primeira
                Console.WriteLine(line);
            }
        }

        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }

        finally
        {
            if (sr != null) sr.Close(); //caso qualquer uma das variaveis seja dif de null, feche os arquivos pois deixa-los aberto
                                        //pode gerar um problema nos dados

            //if (fs != null) fs.Close(); parou de existir no jeito 2
        }
    }
}