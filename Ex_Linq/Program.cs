using System.ComponentModel;
using System.Linq;
using Ex_Linq;

class Program
{
    static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);
        foreach (T item in collection) Console.WriteLine(item);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Specify the data source
        int[] numbers = new int[] { 2, 3, 4, 5 };

        //Define the query expression
        IEnumerable<int> result = numbers
            .Where(x => x % 2 == 0) //filter only pair
            .Select(x => x * 10); //then, multiply each by 10

        //Execute the query
        foreach (int n in result)
        {
            Console.WriteLine(n);
        }

        Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
        Category c2 = new Category() { Id = 1, Name = "Computers", Tier = 1 };
        Category c3 = new Category() { Id = 1, Name = "Electronics", Tier = 1 };

        IEnumerable<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
            new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
            new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3},
            new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
            new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1},
            new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
            new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3},
            new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3},
            new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
            new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
            new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1},
        };

        Console.WriteLine();

        //Filter where product's category is 1 and product's price < 900.0
        var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
        Print("TIER 1 AND PRICE < 900:", r1);

        var r1v2 = from p in products
                   where p.Category.Tier == 1 && p.Price < 900.0
                   select p;
        Print("SQL version, V2: TIER 1 AND PRICE < 900:", r1v2);

        //Filter where product's name is "Tools" and select only the product's name
        var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        Print("NAMES OF PRODUCTS FROM TOOLS", r2);

        var r2v2 =
            from p in products
            where p.Category.Name == "Tools"
            select p.Name;
        Print("SQL version, V2: NAMES OF PRODUCTS FROM TOOLS", r2v2);

        //Filter where product's name starts with 'C' and select only the product's
        var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new
        {
            p.Name,
            p.Price,
            CategoryName = p.Category.Name
        });
        Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

        var r3v2 =
            from p in products
            where p.Name[0] == 'C'
            select new
            {
                p.Name,
                p.Price,
                CategoryName = p.Category.Name
            };
        Print("SQL version, V2: NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3v2);

        var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
        Print("TIER 1 ORDERED BY PRICE THEN BY NAME", r4);

        var r4v2 =
            from p in products
            where p.Category.Tier == 1
            orderby p.Name
            orderby p.Price
            select p;
        Print("SQL version, V2: TIER 1 ORDERED BY PRICE THEN BY NAME", r4v2);

        var r5 = r4.Skip(2).Take(4);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

        var r5v2 =
            (from p in r4
             select p)
            .Skip(2)
            .Take(4);
        Print("SQL version, V2: TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5v2);

        var r6 = products.FirstOrDefault(); //poderia trocar por (from p in products select p).FirstOrDefault
        Console.WriteLine("First or default test1: " + r6);

        var r7 = products.Where(p => p.Price == 3000.0).FirstOrDefault();
        Console.WriteLine("First or default test2: " + r7);

        var r7v2 =
            (from p in products
             where p.Price > 3000.0
             select p).FirstOrDefault();
        Console.WriteLine("SQL version, V2: First or default test2: " + r7v2);
        Console.WriteLine();

        var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
        Console.WriteLine("Single or default test1: " + r8);

        var r9 = products.Where(p => p.Id == 30).SingleOrDefault(); //não existe Id == 30, então será default que
        Console.WriteLine("Single or default test2: " + r9);        //é um null
        Console.WriteLine();

        var r10 = products.Max(p => p.Price);
        Console.WriteLine("Max price: " + r10);

        var r11 = products.Min(p => p.Price);
        Console.WriteLine("Min Price: " + r11);

        var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
        Console.WriteLine("Category 1 Sun prices: " + r12);

        var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
        Console.WriteLine("Category 1 Aveg prices : " + r13);

        var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
        Console.WriteLine("Catefory 5 Average Prices: " + r14);

        var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
        Console.WriteLine("Category 1 aggregate sum: " + r15);
        Console.WriteLine();

        Console.WriteLine("Version of LINQ");
        var r16 = products.GroupBy(p => p.Category);
        foreach (IGrouping<Category, Product> group in r16)
        {
            Console.WriteLine("Category " + group.Key.Name + ":");
            foreach (Product p in group)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }

        Console.WriteLine("SQL Version, V2");
        var r16v2 =
            from p in products
            group p by p.Category;
        foreach (IGrouping<Category, Product> group in r16v2)
        {
            Console.WriteLine("Category " + group.Key.Name + ":");
            foreach (Product p in group)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }

        //AnonymousType
        var rX = new { Name = "Joao", KEOFKRF = 'C', Olho = 10 };
    }
}