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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.User_Type = "Customer";
            register.ShowDialog();
            this.Show();

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            CustomerController CustomerControl = new CustomerController();
            CustomerModel ExistCustomer = new CustomerModel();

            AdminController AdminControl = new AdminController();
            AdminModel ExistAdmin = new AdminModel();

            ExistCustomer = CustomerControl.GetExistCustomer(UserName_TextBox.Text,Password_TextBox.Text);

            if (ExistCustomer!=null)
            {
                MessageBox.Show(CustomerControl.Message, "Information", MessageBoxButtons.OK);
                this.Hide();
                CustomerHomePage customerHomePage = new CustomerHomePage();
                customerHomePage.ExistCustomer = ExistCustomer;
                customerHomePage.ShowDialog();
                this.Show();
            }
            else
            {
                ExistAdmin = AdminControl.GetExistAdmin(UserName_TextBox.Text, Password_TextBox.Text);
                if (ExistAdmin != null)
                {
                    MessageBox.Show(AdminControl.Message, "Information", MessageBoxButtons.OK);
                    this.Hide();
                    AdminHomePage adminHomePage = new AdminHomePage();
                    adminHomePage.ExistAdmin = ExistAdmin;
                    adminHomePage.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(AdminControl.Message, "Error", MessageBoxButtons.RetryCancel);

                }

            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
