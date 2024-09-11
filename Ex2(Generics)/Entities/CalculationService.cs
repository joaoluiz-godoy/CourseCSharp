using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Generics_.Entities
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable //lista será de um tipo T qualquer, desde que o tipo T seja
                                                            //IComparable. Ou seja, a função Max so poderá ser utilizado quando o
                                                            //tipo T implementar o IComparable. Assim, garantindo, usar o método do
                                                            //compareTo. Caso T não implementar IComparable, o compilador vai dar
                                                            //erro na hora de chamar a função
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }

            }

            return max;
        }

        public T Func<T>(T max)
        {
            return max;

        }

    }

    class A
    {
        public A() { }

    }
}
