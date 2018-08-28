namespace Flight_Reservation.View
{
    partial class CustomerHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Update_Profile_Button = new System.Windows.Forms.Button();
            this.search_flight_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_Payment_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Update_Profile_Button
            // 
            this.Update_Profile_Button.Location = new System.Drawing.Point(12, 99);
            this.Update_Profile_Button.Name = "Update_Profile_Button";
            this.Update_Profile_Button.Size = new System.Drawing.Size(101, 23);
            this.Update_Profile_Button.TabIndex = 2;
            this.Update_Profile_Button.Text = "Update Profile";
            this.Update_Profile_Button.UseVisualStyleBackColor = true;
            this.Update_Profile_Button.Click += new System.EventHandler(this.Update_Profile_Button_Click);
            // 
            // search_flight_button
            // 
            this.search_flight_button.Location = new System.Drawing.Point(135, 99);
            this.search_flight_button.Name = "search_flight_button";
            this.search_flight_button.Size = new System.Drawing.Size(121, 23);
            this.search_flight_button.TabIndex = 3;
            this.search_flight_button.Text = "Search avail flights";
            this.search_flight_button.UseVisualStyleBackColor = true;
            this.search_flight_button.Click += new System.EventHandler(this.search_flight_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "My Tickets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Payment_Button
            // 
            this.Add_Payment_Button.Location = new System.Drawing.Point(135, 174);
            this.Add_Payment_Button.Name = "Add_Payment_Button";
            this.Add_Payment_Button.Size = new System.Drawing.Size(121, 23);
            this.Add_Payment_Button.TabIndex = 5;
            this.Add_Payment_Button.Text = "Add New Payment";
            this.Add_Payment_Button.UseVisualStyleBackColor = true;
            this.Add_Payment_Button.Click += new System.EventHandler(this.Add_Payment_Button_Click);
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Add_Payment_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_flight_button);
            this.Controls.Add(this.Update_Profile_Button);
            this.Name = "CustomerHomePage";
            this.Text = "CustomerHomePage";
            this.Load += new System.EventHandler(this.CustomerHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update_Profile_Button;
        private System.Windows.Forms.Button search_flight_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add_Payment_Button;
    }
}