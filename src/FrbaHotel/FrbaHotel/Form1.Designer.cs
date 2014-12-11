namespace FrbaHotel
{
    partial class Form1
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
            this.Incorrect_Login = new HotelModel.User_Permissions.HandledControls.HandledButton();
            this.Correct_Login = new HotelModel.User_Permissions.HandledControls.HandledButton();
            this.cmdTests = new HotelModel.User_Permissions.HandledControls.HandledButton();
            this.handledButton1 = new HotelModel.User_Permissions.HandledControls.HandledButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Incorrect_Login
            // 
            this.Incorrect_Login.HandlesVisibility = false;
            this.Incorrect_Login.Location = new System.Drawing.Point(54, 148);
            this.Incorrect_Login.Name = "Incorrect_Login";
            this.Incorrect_Login.Size = new System.Drawing.Size(152, 73);
            this.Incorrect_Login.TabIndex = 0;
            this.Incorrect_Login.Text = "Incorrect Login";
            this.Incorrect_Login.UseVisualStyleBackColor = true;
            this.Incorrect_Login.Click += new System.EventHandler(this.Incorrect_Login_Click);
            // 
            // Correct_Login
            // 
            this.Correct_Login.HandlesVisibility = false;
            this.Correct_Login.Location = new System.Drawing.Point(46, 48);
            this.Correct_Login.Name = "Correct_Login";
            this.Correct_Login.Size = new System.Drawing.Size(159, 76);
            this.Correct_Login.TabIndex = 1;
            this.Correct_Login.Text = "Correct Login";
            this.Correct_Login.UseVisualStyleBackColor = true;
            this.Correct_Login.Click += new System.EventHandler(this.Correct_Login_Click);
            // 
            // cmdTests
            // 
            this.cmdTests.HandlesVisibility = false;
            this.cmdTests.Location = new System.Drawing.Point(273, 24);
            this.cmdTests.Name = "cmdTests";
            this.cmdTests.Size = new System.Drawing.Size(189, 100);
            this.cmdTests.TabIndex = 2;
            this.cmdTests.Text = "Test";
            this.cmdTests.UseVisualStyleBackColor = true;
            this.cmdTests.Click += new System.EventHandler(this.cmdTests_Click);
            // 
            // handledButton1
            // 
            this.handledButton1.HandlesVisibility = false;
            this.handledButton1.Location = new System.Drawing.Point(338, 186);
            this.handledButton1.Name = "handledButton1";
            this.handledButton1.Size = new System.Drawing.Size(75, 23);
            this.handledButton1.TabIndex = 3;
            this.handledButton1.Text = "handledButton1";
            this.handledButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.handledButton1);
            this.Controls.Add(this.cmdTests);
            this.Controls.Add(this.Correct_Login);
            this.Controls.Add(this.Incorrect_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HotelModel.User_Permissions.HandledControls.HandledButton Incorrect_Login;
        private HotelModel.User_Permissions.HandledControls.HandledButton Correct_Login;
        private HotelModel.User_Permissions.HandledControls.HandledButton cmdTests;
        private HotelModel.User_Permissions.HandledControls.HandledButton handledButton1;
        private System.Windows.Forms.Button button1;
    }
}

