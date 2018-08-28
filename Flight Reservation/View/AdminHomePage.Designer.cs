namespace Flight_Reservation.View
{
    partial class AdminHomePage
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
            this.Add_New_Admin_Button = new System.Windows.Forms.Button();
            this.Update_Profile_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_New_Admin_Button
            // 
            this.Add_New_Admin_Button.Location = new System.Drawing.Point(74, 12);
            this.Add_New_Admin_Button.Name = "Add_New_Admin_Button";
            this.Add_New_Admin_Button.Size = new System.Drawing.Size(101, 23);
            this.Add_New_Admin_Button.TabIndex = 0;
            this.Add_New_Admin_Button.Text = "Add New Admin";
            this.Add_New_Admin_Button.UseVisualStyleBackColor = true;
            this.Add_New_Admin_Button.Click += new System.EventHandler(this.Add_New_Admin_Button_Click);
            // 
            // Update_Profile_Button
            // 
            this.Update_Profile_Button.Location = new System.Drawing.Point(74, 53);
            this.Update_Profile_Button.Name = "Update_Profile_Button";
            this.Update_Profile_Button.Size = new System.Drawing.Size(101, 23);
            this.Update_Profile_Button.TabIndex = 1;
            this.Update_Profile_Button.Text = "Update Profile";
            this.Update_Profile_Button.UseVisualStyleBackColor = true;
            this.Update_Profile_Button.Click += new System.EventHandler(this.Update_Profile_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Air Craft";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update Air Craft";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add Flight";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "UpdateFlight";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 261);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Update_Profile_Button);
            this.Controls.Add(this.Add_New_Admin_Button);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_New_Admin_Button;
        private System.Windows.Forms.Button Update_Profile_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}