using System;
using Ex_IComparable.Entites;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\code\Curso\Ex_IComparable.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }
                
                list.Sort();//.Sort usará o método compareTo para ordernar as os Employees corretamente. Caso não houvesse uma herança do
                            //IComparable, o .Sort não saberia como comparar pois ele usa o Compare to do tipo dentro da list, o Employee
                foreach (Employee e in list)
                {
                    Console.WriteLine(e);
                }

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}