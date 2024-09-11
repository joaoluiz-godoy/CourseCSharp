using Ex_DinamicaDeClasses.Entities.Enums;
using Ex_DinamicaDeClasses.Entities;
using System;
using System.Diagnostics;
using System.Transactions;
using Ex_DinamicaDeClasses;

class Program
{

    static void Main(string[] args)
    {

        Console.Write("Enter the department`s name: ");
        string dept = Console.ReadLine();

        //create new department
        var department = new Department(dept);

        Console.WriteLine("Enter Worker data: ");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Level (Junior/Mid_Level/Senior) in CAPS: ");
        WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine()); //convert string -> enum

        Console.Write("Base Salary: ");
        double baseSalary = double.Parse(Console.ReadLine());

        //create new Worker
        var worker = new Worker(name, workerLevel, baseSalary, department);

        Console.Write("How many contracts to this worker? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) //para o #i não começar no 0
        {
            Console.WriteLine($"Enter #{i} contract data: ");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime d = DateTime.Parse(Console.ReadLine());

            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine());

            Console.Write("Duration (hours): ");
            int duration = int.Parse(Console.ReadLine());

            //create new HourContract
            var hourContract = new HourContract(d, valuePerHour, duration);

            //Add contract to list of contracts
            worker.AddContract(hourContract);
        }

        Console.Write("Enter the month and year to calculate income (MM/YYYY): ");
        DateTime d2 = DateTime.Parse(Console.ReadLine());
        Console.Write(d2);

        string month = d2.Month.ToString();
        string year = d2.Year.ToString();

        double income = worker.Income(int.Parse(year), int.Parse(month));

        Console.WriteLine($"Name: {worker.Name} \n" + // \n cria linha nova
            $"Department: {worker.Department} \n" +
            $"Income for {month}/{year}: {income}");

    }

}