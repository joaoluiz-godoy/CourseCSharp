using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_ExceçõesPersonalizadas.Entitiqes.Exceptions;

namespace Ex_ExceçõesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout < checkin)
            { 
                throw new DomainException("checkout não pode ser realizado antes do checkin");
            }

            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan t = CheckOut.Subtract(CheckIn);
            return (int)t.Days;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if (checkin < now || checkout < now)
            { //checkin de update não pode ser no passado, antes de hoje, muito menos o checkout

                throw new DomainException("checkin e checkout do update método não podem ser no passado");
            }
            else if (checkout < checkin)
            { //não pode sair antes de entrar

                throw new DomainException("checkout não pode ser realizado antes do checkin");
            }

            this.CheckIn = checkin;
            this.CheckOut = checkout;
        }

        public override string ToString()
        {
            return $"Reservation: Room {RoomNumber}, check-in: {CheckIn:dd/MM/yyyy}, check-out: {CheckOut:dd/MM/yyyy}, {Duration()} nights";
        }
    }
}
