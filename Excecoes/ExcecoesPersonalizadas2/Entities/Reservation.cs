using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace ExcecoesPersonalizadas2.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(now);

            if (checkIn < now || checkOut < now)
            {
                return "1-Error in reservation: Reservation dates for update must be future dates";
            }

            if (checkIn >= checkOut)
            {
                return "2-Error in reservation: Reservation dates for update must be future dates";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null; //Irá indicar que nao aconteceu erro.
        }

        public override string ToString()
        {
            return "Room "
            + ", check-In: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", check-Out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights";
        }
    }
}