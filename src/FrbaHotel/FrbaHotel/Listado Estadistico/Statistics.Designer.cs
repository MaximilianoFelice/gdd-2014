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
            this.buttonOutService = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonTopScore = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOutService);
            this.groupBox1.Controls.Add(this.buttonTopExtra);
            this.groupBox1.Controls.Add(this.buttonTopCanceled);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 133);
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
            // buttonOutService
            // 
            this.buttonOutService.Location = new System.Drawing.Point(21, 90);
            this.buttonOutService.Name = "buttonOutService";
            this.buttonOutService.Size = new System.Drawing.Size(159, 23);
            this.buttonOutService.TabIndex = 2;
            this.buttonOutService.Text = "Top Out of Service";
            this.buttonOutService.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(13, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Statistics";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Top Occupied";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonTopScore);
            this.groupBox3.Location = new System.Drawing.Point(13, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guest Statistics";
            // 
            // buttonTopScore
            // 
            this.buttonTopScore.Location = new System.Drawing.Point(21, 37);
            this.buttonTopScore.Name = "buttonTopScore";
            this.buttonTopScore.Size = new System.Drawing.Size(159, 23);
            this.buttonTopScore.TabIndex = 0;
            this.buttonTopScore.Text = "Top Score";
            this.buttonTopScore.UseVisualStyleBackColor = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTopExtra;
        private System.Windows.Forms.Button buttonTopCanceled;
        private System.Windows.Forms.Button buttonOutService;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonTopScore;
    }
}