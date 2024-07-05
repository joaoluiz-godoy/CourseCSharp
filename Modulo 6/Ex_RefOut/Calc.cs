using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course;

public class Calc
{
    public void Dividir(int nume, int div, out int result, out int resto)
    {
        result = nume/div;
        resto = nume%div;
    }

    public void Triple(ref int x)
    {
        x *= 3;
    }
}