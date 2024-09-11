using Ex1_HerançaPolimorfirsmo_.Entities;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        List<Employee> list = new List<Employee>(); //precisa inciar se não, valor será nulo e não vai
        //conseguir adicionar valores à lista

        for (int i = 1; i <= n; i++)
        { //para usar i como index, começando no employee 1, não 0
            Console.WriteLine($"Employee #{i} data : ");
            Console.Write("Outsourced (y/n)?");



            char outSourcedYN = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine());

            if (outSourcedYN == 'y')
            {
                Console.Write("Additional charge: ");
                double addCharge = double.Parse(Console.ReadLine());

                OutsourcedEmployee outEmployee = new OutsourcedEmployee(name, hours, valuePerHour, addCharge);
                list.Add(outEmployee);
            }
            else
            {
                Employee employee = new Employee(name, hours, valuePerHour);
                list.Add(employee);
            }



        }

        Console.WriteLine();
        Console.WriteLine("PAYMENTS:");
        foreach (Employee e in list)
        {
            Console.WriteLine(e); //ToString(), por behind, transforma em string pra print
        }


    }
}