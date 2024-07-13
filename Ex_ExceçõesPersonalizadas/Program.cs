using System;
using Ex_ExceçõesPersonalizadas.Entities;
using Ex_ExceçõesPersonalizadas.Entitiqes;
using Ex_ExceçõesPersonalizadas.Entitiqes.Exceptions;

namespace Ex_ExceçõesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int roomNumber;
                DateTime checkIn, checkOut;

                Console.Write("Room number: ");
                roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation.ToString());

                Console.WriteLine("Enter data to update the reservation:");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime newCheckIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime newCheckOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                reservation.UpdateDates(newCheckIn, newCheckOut);
                Console.WriteLine(reservation.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error in reservation: Invalid date format.");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
