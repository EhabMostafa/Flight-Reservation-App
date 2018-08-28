using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.Controller;
using Flight_Reservation.Model;
using System.Windows.Forms;

namespace Flight_Reservation.View
{
       public partial class Update_Admin : Form
    {
        private AdminModel admin = new AdminModel();
        private CustomerModel customer = new CustomerModel();
        internal AdminModel Admin { get => admin; set => admin = value; }
        internal CustomerModel Customer { get => customer; set => customer = value; }

        public Update_Admin()
        {
            admin = null;
            customer = null;
            InitializeComponent();
        }


        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.First_Name = FirstName_TextBox.Text;
                admin.Second_Name = SecondName_TextBox.Text;
                admin.Email = Email_TextBox.Text;
                admin.Password = Password_TextBox.Text;
                if (Male_RadioButton.Checked == true)
                {
                    admin.Gender = "Male";
                }
                else
                {
                    admin.Gender = "Female";
                }
                admin.Birth_Date = BirthDate_Time.Value;
                admin.Country = Country_TextBox.Text;

                AdminController control = new AdminController();
                if (control.update_adminDetails(admin))
                {
                    MessageBox.Show(control.Message, "Information", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    if (MessageBox.Show(control.Message, "Error", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                    {

                        this.Close();
                    }
                }
            }
            else
            {
               customer.First_Name = FirstName_TextBox.Text;
               customer.Second_Name = SecondName_TextBox.Text;
               customer.Email = Email_TextBox.Text;
               customer.Password = Password_TextBox.Text;
                if (Male_RadioButton.Checked == true)
                {
                   customer.Gender = "Male";
                }
                else
                {
                   customer.Gender = "Female";
                }
               customer.Birth_Date = BirthDate_Time.Value;
               customer.Country = Country_TextBox.Text;

               CustomerController control = new CustomerController();
                if (control.update_CustomerDetails(customer))
                {
                    MessageBox.Show(control.Message, "Information", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    if (MessageBox.Show(control.Message, "Error", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                    {

                        this.Close();
                    }
                }
            }
            
        }

        private void Update_Admin_Load(object sender, EventArgs e)
        {
            if (admin != null)
            {
                usernameRes_label.Text = admin.User_Name;
                FirstName_TextBox.Text = admin.First_Name;
                SecondName_TextBox.Text = admin.Second_Name;
                Email_TextBox.Text = admin.Email;
                Password_TextBox.Text = admin.Password;
                if (admin.Gender == "Male")
                {
                    Male_RadioButton.Checked = true;
                }
                else
                {
                    Female_RadioButton.Checked = true;
                }
                BirthDate_Time.Value = admin.Birth_Date;
                Country_TextBox.Text = admin.Country;
            }
            else
            {
                usernameRes_label.Text = customer.User_Name;
                FirstName_TextBox.Text = customer.First_Name;
                SecondName_TextBox.Text = customer.Second_Name;
                Email_TextBox.Text = customer.Email;
                Password_TextBox.Text = customer.Password;
                if (customer.Gender == "Male")
                {
                    Male_RadioButton.Checked = true;
                }
                else
                {
                    Female_RadioButton.Checked = true;
                }
                BirthDate_Time.Value = customer.Birth_Date;
                Country_TextBox.Text = customer.Country;
            }


            
        }
    }
}
