using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight_Reservation.Controller;
using Flight_Reservation.Model;

namespace Flight_Reservation.View
{
    public partial class Add_Payment_Method : Form
    {
        private CustomerModel existCustomer = new CustomerModel();

        internal CustomerModel ExistCustomer { get => existCustomer; set => existCustomer = value; }
        public Add_Payment_Method()
        {
            InitializeComponent();
        }

        private void Add_Payment_Method_Load(object sender, EventArgs e)
        {
            
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            PaymentModel NewPayment = new PaymentModel();
            NewPayment.CreditCard_Number = Number_TextBox.Text;
            NewPayment.CreditCard_Type = Type_TextBox.Text;
            NewPayment.CreditCard_Bank = Bank_TextBox.Text;
            NewPayment.CreditCard_ExpiredDate = EXP_Time.Value;

            PaymentController Control = new PaymentController();
            bool IsAdded = Control.AddNewPayment(NewPayment, existCustomer);
            if (IsAdded)
            {
                MessageBox.Show(Control.Message, "Information", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                if (MessageBox.Show(Control.Message, "Error", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                {
                    this.Close();
                }
            }

        }
    }
}
