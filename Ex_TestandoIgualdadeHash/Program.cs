using Ex_TestandoIgualdadeHash.Entities;

using System.Collections.Generic;
using Ex_TestandoIgualdadeHash.Entities;


class Program
{
    static void Main(string[] args)
    {
        HashSet<Product> a = new HashSet<Product>();
        a.Add(new Product("TV", 900.0));
        a.Add(new Product("Notebook", 1200.0));
        
        HashSet<Point> b = new HashSet<Point>();
        b.Add(new Point(3, 4));
        b.Add(new Point(5, 10));
        
        Product prod = new Product("Notebook", 1200.0); //veja que no hash tem um produto com as mesmas
        Console.WriteLine(a.Contains(prod)); //info do prod, porém, após usar o contains para search, o
        //resultado é false, pois a referência do prod na memória é diferente da ref do Produto no Hash a.
        //Motivo é que o Product é uma classe, que tem como default a comparação por ref, até que, os
        //métodos de GetHashCode() e Equals(object other) sejam overriden.



        Point point = new Point(5, 10); //veja que para o Point algo diferente acontece. Quando o contains
        Console.WriteLine(b.Contains(point)); //verifica se o point está dentro do Hash b e retorna true.
        //Diferente de tipos ref, uma struct, tipo valor, tem como default a comparação por valores e não
        //pela ref na memória.

    }
}
