using System;
using System.IO;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {

        string path = @"C:\code\Curso\Directory";

        try
        {
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //*.*, qualquer nome de arquivo qualquer extensão dentro do folder no path. SearchOption.AllDirectories vai listar todas as
            //subpastas, incluindo a atual. O Directory.EnumerateDirectories é um método da classe Directory que Enumera todas as pastas
            //dentro de um directory e retorna um IEnumerable, nesse caso, o specificamos do tipo generic string

            Console.WriteLine("FOLDERS: ");
            foreach (string item in folders)
            {
                Console.WriteLine(item);
            }

            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

            Console.WriteLine("FILES: ");
            foreach (string item in files)
            {
                Console.WriteLine(item);
            }


            Directory.CreateDirectory(path + @"\newFolder"); //sempre incluir o @ no inicio do string para determinar que ele não é
            //um string comum e sim um path de folder/nome. Se não toda \ terá de ser \\.
            //Directory.CreateDirectory -> cria nova pasta. No caso a concatenação das strings path e \newFolder vão criar uma pasta
            //chamada newFolder pois no caminho path não existe uma dessa. Caso já exista uma pasta naqule nome e local, nada acontecerá.

        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occured: ");
            Console.WriteLine(ex.Message);
        }


    }

}