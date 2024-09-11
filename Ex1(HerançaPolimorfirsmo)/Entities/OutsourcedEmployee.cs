using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_HerançaPolimorfirsmo_.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge {  get; set; }

        public OutsourcedEmployee() { }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1; //tercerizados recebem correspondente de 110% de sua
            //despesa adicional
        }
    }
}
