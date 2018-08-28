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
    public partial class add_aircraft : Form
    {
        private AdminModel existAdmin = new AdminModel();

        internal AdminModel ExistAdmin { get => existAdmin; set => existAdmin = value; }

        public add_aircraft()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirCraftModel aircraft = new AirCraftModel();

            aircraft.Model = textBox1.Text;
            aircraft.Color = textBox2.Text;
            aircraft.Capacity = int.Parse (textBox3.Text);

            AirCraftController control = new AirCraftController();
            control.AddNewAircraft(aircraft);
            MessageBox.Show(control.Message, "Information", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
