using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_IComparable.Entites
{
    class Employee : IComparable //Quando uma classe implementa o IComparable, nós criamos uma regra de negócio, no método CompareTo que deixa um tipo 
                                 // dessa classe ser comparado com outro do mesmo tipo, ou de outros tipos.
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) //string pega de um file, separada por ',' que constroi um employee
        {
            string[] vet = csvEmployee.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1]);
        }

        public int CompareTo(object? obj) //por via da implementação do método, que tem sua signature na interface IComparable,
        {
            if (!(obj is Employee))
            {  //´para todos os tipos no qual obj não é do tipo employee
                throw new ArgumentException("Cannot compare Employee with " + obj.GetType());
            }

            Employee e = (Employee)obj;
            return this.Salary.CompareTo(e.Salary); //delega para o CompareTo método do tipo doublem que por sí, inherit o IComparable
        }
        public override string ToString()
        {
            return Name + ", " + Salary.ToString();
        }
    }

}