using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.Model
{
    class FlightModel
    {
        public int Flight_ID;
        public String Departure_Place;
        public String Landing_Place;
        public DateTime Departure_Date;
        public DateTime Landing_Date;
        public String Flight_Type;
        public List <CustomerModel> Passengers;
        public List <AdminModel> Admins;
        public AirCraftModel Plane=new AirCraftModel();
        public List <TicketModel> Ticktes=new List<TicketModel>();
    }
}
