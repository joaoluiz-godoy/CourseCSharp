using System;
using Ex_GetHashCode_Equals.Entities;
class Program
{
    static void Main(string[] args)
    {

        Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
        Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };
        Client c = new Client { Name = "Joao", Email = "alex@gmail.com" };

        Console.WriteLine(a.Equals(b));
        Console.WriteLine(a.GetHashCode()); //lembrar que, a cada compilação, o HashCode vai mudar
        Console.WriteLine(b.GetHashCode());
        Console.WriteLine(b.Equals(c)); //comparação por email, portanto, são iguais

        Console.WriteLine(b.GetHashCode().Equals(c.GetHashCode())); //compara ambos HashCode() que serão iguais
                                                                    //pois o HashCode() pego é o do Email e ambos
                                                                    //emails são iguais

        Console.WriteLine(b == c); //Baseado na lógica do Equals, deveriam ser iguais, mas, já que a comparação é
                                   //feita por referência de ponteiro de memória do objeto, o == não consegue
                                   //seguir apropiadamente as regras de tipos definidos


        //Veja que para tipos do system o == funciona bem, porém para tipos definidos, não
        int n1 = 2, n2 = 2; 
        Console.WriteLine(n1 == n2);
        
        Console.WriteLine("A" == "A"); 

        string q = "q", q2 = "q"; 
        Console.WriteLine(q == q2);

    }
}