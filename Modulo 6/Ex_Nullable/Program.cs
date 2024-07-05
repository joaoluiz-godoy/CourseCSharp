using System;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        int? NullInt = null;
        int? NullInt2; //valor default null
        int? NullInt3 = 1;

        Func(NullInt3);

        //Func(NullInt2); não funciona pq NullInt2 não tem valor

        Func(NullInt);
        
    }

    public static int? Func(int? x)
    {
        if (x.HasValue) //gera uma excessão e erro se for null
        {
            Console.WriteLine(x.Value);
            return x.Value;
        }
        else
        {
            Console.WriteLine(x.GetValueOrDefault()); //vai pegar valor default do tipo int pois x nao tem value
            return null;
        }
    }
}
