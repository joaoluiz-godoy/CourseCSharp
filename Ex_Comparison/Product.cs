namespace Ex_Comparison
{
    class Product : IComparable<Product>
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

        public int CompareTo(Product? other)
        {
            return this.GetHashCode().CompareTo(other.GetHashCode);
        }
        
    }
}
