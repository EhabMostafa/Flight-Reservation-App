using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.Model;
using Flight_Reservation.Controller;
using System.Windows.Forms;

namespace Flight_Reservation.View
{

    public partial class Show_AvailFlights : Form
    {
        private List<FlightModel> flights;
        private CustomerModel existCustomer = new CustomerModel();


        public Show_AvailFlights()
        {
            InitializeComponent();
        }

        internal List<FlightModel> Flights { get => flights; set => flights = value; }
        internal CustomerModel ExistCustomer { get => existCustomer; set => existCustomer = value; }

        private void Search_button_Click(object sender, EventArgs e)
        {

            string query = "Select * from flight where ";
            query += "DEPARTURE_DATE = " +  "'" + dateTime.Value + "'";
            if (Depture_Place_textbox.Text != "")
            {
                query += " and  DEPARTURE_PLACE = " + "'" + Depture_Place_textbox.Text + "'";
            }
            if (LandingPlace_textBox.Text != "")
            {
                query += " and LANDING_PLACE = " + "'" + LandingPlace_textBox.Text + "'";
            }
            if (Type_textBox.Text != "")
            {
                query += " and FLIGHT_TYPE = " + "'" + Type_textBox.Text + "'";
            }
            //query
            if (seats_textBox.Text != "")
            {
                query += " and where(select COUNT(*) from TICKET where FLIGHT.FLIGHT_ID = TICKET.FLIGHT_ID and TICKET.PAYMENT_ID is null) >= " + seats_textBox.Text;
            }

            FlightController controller = new FlightController();
            Flights=controller.search(query);
            if (Flights !=null)
            {
                this.Hide();
                BookFlight bookFlight = new BookFlight();
                bookFlight.Flights = flights;
                bookFlight.ExistCustomer = existCustomer;
                if (seats_textBox.Text != "")
                {
                    bookFlight.NumberOfTickets = int.Parse(seats_textBox.Text);
                        }
                bookFlight.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(controller.Message, "error", MessageBoxButtons.RetryCancel);
            }
        }

        private void Show_AvailFlights_Load(object sender, EventArgs e)
        {

        }
    }
}
