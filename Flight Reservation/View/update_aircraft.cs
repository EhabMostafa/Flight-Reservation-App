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
    public partial class update_aircraft : Form
    {
        List<AirCraftModel> air = new List<AirCraftModel>();
        AirCraftModel aircraft = new AirCraftModel();
        public update_aircraft()
        {
            InitializeComponent();
        }

        private void update_aircraft_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = air[comboBox1.SelectedIndex].Model;
            textBox2.Visible = true;
            textBox2.Text = air[comboBox1.SelectedIndex].Color;
            textBox3.Visible = true;
            textBox3.Text = air[comboBox1.SelectedIndex].Capacity.ToString();
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button1.Visible = true;
            aircraft=air[comboBox1.SelectedIndex];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            aircraft.Model = textBox1.Text;
            aircraft.Color = textBox2.Text;
            aircraft.Capacity = int.Parse(textBox3.Text);
            AirCraftController control = new AirCraftController();
            control.update_Aircraft(aircraft);
            MessageBox.Show(control.Message, "Information", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
