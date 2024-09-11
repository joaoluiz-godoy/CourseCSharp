using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string path = @"C:\code\Curso\Ex_FileManipulation";
        Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); //no windows é o '\', que separa o caminho do arquivos
        Console.WriteLine("PathSeparator: " + Path.PathSeparator); //no windows é o ';', que separa diferentes paths. Cada arquivo ou pasta
        //tem um path, que são separados pelo ';'. Ex: "C:\Diretorio1;C:\Diretorio2", representando dois paths dif
        Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); //pega pasta aonde file está
        Console.WriteLine("GetFileName: " + Path.GetFileName(path)); //pega nome do file
        Console.WriteLine("GetExtension: " + Path.GetExtension(path)); //pega extensão do file
        Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));//pega nome sem extensão
        Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); //pega path completo
        Console.WriteLine("GetTempPath: " + Path.GetTempPath()); //pega path com user, local e esses directories

    }
}
