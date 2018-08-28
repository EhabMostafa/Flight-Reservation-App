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
    public partial class Register : Form
    {
        public String User_Type;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if (User_Type == "Customer")
            {
                CustomerModel NewCustomer = new CustomerModel();
                NewCustomer.User_Name = UserName_TextBox.Text;
                NewCustomer.First_Name = FirstName_TextBox.Text;
                NewCustomer.Second_Name = SecondName_TextBox.Text;
                NewCustomer.Email = Email_TextBox.Text;
                NewCustomer.Password = Password_TextBox.Text;
                if (Male_RadioButton.Checked)
                {
                    NewCustomer.Gender = "Male";
                }
                else
                {
                    NewCustomer.Gender = "Female";
                }
                NewCustomer.Birth_Date = BirthDate_Time.Value;
                NewCustomer.Country = Country_TextBox.Text;


                CustomerController Control = new CustomerController();

                bool IsAdded = Control.AddNewCustomer(NewCustomer);

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
            }
            else
            {
                AdminModel NewAdmin = new AdminModel();
                NewAdmin.User_Name = UserName_TextBox.Text;
                NewAdmin.First_Name = FirstName_TextBox.Text;
                NewAdmin.Second_Name = SecondName_TextBox.Text;
                NewAdmin.Email = Email_TextBox.Text;
                NewAdmin.Password = Password_TextBox.Text;
                if (Male_RadioButton.Checked)
                {
                    NewAdmin.Gender = "Male";
                }
                else
                {
                    NewAdmin.Gender = "Female";
                }
                NewAdmin.Birth_Date = BirthDate_Time.Value;
                NewAdmin.Country = Country_TextBox.Text;


                AdminController Control = new AdminController();

                bool IsAdded = Control.AddNewAdmin(NewAdmin);

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
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
