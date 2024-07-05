using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course;
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public void IncreaseSalary(double percentage)
    {
        if (percentage < 1)
        {
            Salary *= (percentage + 1);
        }
        else { 
            Salary *= (1 + percentage / 100);
        }

    }

    public override string ToString()
    {
        return $"{Id}, {Name}, {Salary}";
    }
}
