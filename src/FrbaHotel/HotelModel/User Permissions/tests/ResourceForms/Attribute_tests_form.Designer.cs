namespace HotelModel.User_Permissions.tests.ResourceForms
{
    partial class Attribute_tests_form
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
            this.handledButton1 = new HotelModel.User_Permissions.HandledControls.HandledButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // handledButton1
            // 
            this.handledButton1.HandlesAccess = true;
            this.handledButton1.HandlesVisibility = true;
            this.handledButton1.Location = new System.Drawing.Point(71, 97);
            this.handledButton1.Name = "handledButton1";
            this.handledButton1.Size = new System.Drawing.Size(142, 100);
            this.handledButton1.TabIndex = 0;
            this.handledButton1.Text = "handledButton1";
            this.handledButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Attribute_tests_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.handledButton1);
            this.Name = "Attribute_tests_form";
            this.Text = "Attribute_tests";
            this.Load += new System.EventHandler(this.Attribute_tests_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HotelModel.User_Permissions.HandledControls.HandledButton handledButton1;
        private System.Windows.Forms.Button button1;
    }
}