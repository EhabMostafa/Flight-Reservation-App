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
namespace Flight_Reservation.View
{
    public partial class CustomerHomePage : Form
    {
        private CustomerModel existCustomer = new CustomerModel();

        internal CustomerModel ExistCustomer { get => existCustomer; set => existCustomer = value; }

        public CustomerHomePage()
        {
            InitializeComponent();
        }

        private void Update_Profile_Button_Click(object sender, EventArgs e)
        {     
            
            this.Hide();
            Update_Admin Update = new Update_Admin();
            Update.Customer = existCustomer;
            Update.ShowDialog();
            this.Show();

        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {

        }

        private void search_flight_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_AvailFlights sFlight = new Show_AvailFlights();
            sFlight.ExistCustomer=existCustomer;
            sFlight.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyTickets TicketsForm = new MyTickets();
            TicketsForm.ShowDialog();
            this.Show();
        }

        private void Add_Payment_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Payment_Method APM = new Add_Payment_Method();
            APM.ExistCustomer = existCustomer;
            APM.ShowDialog();
            this.Show();
        }
    }
}
