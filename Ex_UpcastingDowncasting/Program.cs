using System;
using System.Net.Http.Headers;
using Ex_UpcastingDowncasting.Entities;

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1001, "Alex", 0.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

        //UPCASTING

        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

        //BusinessAccount bacc2 = acc2;
        //SavingsAccount sacc = new Account();

        //Ambos acima dão erro e não funcionam pois uma superclasse não é uma subclasse, por mais que o contrário seja verdadeiro.
        //Isso ocorre porque uma subclasse inclui ou contém o construtor, e seus attributos, da superclasse; cujo não acontece
        //na subclasse

        //DOWNCASTING

        BusinessAccount bacc2 = (BusinessAccount)acc2; //agora usando o casting, mutando o tipo do acc2 para sua subclasse equivalente
        bacc2.Loan(100.0);


        //EXCEÇÕES GERADA PELO DOWNCASTING

        //BusinessAccount bacc3 = (BusinessAccount)acc;
        //BusinessAccount bacc4 = (BusinessAccount)new Account();
        //BusinessAccount bacc5 = (BusinessAccount)acc3; // gera exceção após ser compilado pois acc3 foi construido por um SavingsAccount

        
        
        //para evitar essas exceções usar o is
        if (acc2 is BusinessAccount)
        {
            Console.WriteLine("BusinessAccount: " + acc2.ToString()); //está sem método toString criado então vai
            //mostrar direção do arquivo com classe definida. Ponto é mostrar método is. 
        }
        else if (acc1 is Account)
        {
            Console.WriteLine("Account: " + acc2.ToString());
        }
    }
}