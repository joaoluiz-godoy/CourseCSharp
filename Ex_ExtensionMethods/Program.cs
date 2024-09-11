using System; //Não precisa adicionar pq o complilador já vem com o system

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teste Extension Method ElapsedTime do DateTime
            DateTime dt = new DateTime(2018, 12, 16, 8, 10, 45);
            DateTime dt2 = new DateTime(2024, 6, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            Console.WriteLine(dt2.ElapsedTime());

            //Teste Extension Method Cut do String
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}