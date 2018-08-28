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
    public partial class AdminHomePage : Form
    {
        private AdminModel existAdmin = new AdminModel();

        internal AdminModel ExistAdmin { get => existAdmin; set => existAdmin = value; }

        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void Add_New_Admin_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.User_Type = "Admin";
            register.ShowDialog();
            this.Show();
        }

        private void Update_Profile_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Admin admin = new Update_Admin();
            admin.Admin = existAdmin;
            admin.ShowDialog();
            this.Show();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_flight f = new add_flight();
            f.ExistAdmin = existAdmin;
            f.ShowDialog();
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_aircraft a = new add_aircraft();
            a.ExistAdmin = existAdmin;
            a.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_aircraft a = new add_aircraft();
            a.ExistAdmin = existAdmin;
            a.ShowDialog();
            this.Show();
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_aircraft a = new update_aircraft();
            a.ShowDialog();
            this.Show();
        }
    }
}
