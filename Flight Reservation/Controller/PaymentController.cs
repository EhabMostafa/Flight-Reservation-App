using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.Model;

namespace Flight_Reservation.Controller
{
    class PaymentController
    {
        public String Message;
        private SqlConnection Connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Flight_Reservation;Integrated Security=True");
        private SqlCommand Command = new SqlCommand();

        public bool AddNewPayment(PaymentModel NewPayment, CustomerModel existCustomer)
        {

            if (IsNewPayment(NewPayment))
            {

                String Query = "INSERT INTO [dbo].[PAYMENT]"
                             + "([CREDITCARD_NUMBER]"
                             + ",[CREDITCARDT_TYPE]"
                             + ",[CREDITCARD_BANK]"
                             + ",[CREDITCARD_EXPIREDDATE])";


                Query += "Values("
                      + "'" + NewPayment.CreditCard_Number + "'" + ","
                      + "'" + NewPayment.CreditCard_Type + "'" + ","
                      + "'" + NewPayment.CreditCard_Bank + "'" + ","
                      + "'" + NewPayment.CreditCard_ExpiredDate + "'" + ");";




                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = Query;
                Command.ExecuteNonQuery();
                Connection.Close();

                IsNewPayment(NewPayment);
                

            }

            if (Isexist(NewPayment, existCustomer))
            {
                Message = "Duplicate Credit Card";
                return false;
            }

            String Query2 = "INSERT INTO [dbo].[own]"
                            + "([USER_NAME]"
                            + ",[PAYMENT_ID]) ";
                            


            Query2 += "Values("
                  + "'" + existCustomer.User_Name + "'" + ","
                   + NewPayment.Payment_ID + ");";

            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query2;
           Command.ExecuteNonQuery();
            Connection.Close();
            Message = "Added Suceesfully";

            return true;

        }

        private bool IsNewPayment(PaymentModel NewPayment)
        {


            String Query = "select * from [dbo].[PAYMENT] where ";
           
            Query +=       "[CREDITCARD_NUMBER] = " + "'" + NewPayment.CreditCard_Number + "'"
                         + " and "
                         + "[CREDITCARDT_TYPE] = " + "'" + NewPayment.CreditCard_Type + "'"
                         + " and "
                         + "[CREDITCARD_BANK] = " + "'" + NewPayment.CreditCard_Bank + "'"
                         + " and "
                         + "[CREDITCARD_EXPIREDDATE] = " + "'" + NewPayment.CreditCard_ExpiredDate + "';";



            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;

            using (SqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read())
                {
                    NewPayment.Payment_ID = reader.GetInt32(0);
                    Connection.Close();
                    return false;
                }
            }


            Connection.Close();
            Message = "Added Suceesfully";
            
            return true;
        }


        private bool Isexist(PaymentModel NewPayment, CustomerModel existCustomer)
        {


            String Query = "select * from [dbo].[OWN] where ";

            Query += "[USER_NAME] = " + "'" + existCustomer.User_Name + "'"
                         + " and "
                         + "[PAYMENT_ID] = " + NewPayment.Payment_ID + ";";




            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;

            using (SqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Connection.Close();
                    return true;
                }
            }


            Connection.Close();
            Message = "Added Suceesfully";

            return false;
        }


        public List<PaymentModel> GetMyMethods( CustomerModel existCustomer)
        {


            String Query = "select * from [dbo].[OWN] where ";

            Query += "[USER_NAME] = " + "'" + existCustomer.User_Name + "';";




            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;

            List<int> IDS = new List<int>();
            List<PaymentModel> Methods = new List<PaymentModel>();

            using (SqlDataReader reader = Command.ExecuteReader())
            {
                while (reader.Read())
                {
                   IDS.Add( reader.GetInt32(1));
                }
            }

           


            Connection.Close();
            if (IDS.Count == 0)
            {
                Message = "You Dont Have Payment Methods";
                return null;
            }

            Message = "";
            for (int i = 0; i < IDS.Count; i++)
            {
                Methods.Add(GetPaymentDetails(IDS[i]));
            }

            return Methods;
        }

        private PaymentModel GetPaymentDetails(int paymentID)
        {
            PaymentModel pay = new PaymentModel();

            String Query = "select * from [dbo].[payment] where ";

            Query += "[payment_id] = "  + paymentID.ToString() + ";";




            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = Query;
            
            using (SqlDataReader reader2 = Command.ExecuteReader())
            {
                while (reader2.Read())
                {
                    pay.Payment_ID = reader2.GetInt32(0);
                    pay.CreditCard_Number = reader2.GetString(1);
                    pay.CreditCard_Type = reader2.GetString(2);
                    pay.CreditCard_Bank = reader2.GetString(3);
                    pay.CreditCard_ExpiredDate = reader2.GetDateTime(4);
                }
            }

            Connection.Close();
            
            return pay;
        }
    }
}
