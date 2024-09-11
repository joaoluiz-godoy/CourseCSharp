using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sobreposição.Entities
{
    class Arvore : Planta
    {
        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("Barulho de folhas");
        }
    }
}
