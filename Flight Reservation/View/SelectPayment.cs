using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight_Reservation.Model;
using Flight_Reservation.Controller;

namespace Flight_Reservation.View
{
    public partial class SelectPayment : Form
    {
        private CustomerModel existCustomer = new CustomerModel();
        private List<PaymentModel> Methods = new List<PaymentModel>();
        public int payid;
        public SelectPayment()
        {
            InitializeComponent();
        }

        internal CustomerModel ExistCustomer { get => existCustomer; set => existCustomer = value; }
        internal List<PaymentModel> Methods1 { get => Methods; set => Methods = value; }

        private void SelectPayment_Load(object sender, EventArgs e)
        {
            PaymentController Control = new PaymentController();
             Methods1 = Control.GetMyMethods(existCustomer);
            if (Methods1 != null)
            {


                comboBox1.DisplayMember = "Text";
                comboBox1.ValueMember = "Value";
                for (int i = 0; i < Methods1.Count; i++)
                {
                    String text = Methods1[i].CreditCard_Number+" "+ Methods1[i].CreditCard_Type;
                    comboBox1.Items.Add(new { Text = text, Value = i.ToString() });
                }
            }
            else
            {
                MessageBox.Show(Control.Message, "error", MessageBoxButtons.OK);
                this.Hide();

                Add_Payment_Method APM = new Add_Payment_Method();
                APM.ExistCustomer = existCustomer;
                APM.ShowDialog();

                SelectPayment select = new SelectPayment();
                select.ExistCustomer = existCustomer;
                select.ShowDialog();
                this.Close();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           payid = Methods[comboBox1.SelectedIndex].Payment_ID;
            System.IO.File.WriteAllText(@"D:\FCI\FCI 2018\Term 2\DataBase-1\Project\Phase 3\Flight Reservation\Flight Reservation\f.txt", payid.ToString());
            this.Close();
        }
    }
}
