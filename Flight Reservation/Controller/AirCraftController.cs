using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.Model;

namespace Flight_Reservation.Controller
{
    class AirCraftController
    {
        public String Message;
        private SqlConnection Connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Flight_Reservation;Integrated Security=True");
        private SqlCommand Command = new SqlCommand();

        public bool update_Aircraft(AirCraftModel aircraft)
        {
            String query = "update [AIRCRAFT] set " +

                          " Model = " + "'" + aircraft.Model + "'" +
                          " ,Color= " + "'" + aircraft.Color + "'" +
                          " ,Capacity = "  + aircraft.Capacity + 
                           " where AirCRAFT_ID= " + "" + aircraft.AirCraft_ID + "";





            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = query;
            Command.ExecuteNonQuery();
            Connection.Close();
            Message = "aircraft data Updated successfully";
            return true;
        }

        public bool AddNewAircraft(AirCraftModel NewAircraft)
        {

            String Query = "INSERT INTO [dbo].[AIRCRAFT]";
                     
            Query += " Values("
                  + "'" + NewAircraft.Model + "'" + ","
                  + "'" + NewAircraft.Color + "'" + ","
                  + "'" + NewAircraft.Capacity + "'" + ");";
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
            Command.ExecuteNonQuery();
            Connection.Close();
            Message = "Added Suceesfully";
            return true;
        }
        public List <AirCraftModel> GetAll()
        {
            String Query = "Select * from [dbo].[aircraft] ";
                        



            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
            //Command.ExecuteNonQuery();
            List<AirCraftModel> all = new List<AirCraftModel>();
            using (SqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read())
                {
                    AirCraftModel air = new AirCraftModel();

                    air.AirCraft_ID = reader.GetInt32(0);
                    air.Model = reader.GetString(1);
                    air.Color = reader.GetString(2);
                    air.Capacity = reader.GetInt32(3);
                    all.Add(air);
                }
            }
            Connection.Close();
            if (all.Count == 0)
            {
                Message = "Not Found";
                return null;
            }
            

            
            return all;


        }
       
    }
}
