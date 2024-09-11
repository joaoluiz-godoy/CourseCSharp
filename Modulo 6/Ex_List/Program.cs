using System;
using System.Data;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Anna");

        list.Insert(2, "Marco");

        foreach (string s in list)
        {
            Console.WriteLine(s);
        }

        string s1 = list.Find(X => X[0] == 'A'); //Função Lambda: parametros => função
        Console.WriteLine("Primeiro com A " + s1);

        string s2 = list.FindLast(X => X[0] == 'A');
        Console.WriteLine("Ultimo com A " + s2);

        int pos1 = list.FindIndex(X => X[0] == 'A');
        Console.WriteLine("Pos primeiro com A " + pos1);

        int pos2 = list.FindLastIndex(X => X[0] == 'A');
        Console.WriteLine("Pos ultimo com A " + pos1);

        List<string> listFiltrada = list.FindAll(X => X.Length == 5); // so Maria e Marco

        Console.WriteLine("Lista filtrada por nomes com 5 letras ");

        foreach (string s in listFiltrada)
        {
            Console.Write(s + " ");
        };


        list.Remove("Alex");

        Console.WriteLine();
        foreach (string s in list)
        {
            Console.Write(s + " ");
        };


        list.RemoveAll(X => X[0] == 'M'); //remove Maria e Marcos
        Console.WriteLine();
        foreach (string s in list)
        {
            Console.Write(s + " ");
        };

        list.Insert(2, "Marco"); //reinsert Marco
        list.RemoveAt(2);//remove Marco denovo

        //list.RemoveRange(1, 1); start at index = 1, count = 3, ande 3





    }
}