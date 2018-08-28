using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.Model
{
    class PaymentModel
    {
        public int Payment_ID;
        public String CreditCard_Number;
        public String CreditCard_Type;
        public String CreditCard_Bank;
        public DateTime CreditCard_ExpiredDate;
        public List <CustomerModel> Customers;
        public List <TicketModel> Tickets;
    }
}
