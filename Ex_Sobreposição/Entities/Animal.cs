using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sobreposição.Entities
{
    public class Animal
    {
        public Animal() { }
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som genérico de animal");
        }

        public void ClasseBaseSom()
        {
            Console.WriteLine("Sou um tipo animal");
        }
    }
}
