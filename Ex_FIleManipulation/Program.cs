using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\code\Curso\Ex_FileManipulation.txt";
            string targetPath = @"C:\code\Curso\Ex_FileManipulation2.txt";


            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);//fileInfo recebe o file no local do sourcePath
                fileInfo.CopyTo(targetPath); //com isso, chamo a função na instância para copiar oq foi escrito lá no targetPath
                //caso um arquivo com o nome ja exista, o CopyTo vai dar erro.

                string[] lines = File.ReadAllLines(sourcePath); //nenhum arquivo instanciado por estar usando file, portanto, terá de
                //passar para o método o file que será lido

                foreach (var str in lines)
                {
                    Console.WriteLine(str);
                }


            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}