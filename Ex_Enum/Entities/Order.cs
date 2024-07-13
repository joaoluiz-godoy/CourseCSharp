using System;
using System.Threading.Tasks;

using Ex_Enum.Entities.Enums; //Lembre de Incluir como biblioteca quando for usar outras classes que vc criou

namespace Ex_Enum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; } //hora que pedido foi feito 
        public OrderStatus Status { get; set; } //status do order, PendingPayment, Processing, Shipped, Delivered

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
