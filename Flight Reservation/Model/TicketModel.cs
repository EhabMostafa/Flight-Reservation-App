using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.Model
{
    class TicketModel
    {
        public int Ticket_Number;
        public int Class;
        public decimal Price;
        public int Seat_Num;
        public FlightModel Flight;
        public PaymentModel Payment=new PaymentModel();
    }
}
