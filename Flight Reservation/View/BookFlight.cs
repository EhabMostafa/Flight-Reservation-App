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
    public partial class BookFlight : Form
    {
        private List<FlightModel> flights;
        private CustomerModel existCustomer = new CustomerModel();
        public int NumberOfTickets = 0;
        public int payid = new int();
        public BookFlight()
        {
            InitializeComponent();
        }

        internal List<FlightModel> Flights { get => flights; set => flights = value; }
        internal CustomerModel ExistCustomer { get => existCustomer; set => existCustomer = value; }

        private void BookFlight_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < flights.Count; i++)
            {
                Label ck = new Label();
                ck.Text = flights[i].Departure_Place;
                //ck.Click += (s, ev) => { MessageBox.Show(ck.Text, "Information", MessageBoxButtons.OK); };

                ck.Location = new Point(9, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck);

                Label ck2 = new Label();
                ck2.Text = flights[i].Landing_Place;
                //ck.Click += (s, ev) => { MessageBox.Show(ck.Text, "Information", MessageBoxButtons.OK); };

                ck2.Location = new Point(105, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck2);

                Label ck3 = new Label();
                ck3.Text = flights[i].Departure_Date.Day.ToString() + ":" + flights[i].Departure_Date.Month.ToString() + ":" + flights[i].Departure_Date.Year.ToString();
                //ck.Click += (s, ev) => { MessageBox.Show(ck.Text, "Information", MessageBoxButtons.OK); };

                ck3.Location = new Point(200, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck3);

                Label ck4 = new Label();
                ck4.Text = flights[i].Landing_Date.Day.ToString() + ":" + flights[i].Landing_Date.Month.ToString() + ":" + flights[i].Landing_Date.Year.ToString();
             

                ck4.Location = new Point(300, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(ck4);

                Button but = new Button();
                but.Text = "Book";

                but.Click += (sende, ee) =>
                {
                    
                    this.Hide();
                    SelectPayment select = new SelectPayment();
                    select.ExistCustomer = existCustomer;
                    select.ShowDialog();
                    this.Show();
                    payid = int.Parse(System.IO.File.ReadAllText(@"D:\FCI\FCI 2018\Term 2\DataBase-1\Project\Phase 3\Flight Reservation\Flight Reservation\f.txt"));

                    if (payid == -1)
                    {
                        MessageBox.Show("You didnt choose payement method", "Information", MessageBoxButtons.OK);
                        return;
                    }

                    TicketController Control = new TicketController();
                    
                    bool IsAdded =Control.BookTickets(payid,flights[i-1].Flight_ID,existCustomer.User_Name);

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

                };

                but.Location = new Point(400, this.Controls.Count + ((i + 1) * 26));
                this.Controls.Add(but);

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
