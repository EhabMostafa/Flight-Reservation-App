using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Flight_Reservation.Model;

namespace Flight_Reservation.Controller
{
    class CustomerController
    {
        public String Message;
        private SqlConnection Connection= new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Flight_Reservation;Integrated Security=True");
        private SqlCommand Command=new SqlCommand();
        public bool AddNewCustomer(CustomerModel NewCustomer){

            

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
                  + "'" + NewCustomer.User_Name + "'" + ","
                  + "'" + NewCustomer.First_Name + "'" + ","
                  + "'" + NewCustomer.Second_Name + "'" + ","
                  + "'" + NewCustomer.Email + "'" + ","
                  + "'" + NewCustomer.Password + "'" + ","
                  + "'" + NewCustomer.Gender + "'" + ","
                  + "'" + NewCustomer.Birth_Date + "'" + ","
                  + "'" + NewCustomer.Country + "'" + ","
                  + "'" + NewCustomer.User_Type + "'" + ");";



            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
            Command.ExecuteNonQuery();
            Connection.Close();
            Message = "Added Suceesfully";
            return true;
        }

        public CustomerModel GetExistCustomer(String UserName,String Password)
        {
            String Query = "Select * from [dbo].[USER] where [USER_TYPE] = 'Customer' and "
                         + "[USER_NAME] = " + "'" + UserName + "'"
                         + " and "
                         + "[PASSWORD] = " + "'" + Password + "';";



            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
           // Command.ExecuteNonQuery();

            bool Found=false;
            CustomerModel Customer = new CustomerModel();

            using (SqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Customer.User_Name = reader.GetString(0);
                    Customer.First_Name = reader.GetString(1);
                    Customer.Second_Name = reader.GetString(2);
                    Customer.Email = reader.GetString(3);
                    Customer.Password = reader.GetString(4);
                    Customer.Gender = reader.GetString(5);
                    Customer.Birth_Date = reader.GetDateTime(6);
                    Customer.Country = reader.GetString(7);
                    Found = true;
                }
            }
            Connection.Close();

            if (Found)
            {
                Message = "Found";
                return Customer;
            }

            Message = "Not Found";
            return null;

        }



        public bool update_CustomerDetails(CustomerModel customer)
        {
            String query = "update [User] set " +
                          "first_Name = " + "'" + customer.First_Name + "'" +
                          " ,second_Name = " + "'" + customer.Second_Name + "'" +
                          " ,Email = " + "'" + customer.Email + "'" +
                          " ,Password = " + "'" + customer.Password + "'" +
                          " ,Gender = " + "'" + customer.Gender + "'" +
                           " ,Country = " + "'" + customer.Country + "'" +
                           " ,Birth_date = " + "'" + customer.Birth_Date + "'" +
                           " where User_Name = " + "'" + customer.User_Name + "'";





            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = query;
            Command.ExecuteNonQuery();
            Connection.Close();
            Message = "customer data Updated successfully";

            return true;
        }
    }
}
