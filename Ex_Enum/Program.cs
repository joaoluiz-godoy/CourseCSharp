using System;
using Ex_Enum.Entities; //library para usar o Order
using Ex_Enum.Entities.Enums; //libary para usar OrderStatus

namespace Course;

class Program
{
    static void Main(string[] args)
    {

        Order order = new Order
        {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PENDING_PAYMENT
        };

        Console.WriteLine(order);


        //De tipo Enum -> String
        string txt = OrderStatus.PENDING_PAYMENT.ToString();
        Console.WriteLine(txt);


        //De String -> Enum
        OrderStatus os = Enum.Parse<OrderStatus>("DELIVERED"); //String tem que estar compativel com alguma das opções
        //do enum, ou, vai raise uma excessão
        Console.WriteLine(os);


    }
}