using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Generics_.Services
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price;
        }

        public int CompareTo(object? obj) //lógica de comparação entre Products será pelo preço
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not a type Product");
            }

            Product other = (Product)obj;
            return Price.CompareTo(other.Price);
        }
    }
}
