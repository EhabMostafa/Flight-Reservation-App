namespace Flight_Reservation.View
{
    partial class Add_Payment_Method
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
            this.SecondName_Label = new System.Windows.Forms.Label();
            this.Bank_TextBox = new System.Windows.Forms.TextBox();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.Type_TextBox = new System.Windows.Forms.TextBox();
            this.Number_Label = new System.Windows.Forms.Label();
            this.Number_TextBox = new System.Windows.Forms.TextBox();
            this.EXP_Time = new System.Windows.Forms.DateTimePicker();
            this.BirthDate_Label = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SecondName_Label
            // 
            this.SecondName_Label.AutoSize = true;
            this.SecondName_Label.Location = new System.Drawing.Point(15, 86);
            this.SecondName_Label.Name = "SecondName_Label";
            this.SecondName_Label.Size = new System.Drawing.Size(87, 13);
            this.SecondName_Label.TabIndex = 14;
            this.SecondName_Label.Text = "Credit Card Bank";
            // 
            // Bank_TextBox
            // 
            this.Bank_TextBox.Location = new System.Drawing.Point(132, 83);
            this.Bank_TextBox.Name = "Bank_TextBox";
            this.Bank_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Bank_TextBox.TabIndex = 13;
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Location = new System.Drawing.Point(15, 50);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(86, 13);
            this.FirstName_Label.TabIndex = 12;
            this.FirstName_Label.Text = "Credit Card Type";
            // 
            // Type_TextBox
            // 
            this.Type_TextBox.Location = new System.Drawing.Point(132, 47);
            this.Type_TextBox.Name = "Type_TextBox";
            this.Type_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Type_TextBox.TabIndex = 11;
            // 
            // Number_Label
            // 
            this.Number_Label.AutoSize = true;
            this.Number_Label.Location = new System.Drawing.Point(15, 15);
            this.Number_Label.Name = "Number_Label";
            this.Number_Label.Size = new System.Drawing.Size(99, 13);
            this.Number_Label.TabIndex = 10;
            this.Number_Label.Text = "Credit Card Number";
            // 
            // Number_TextBox
            // 
            this.Number_TextBox.Location = new System.Drawing.Point(132, 12);
            this.Number_TextBox.Name = "Number_TextBox";
            this.Number_TextBox.Size = new System.Drawing.Size(200, 20);
            this.Number_TextBox.TabIndex = 9;
            // 
            // EXP_Time
            // 
            this.EXP_Time.Location = new System.Drawing.Point(132, 119);
            this.EXP_Time.Name = "EXP_Time";
            this.EXP_Time.Size = new System.Drawing.Size(200, 20);
            this.EXP_Time.TabIndex = 19;
            // 
            // BirthDate_Label
            // 
            this.BirthDate_Label.AutoSize = true;
            this.BirthDate_Label.Location = new System.Drawing.Point(14, 125);
            this.BirthDate_Label.Name = "BirthDate_Label";
            this.BirthDate_Label.Size = new System.Drawing.Size(106, 13);
            this.BirthDate_Label.TabIndex = 18;
            this.BirthDate_Label.Text = "Credit Card Exp Date";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(118, 163);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(103, 23);
            this.Add_Button.TabIndex = 20;
            this.Add_Button.Text = "Add Method";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Add_Payment_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 199);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.EXP_Time);
            this.Controls.Add(this.BirthDate_Label);
            this.Controls.Add(this.SecondName_Label);
            this.Controls.Add(this.Bank_TextBox);
            this.Controls.Add(this.FirstName_Label);
            this.Controls.Add(this.Type_TextBox);
            this.Controls.Add(this.Number_Label);
            this.Controls.Add(this.Number_TextBox);
            this.Name = "Add_Payment_Method";
            this.Text = "Add_Payment_Method";
            this.Load += new System.EventHandler(this.Add_Payment_Method_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SecondName_Label;
        private System.Windows.Forms.TextBox Bank_TextBox;
        private System.Windows.Forms.Label FirstName_Label;
        private System.Windows.Forms.TextBox Type_TextBox;
        private System.Windows.Forms.Label Number_Label;
        private System.Windows.Forms.TextBox Number_TextBox;
        private System.Windows.Forms.DateTimePicker EXP_Time;
        private System.Windows.Forms.Label BirthDate_Label;
        private System.Windows.Forms.Button Add_Button;
    }
}