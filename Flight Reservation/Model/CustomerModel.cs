using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.Model
{
    class CustomerModel : UserModel
    {
        public List <FlightModel> Flights;
        public List <PaymentModel> PaymentMethods;
        public List <TicketModel> Tickets;
        public CustomerModel()
        {
            User_Type = "Customer";
        }
    }
}
