using Ex_Sobreposição.Entities;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Cachorro cachorro = new Cachorro();
        Arvore arvore = new Arvore();

        animal.EmitirSom(); //vai mostrar override em action por conta do virtual
        Console.WriteLine();
        cachorro.EmitirSom(); //ideia é no método overriden, de primeiro chamar
                              //a implementação base e depois acresentar uma fala

        Console.WriteLine();
        cachorro.ClasseBaseSom(); //vai mostrar mesmo print, pois método não virtual
        animal.ClasseBaseSom();

        Console.WriteLine();
        Console.WriteLine("------------diferentes superclasses---------------");

        cachorro.EmitirSom(); //motivo para ter adicionado a chamada de suas respectivas
        Console.WriteLine();//implementações via base é para identificar a superclasse

        arvore.EmitirSom();
    }
}