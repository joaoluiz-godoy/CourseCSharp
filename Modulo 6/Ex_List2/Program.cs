using System;
using System.Runtime.ExceptionServices;

namespace Course;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("How many employees will be registred? ");
        int n = int.Parse(Console.ReadLine());

        List<Employee> list = new List<Employee>();
        for (int i = 0; i < n; i++)
        {
            Employee employee = new Employee();

            Console.WriteLine("Employee # " + (i + 1));
            Console.WriteLine("Id: ");
            employee.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: ");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Salary: ");
            employee.Salary = double.Parse(Console.ReadLine());

            list.Add(employee);

        }

        Console.Write("Enter the employee id that will have a salary inrease: ");
        int idRaise = int.Parse(Console.ReadLine());
        Console.Write("Enter the percentage: ");
        double perc = double.Parse(Console.ReadLine());

        Employee toBeFound = list.Find(X => X.Id == idRaise);

        if (toBeFound != null)
        {
            toBeFound.IncreaseSalary(perc);
        }
        else
        {
            Console.WriteLine("This id does not exist!");
        }

        foreach (Employee employee in list)
        {
            Console.WriteLine(employee);
        }

    }
}
