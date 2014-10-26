namespace FrbaHotel.Listado_Estadistico
{
    partial class Statistics
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTopCanceled = new System.Windows.Forms.Button();
            this.buttonTopExtra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTopExtra);
            this.groupBox1.Controls.Add(this.buttonTopCanceled);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel Statistics";
            // 
            // buttonTopCanceled
            // 
            this.buttonTopCanceled.Location = new System.Drawing.Point(21, 30);
            this.buttonTopCanceled.Name = "buttonTopCanceled";
            this.buttonTopCanceled.Size = new System.Drawing.Size(159, 23);
            this.buttonTopCanceled.TabIndex = 0;
            this.buttonTopCanceled.Text = "Top Canceled Bookings";
            this.buttonTopCanceled.UseVisualStyleBackColor = true;
            // 
            // buttonTopExtra
            // 
            this.buttonTopExtra.Location = new System.Drawing.Point(21, 60);
            this.buttonTopExtra.Name = "buttonTopExtra";
            this.buttonTopExtra.Size = new System.Drawing.Size(159, 23);
            this.buttonTopExtra.TabIndex = 1;
            this.buttonTopExtra.Text = "Top Extra Billed";
            this.buttonTopExtra.UseVisualStyleBackColor = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTopExtra;
        private System.Windows.Forms.Button buttonTopCanceled;
    }
}