using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_HerançaMultipla.Devices
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
           Console.WriteLine("Print processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print: " + document);
        }
    }
}
