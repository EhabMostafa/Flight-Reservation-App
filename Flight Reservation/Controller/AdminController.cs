using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Flight_Reservation.Model;

namespace Flight_Reservation.Controller
{
    class AdminController
    {
        public String Message;
        private SqlConnection Connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Flight_Reservation;Integrated Security=True");
        private SqlCommand Command = new SqlCommand();
        public bool AddNewAdmin(AdminModel NewAdmin)
        {

            String Query = "INSERT INTO [dbo].[USER]"
                         + "([USER_NAME]"
                         + ",[FIRST_NAME]"
                         + ",[SECOND_NAME]"
                         + ",[EMAIL]"
                         + ",[PASSWORD]"
                         + ",[GENDER]"
                         + ",[BIRTH_DATE]"
                         + ",[COUNTRY]"
                         + ",[USER_TYPE])";

            Query += "Values("
                  + "'" + NewAdmin.User_Name + "'" + ","
                  + "'" + NewAdmin.First_Name + "'" + ","
                  + "'" + NewAdmin.Second_Name + "'" + ","
                  + "'" + NewAdmin.Email + "'" + ","
                  + "'" + NewAdmin.Password + "'" + ","
                  + "'" + NewAdmin.Gender + "'" + ","
                  + "'" + NewAdmin.Birth_Date + "'" + ","
                  + "'" + NewAdmin.Country + "'" + ","
                  + "'" + NewAdmin.User_Type + "'" + ");";



            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
            Command.ExecuteNonQuery();
            Connection.Close();
            Message = "Added Suceesfully";
            return true;
        }

        public AdminModel GetExistAdmin(String UserName, String Password)
        {
            String Query = "Select * from [dbo].[USER] where [USER_TYPE] = 'Admin' and "
                         + "[USER_NAME] = " + "'" + UserName + "'"
                         + " and "
                         + "[PASSWORD] = " + "'" + Password + "';";



            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
            //Command.ExecuteNonQuery();

            bool Found = false;
            AdminModel Admin = new AdminModel();

            using (SqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Admin.User_Name = reader.GetString(0);
                    Admin.First_Name = reader.GetString(1);
                    Admin.Second_Name = reader.GetString(2);
                    Admin.Email = reader.GetString(3);
                    Admin.Password = reader.GetString(4);
                    Admin.Gender = reader.GetString(5);
                    Admin.Birth_Date = reader.GetDateTime(6);
                    Admin.Country = reader.GetString(7);
                    Found = true;
                }
            }
            Connection.Close();

            if (Found)
            {
                Message = "Found";
                return Admin;
            }

            Message = "Not Found";
            return null;

        }


        public bool update_adminDetails(AdminModel admin)
        {
            String query = "update [User] set " +
                          "first_Name = " + "'" + admin.First_Name + "'" +
                          " ,second_Name = " + "'" + admin.Second_Name + "'" +
                          " ,Email = " + "'" + admin.Email + "'" +
                          " ,Password = " + "'" + admin.Password + "'" +
                          " ,Gender = " + "'" + admin.Gender + "'" +
                           " ,Country = " + "'" + admin.Country + "'" +
                           " ,Birth_date = " + "'" + admin.Birth_Date + "'" +
                           " where User_Name = " + "'" + admin.User_Name + "'"; 



            

            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = query;
            Command.ExecuteNonQuery();
            Connection.Close();
            Message = "Admin data Updated successfully";
            return true;
        }
    }

}

