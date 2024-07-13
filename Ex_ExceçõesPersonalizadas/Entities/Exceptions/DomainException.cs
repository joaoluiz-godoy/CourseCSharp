using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_ExceçõesPersonalizadas.Entitiqes.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
        
    }
}
