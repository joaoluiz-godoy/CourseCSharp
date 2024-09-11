using System;
using System.Collections.Generic;
using Ex_DinamicaDeClasses.Entities.Enums; //para usar o WorkerLevel

namespace Ex_DinamicaDeClasses.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; }


        //um worker pode ter vários contratos
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker() { }


        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = baseSalary;
            this.Department = department;
        } //lista dos contratos começa vazia

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary; //min à receber é o BaseSalary

            foreach(HourContract contract in this.Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

    }


}
