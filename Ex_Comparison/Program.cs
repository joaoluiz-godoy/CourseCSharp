using Ex_Comparison;
using Ex_Delegates;
class Program
{
    delegate double BinaryNumericOperation(double n1, double n2); //criamos um delegate que recebe dois doubles e retorna dois doubles. Ou seja, qualquer método
                                                                  //que tenha essas propiedades pode ser atribuido à um tipo delegate BinaryNumericOperation

    delegate void BinaryNumericShowOperation(double n1, double n2); //outro delegate criado com intuito de mostrar como funciona os delegates multicast

    static void Main(string[] args)
    {

        double a = 10, b = 12;

        BinaryNumericOperation op = CalculationService.Sum; //também funciona BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum)
        Console.WriteLine(op(a, b));//também pode chamar op.Invoke(a,b) mas é a mesma ideia.



        List<Product> products = new List<Product>();
        products.Add(new Product("TV", 900.00));
        products.Add(new Product("Notebook", 1200.00));
        products.Add(new Product("Tablet", 450.00));

        Comparison<Product> compNames = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); //expressão lambda args => body of func
        products.Sort(compNames);
        foreach (Product p in products)
        {
            Console.WriteLine(p);
        }

        Comparison<Product> compPrices = ComparePrices;
        products.Sort(compPrices); //same as product.Sort(ComparePrices), lembrar que o Sort() tem várias implementações e algumas aceitam um tipo Comparison
        foreach (Product p in products)
        {
            Console.WriteLine(p);
        }

        //Se chamarmos o .Sort() sozinho o método usado para comparar será o CompareTo que foi overriden na classe Product. Nesse caso vai sort aleatoriamente
        //pois a comparação é feita via HashCode. Caso Product não implmentasse a interface IComparable e o método CompareTo, o .Sort() não funcionaria
        products.Sort();


        //Delegates mais comuns
        Action<int, string> actionWithParams = (x, y) => Console.WriteLine($"{x + 5}, {y + 5}"); //Action, void, faz uma ação
        actionWithParams(2, "a");
        products.ForEach(p => p.Price = p.Price * 0.9); //igual ao sort, o ForEach(Action<T>). Aceitando qualquer método void que seja equivalente ao Action<Product>.
                                                        //O p já é considerado um Product


        Func<int, int, int> add = (x, y) => x + y; //Func, retorna o último valor dado no parametro dos generics
        Console.WriteLine(add(2, 7));
        List<string> strings = products.Select(p => p.Name.ToUpper()).ToList(); //Select(Func<T>) assinatura: IEnumerable<TResult> IEnumerable<TSource>.Select(Func<TSource, TResult>)
                                                                    //Ou seja, dependendo do tipo dentro do enumerable apropiado no retorno e no tipo do enumerable chamado, o Func
                                                                    //aceito como parâmetro mudará. O select mudará para cada produto p, o que foi definido



        Predicate<Person> isAdult = p => p.Age >= 18; //Predicate, bool, muito usado para checar uma condição com o tipo dado
        Person person = new Person { Name = "John", Age = 20 };
        bool result = isAdult(person); // true
        products.RemoveAll(p => p.Price >= 100.0); //O RemoveAll(Predicate<T>) aceita qualquer delegate/método que tenha a mesma assinatura de um Predicate<Product>. 


        //Outros Delegates também usados 
        Converter<Person, int> personHashCode = p => p.GetHashCode();
        Converter<Person, string> personToString = p => p.ToString(); //O método ToString() pode ser apropiado como um delegate Converter<Person, string> por ex.


        //Multicast Delegates
        BinaryNumericShowOperation op2 = CalculationService.ShowSum;
        op2 += CalculationService.ShowMax;
        op(a, b); //vai executar métodos na ordem em que foram adicionados.
    }

    static int ComparePrices(Product p1, Product p2)
    {
        return p1.Price.CompareTo(p2.Price);
    }


}