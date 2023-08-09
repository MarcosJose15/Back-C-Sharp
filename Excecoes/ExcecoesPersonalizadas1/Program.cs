using System;
using ExcecoesPersonalizadas.Entities;
//using System.Collections.Generic;
//using System.Text;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Check-In date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-Out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            if (checkIn >= checkOut)
            {
                Console.WriteLine("Error in reservation: Check-Out date must be after check-In");
            }

            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("\nEnter data to update the reservation:");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                Console.WriteLine(now);

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("1-Error in reservation: Reservation dates for update must be future dates");
                }

                else if (checkIn >= checkOut)
                {
                    Console.WriteLine("2-Error in reservation: Reservation dates for update must be future dates");

                }

                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }

        }
    }
}
