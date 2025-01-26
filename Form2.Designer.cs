﻿namespace library_app
{
    partial class Form2
    {
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.TextBox TextBox7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.TextBox TextBox12;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.TextBox TextBox14;
        private System.Windows.Forms.Label Label15; // New label for admin_id
        private System.Windows.Forms.TextBox TextBox16; // New TextBox for admin_id

        private void InitializeComponent()
        {
            
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Library App - Sign Up";
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.BackColor = System.Drawing.Color.MintCream;

            // Button0 - Sign up
            this.Button0 = new System.Windows.Forms.Button();
            this.Button0.Text = "Sign Up";
            this.Button0.Location = new System.Drawing.Point(200, 300);
            this.Button0.Size = new System.Drawing.Size(200, 50);
            this.Button0.BackColor = System.Drawing.Color.ForestGreen;
            this.Button0.ForeColor = System.Drawing.Color.White;
            this.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button0.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);

            // TextBox7 - Email Input
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.TextBox7.Location = new System.Drawing.Point(150, 130);
            this.TextBox7.Size = new System.Drawing.Size(300, 30);
            this.TextBox7.TabIndex = 7;

            // Label8 - Header
            this.Label8 = new System.Windows.Forms.Label();
            this.Label8.Text = "Get Started";
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Label8.Location = new System.Drawing.Point(240, 20);
            this.Label8.Size = new System.Drawing.Size(200, 40);

            // Label9 - Email Label
            this.Label9 = new System.Windows.Forms.Label();
            this.Label9.Text = "Email";
            this.Label9.Location = new System.Drawing.Point(150, 110);
            this.Label9.Size = new System.Drawing.Size(100, 20);

            // Label11 - Name Label
            this.Label11 = new System.Windows.Forms.Label();
            this.Label11.Text = "Name";
            this.Label11.Location = new System.Drawing.Point(150, 50);
            this.Label11.Size = new System.Drawing.Size(100, 20);

            // TextBox12 - Name Input
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.TextBox12.Location = new System.Drawing.Point(150, 70);
            this.TextBox12.Size = new System.Drawing.Size(300, 30);
            this.TextBox12.TabIndex = 12;

            // Label13 - Password Label
            this.Label13 = new System.Windows.Forms.Label();
            this.Label13.Text = "Password";
            this.Label13.Location = new System.Drawing.Point(150, 170);
            this.Label13.Size = new System.Drawing.Size(100, 20);

            // TextBox14 - Password Input
            this.TextBox14 = new System.Windows.Forms.TextBox();
            this.TextBox14.UseSystemPasswordChar = true;
            this.TextBox14.Location = new System.Drawing.Point(150, 190);
            this.TextBox14.Size = new System.Drawing.Size(300, 30);
            this.TextBox14.TabIndex = 14;

            // Label15 - Admin ID Label
            this.Label15 = new System.Windows.Forms.Label();
            this.Label15.Text = "Admin ID";
            this.Label15.Location = new System.Drawing.Point(150, 230);
            this.Label15.Size = new System.Drawing.Size(100, 20);

            // TextBox16 - Admin ID Input
            this.TextBox16 = new System.Windows.Forms.TextBox();
            this.TextBox16.Location = new System.Drawing.Point(150, 250);
            this.TextBox16.Size = new System.Drawing.Size(300, 30);
            this.TextBox16.TabIndex = 16;

            // Adding controls to the form
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.TextBox12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.TextBox14);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.TextBox16);
        }
    }
}
