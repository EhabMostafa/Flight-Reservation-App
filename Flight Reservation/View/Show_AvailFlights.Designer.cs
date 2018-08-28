namespace Flight_Reservation.View
{
    partial class Show_AvailFlights
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
            this.Depture_Place_textbox = new System.Windows.Forms.TextBox();
            this.LandingPlace_textBox = new System.Windows.Forms.TextBox();
            this.Type_textBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.seats_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Depture_Place_textbox
            // 
            this.Depture_Place_textbox.Location = new System.Drawing.Point(160, 65);
            this.Depture_Place_textbox.Name = "Depture_Place_textbox";
            this.Depture_Place_textbox.Size = new System.Drawing.Size(100, 20);
            this.Depture_Place_textbox.TabIndex = 1;
            // 
            // LandingPlace_textBox
            // 
            this.LandingPlace_textBox.Location = new System.Drawing.Point(160, 102);
            this.LandingPlace_textBox.Name = "LandingPlace_textBox";
            this.LandingPlace_textBox.Size = new System.Drawing.Size(100, 20);
            this.LandingPlace_textBox.TabIndex = 2;
            // 
            // Type_textBox
            // 
            this.Type_textBox.Location = new System.Drawing.Point(160, 140);
            this.Type_textBox.Name = "Type_textBox";
            this.Type_textBox.Size = new System.Drawing.Size(100, 20);
            this.Type_textBox.TabIndex = 3;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(46, 213);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(189, 23);
            this.Search_button.TabIndex = 7;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(35, 22);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 8;
            // 
            // seats_textBox
            // 
            this.seats_textBox.Location = new System.Drawing.Point(159, 171);
            this.seats_textBox.Name = "seats_textBox";
            this.seats_textBox.Size = new System.Drawing.Size(100, 20);
            this.seats_textBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Depture Place";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Landing Place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of seats";
            // 
            // Show_AvailFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seats_textBox);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Type_textBox);
            this.Controls.Add(this.LandingPlace_textBox);
            this.Controls.Add(this.Depture_Place_textbox);
            this.Name = "Show_AvailFlights";
            this.Text = "Show_AvailFlights";
            this.Load += new System.EventHandler(this.Show_AvailFlights_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Depture_Place_textbox;
        private System.Windows.Forms.TextBox LandingPlace_textBox;
        private System.Windows.Forms.TextBox Type_textBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox seats_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}