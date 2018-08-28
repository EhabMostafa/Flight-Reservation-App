using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Flight_Reservation.Model;
namespace Flight_Reservation.Controller
{
    class FlightController
    {

        public String Message;
        private SqlConnection Connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Flight_Reservation;Integrated Security=True");
        private SqlCommand Command = new SqlCommand();

        public List<FlightModel> search(String query)
        {
            List<FlightModel> flights = new List<FlightModel>();

            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = query;
            using (SqlDataReader reader = Command.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        FlightModel Flight = new FlightModel();
                        Flight.Flight_ID = reader.GetInt32(0);
                        Flight.Plane.AirCraft_ID = reader.GetInt32(1);
                        Flight.Departure_Place = reader.GetString(2);
                        Flight.Landing_Place = reader.GetString(3);
                        Flight.Departure_Date = reader.GetDateTime(4);
                        Flight.Landing_Date = reader.GetDateTime(5);
                        Flight.Flight_Type = reader.GetString(6);
                        flights.Add(Flight);
                    }
                    return flights;
                }
                else
                {
                    Message = "Not found";
                }
            }
            Connection.Close();
            return null;




        }


        public bool AddNewflight(FlightModel Newflight)
        {

            String Query = "INSERT INTO [dbo].[FLIGHT] ";

            Query += " Values ( "
                    + Newflight.Plane.AirCraft_ID  + ","
                  + "'" + Newflight.Departure_Place + "'" + ","
                  + "'" + Newflight.Landing_Place + "'" + ","
                  + "'" + Newflight.Departure_Date + "'" + ","
                  + "'" + Newflight.Landing_Date + "'" + ","
                  + "'" + Newflight.Flight_Type + "'" + ");";
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
           Command.ExecuteNonQuery();
            Connection.Close();
            Message = "Added Suceesfully";
            return true;
        }

        public int GetflightID()
        {
            int num = 0;
            String Query = "SELECT TOP 1 * FROM Flight_Reservation.dbo.FLIGHT ORDER BY FLIGHT_ID DESC";

            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
            using (SqlDataReader reader = Command.ExecuteReader())
            {


                while (reader.Read())
                {
                    num = reader.GetInt32(0);
                }
            }
                    Connection.Close();
            
            return num;
        }

        public List<FlightModel> GetMyFlights(String Username)
        {
            List<FlightModel> flights = new List<FlightModel>();

            String Query = "select * from FLIGHT,TICKET,[USER],OWN "
                          +" where FLIGHT.FLIGHT_ID = TICKET.FLIGHT_ID"
                          +" and OWN.[USER_NAME]=[User].[USER_NAME]"
                          +" and own.PAYMENT_ID=TICKET.PAYMENT_ID"
                          +" and [User].[USER_NAME]= '"+Username+"'"
                          +" and [own].[USER_NAME]= '" + Username + "'";





            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;

            
           

            using (SqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read())
                {
                    FlightModel fl = new FlightModel();
                    fl.Flight_ID = reader.GetInt32(0);
                    fl.Departure_Place = reader.GetString(2);
                    fl.Landing_Place = reader.GetString(3);

                    TicketModel tk = new TicketModel();
                    tk.Ticket_Number = reader.GetInt32(7);
                    tk.Payment.Payment_ID = reader.GetInt32(9);
                    tk.Class = reader.GetInt32(10);
                  tk.Price = reader.GetDecimal(11);
                    tk.Price = reader.GetInt32(12);

                    fl.Ticktes.Add(tk);
                    flights.Add(fl);
                    
                }
            }




            Connection.Close();
            if (flights.Count == 0)
            {
                return null;
            }
            return flights;
        }

    }


}
