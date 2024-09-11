using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_HerançaMultipla.Devices
{
    abstract class Device
    {
        public int SerialNumber;

        public abstract void ProcessDoc(string doc);
    }
}
