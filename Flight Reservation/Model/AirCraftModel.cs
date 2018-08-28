using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.Model
{
    class AirCraftModel
    {
        public int AirCraft_ID;
        public String Model;
        public String Color;
        public int Capacity;
        public List<AdminModel> Admins;
        public List <FlightModel> Flights;
    }
}
