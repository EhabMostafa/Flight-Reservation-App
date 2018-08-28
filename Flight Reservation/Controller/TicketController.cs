using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.Model;

namespace Flight_Reservation.Controller
{
    
    class TicketController
    {
        public String Message;
        private SqlConnection Connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Flight_Reservation;Integrated Security=True");
        private SqlCommand Command = new SqlCommand();

        public bool BookTickets(int payid,int flightModelID,String Username)
        {
            String Query = "select * from TICKET where Payment_id is null and FLIGHT_ID = " + flightModelID.ToString();
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
            int ticketid = -1;
            using (SqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read())
                {

                    ticketid = reader.GetInt32(0);
                }
            }

            if (ticketid == -1)
            {
                Message = "Sorry This Flight Is Complete";
                return false;
            }

            String Query2 = "UPDATE [dbo].[TICKET]"
                                 + " SET [PAYMENT_ID] = " + payid.ToString()
                                 + " where Ticket_Number = " + ticketid.ToString();
            SqlCommand Command2 = new SqlCommand();
            Command2.Connection = Connection;
            Command2.CommandText = Query2;

            Command2.ExecuteNonQuery();


            String Query3 = "insert into [dbo].[reserve] "
                                 + " values ( '" + Username + "' ,"
                                 +  flightModelID.ToString() + ")";
            SqlCommand Command3 = new SqlCommand();
            Command3.Connection = Connection;
            Command3.CommandText = Query3;

            Command3.ExecuteNonQuery();


            Message = "Book Succefully";
            Connection.Close();
            return true;


            
        }

        public bool AddTickets(FlightModel flight,int seat)
        {
            String Query = "INSERT INTO [dbo].[ticket] ";

            Query += " Values ( "
                    + flight.Flight_ID + ", null , 1 , 3000 , " + seat.ToString()+" ) ;";
                 
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
            Command.ExecuteNonQuery();
            Connection.Close();
            Message = "Added Suceesfully";
            return true;
        }
       List<TicketModel> GetMyTickets(String UserName)
        {
            return null;
        }
        public bool RemoveTicket(FlightModel flight,String username)
        {
            String Query = "DELETE FROM [dbo].[RESERVE] where flight_id = "
                        + flight.Flight_ID + " and user_name = '" + username + "'";

            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;

            Command.ExecuteNonQuery();

            Query = "delete from  [dbo].[ticket]  where Ticket_number = "
                       + flight.Ticktes[0].Ticket_Number ;

           
            Command.Connection = Connection;
            Command.CommandText = Query;

            Command.ExecuteNonQuery();
            Connection.Close();

            Message = "Removed Successfull";
            return true;
        }

    }
}
