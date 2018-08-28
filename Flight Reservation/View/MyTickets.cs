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
    public partial class MyTickets : Form
    {
        private CustomerModel existCustomer = new CustomerModel();
        private List<FlightModel> flights = new List<FlightModel>();

        internal CustomerModel ExistCustomer { get => existCustomer; set => existCustomer = value; }
        internal List<FlightModel> Flights { get => flights; set => flights = value; }

        public MyTickets()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void MyTickets_Load(object sender, EventArgs e)
        {
            FlightController control = new FlightController();
            flights = control.GetMyFlights(existCustomer.User_Name);
            if (flights!=null)
            {
                
           
            for (int i = 0; i < flights.Count; i++)
            {
                Label ck = new Label();
                ck.Text = flights[i].Ticktes[0].Ticket_Number.ToString();
                ck.AutoSize = true;


                ck.Location = new Point(12, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck);


                Label ck2 = new Label();
                ck2.Text = flights[i].Ticktes[0].Class.ToString();
                //ck.Click += (s, ev) => { MessageBox.Show(ck.Text, "Information", MessageBoxButtons.OK); };
                ck2.AutoSize = true;
                ck2.Location = new Point(109, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck2);

                Label ck3 = new Label();
                ck3.Text = flights[i].Ticktes[0].Price.ToString();
                //ck.Click += (s, ev) => { MessageBox.Show(ck.Text, "Information", MessageBoxButtons.OK); };
                ck3.AutoSize = true;
                ck3.Location = new Point(163, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck3);

                Label ck4 = new Label();
                ck4.Text = flights[i].Ticktes[0].Seat_Num.ToString();
                ck4.AutoSize = true;

                ck4.Location = new Point(215, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck4);

                Label ck5 = new Label();
                ck5.Text = flights[i].Departure_Place;
                ck5.AutoSize = true;

                ck5.Location = new Point(301, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck5);

                Label ck6 = new Label();
                ck6.Text = flights[i].Departure_Place;
                ck6.AutoSize = true;

                ck6.Location = new Point(397, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck6);



        
                Button but = new Button();
                but.Text = "Cancel";
                but.AutoSize = true;
                but.Click += (sende, ee) =>
                {
                    TicketController tk = new TicketController();
                    tk.RemoveTicket(flights[i - 1], existCustomer.User_Name);
                    MessageBox.Show(tk.Message, "Information", MessageBoxButtons.OK);
                    this.Close();
                };
                but.Location = new Point(510, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(but);
                    /*
                Button but2 = new Button();
                but2.Text = "Change";
                but2.AutoSize = true;
                but2.Click += (sende, ee) =>
                {
                };
                but2.Location = new Point(560, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(but2);
                */

            }
            }
            else
            {
                MessageBox.Show("YOU DONT HAVE ANY TICKETS", "ERROR", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void FlightID_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
