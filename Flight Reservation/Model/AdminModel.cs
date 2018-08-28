using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.Model
{
    class AdminModel : UserModel
    {
        public List <FlightModel> Flights;
        public List<AirCraftModel> Planes;
        public AdminModel()
        {
            User_Type = "Admin";
        }
    }
}
