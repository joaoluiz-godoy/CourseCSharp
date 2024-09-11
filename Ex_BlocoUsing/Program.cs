using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string path = @"C:\code\Curso\Ex_FileManipulation.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream) //enquanto não for o EndOfStream
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}