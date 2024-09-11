using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        HashSet<string> hashSet = new HashSet<string>();

        hashSet.Add("TV");
        hashSet.Add("Notebook");
        hashSet.Add("Tablet");

        Console.WriteLine(hashSet.Contains("Computer"));
        Console.WriteLine(hashSet.Contains("Tablet"));

        foreach (string p in hashSet)
        {
            Console.WriteLine(p);
        }

        //SortedSet e HashSet aceitam no seu construtor qualquer IEnumerable 
        SortedSet<string> strings = new SortedSet<string>(hashSet);
        HashSet<string> strings1 = new HashSet<string>(strings);

        SortedSet<int> sortedSet1 = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10};
        SortedSet<int> sortedSet2 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

        PrintCollection(sortedSet1);
        
        //union
        SortedSet<int> sortedSet3 = new SortedSet<int>(sortedSet1);
        sortedSet3.UnionWith(sortedSet2);
        PrintCollection(sortedSet3);

        //intersection
        SortedSet<int> sortedSet4 = new SortedSet<int>(sortedSet1);
        sortedSet4.IntersectWith(sortedSet2);
        PrintCollection(sortedSet4);


        //difference
        SortedSet<int> sortedSet5 = new SortedSet<int>(sortedSet1);
        sortedSet5.ExceptWith(sortedSet1);
        PrintCollection(sortedSet5);

        //importante usar os tipos de dados certos para cada problema, para que assim você possa facilitar e fazer de forma
        //mais rápida as operações que desejar. Caso quissese usar uma lista ai, seria mais difícil de implementar os union,
        //intersect e difference do que usar diretamente o HashSet e SortedSet

        HashSet<string> set = new HashSet<string>();
        set.Add("Maria");
        set.Add("Alex");

        Console.WriteLine(set.Contains("Maria"));

    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Console.WriteLine(item + " ");
        }

        Console.WriteLine();
    }

 }