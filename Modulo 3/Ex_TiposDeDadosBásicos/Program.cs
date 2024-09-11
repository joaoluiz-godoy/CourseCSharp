using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            sbyte x = 100;
            byte n1 = 126;
            long n2 = 79836479264L;
            bool completo = false;
            char gender = 'M';
            char letra = '\u0041';
            object obj1 = "Joao"; //String
            object obj2 = 2.5f; //Float
            object obj3 = 3; //int

            Console.WriteLine(completo);
            Console.WriteLine(letra);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);

            //Achar Min/Max value dos tipos
            int min = int.MinValue;
            Console.WriteLine(min);
            float max = float.MaxValue;
            Console.WriteLine(max);
        }
    }
}