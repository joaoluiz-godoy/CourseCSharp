using System;
using System.Data;
using System.Runtime.InteropServices;
using Ex2_Generics_.Entities;
using Ex2_Generics_.Services;
class Program
{
    static void Main(string[] args)
    {
        //Teste para mostrar que compilador da erro se o T não for um IComparable

        A a = new A(); //tipo A, não faz nada, calsse vazia
        CalculationService service = new CalculationService(); //cria CalculationService
        List<A> list = new List<A>(); //Lista<A> para passar como lista para função max
        list.Add(a); //Add uma var para a lista

        //ERRO ABAIXO:
        //service.Max<A>(list); gera erro pois A não implementa IComparable, que significa que não é possivel fazer uma comparação
        //entre tipos A

        A instancia = service.Func<A>(a); //por outro lado, a função Func, aceita qualquer tipo como parametro
        Console.WriteLine(instancia); //vai imprimir location para a classe A


        //Função em uso
        List<Product> listProducts = new List<Product>();
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] vect = Console.ReadLine().Split(',');
            Product p = new Product(vect[0], double.Parse(vect[1]));
            listProducts.Add(p);
        }

        CalculationService calculation = new CalculationService();

        Product max = calculation.Max(listProducts); //não é necessário chamar o método com o Max<Product>,
                                                     //só conferir que Product implementa um IComparable

        Console.WriteLine("Max: ");
        Console.WriteLine(max);
       
    }
}