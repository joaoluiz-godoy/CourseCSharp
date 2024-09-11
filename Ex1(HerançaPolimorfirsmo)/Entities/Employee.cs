using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_HerançaPolimorfirsmo_.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        
        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() { 
            return ValuePerHour * Hours; 
        }

        public override string ToString()
        {
            return $"{Name} - $ {this.Payment().ToString("F2")}";
        }

    }
}
