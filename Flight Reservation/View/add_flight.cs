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

    public partial class add_flight : Form
    {
        List<AirCraftModel> air=new List<AirCraftModel>();
        private AdminModel existAdmin = new AdminModel();

        internal AdminModel ExistAdmin { get => existAdmin; set => existAdmin = value; }

        public add_flight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void add_flight_Load(object sender, EventArgs e)
        {
            AirCraftController Control = new AirCraftController();
            air = Control.GetAll();
            if (air != null)
            {


                comboBox1.DisplayMember = "Text";
                comboBox1.ValueMember = "Value";
                for (int i = 0; i < air.Count; i++)
                {
                    String text = air[i].AirCraft_ID.ToString();
                    comboBox1.Items.Add(new { Text = text, Value = i.ToString() });
                }
            }
            else
            {
                MessageBox.Show(Control.Message, "error", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            FlightModel flight = new FlightModel();
            flight.Plane = air[comboBox1.SelectedIndex];
            flight.Departure_Place = textBox2.Text;
            flight.Landing_Place = textBox3.Text;
            flight.Departure_Date = dateTimePicker1.Value;
            flight.Landing_Date = dateTimePicker2.Value;
            flight.Flight_Type = textBox6.Text;
            FlightController control = new FlightController();
            control.AddNewflight(flight);
            flight.Flight_ID = control.GetflightID();
            TicketController tk = new TicketController();
            for(int j = 0; j < flight.Plane.Capacity; j++)
            {
                tk.AddTickets(flight,(j+1));
            }

            MessageBox.Show(control.Message, "Information", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
