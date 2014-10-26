namespace FrbaHotel.ABM_de_Usuario
{
    partial class CreateUser
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelConfPass = new System.Windows.Forms.Label();
            this.textBoxConfPass = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRole);
            this.groupBox1.Controls.Add(this.labelRole);
            this.groupBox1.Controls.Add(this.textBoxConfPass);
            this.groupBox1.Controls.Add(this.labelConfPass);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please enter the user information";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(16, 28);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(153, 25);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(16, 54);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Password";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(153, 51);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 3;
            // 
            // labelConfPass
            // 
            this.labelConfPass.AutoSize = true;
            this.labelConfPass.Location = new System.Drawing.Point(16, 80);
            this.labelConfPass.Name = "labelConfPass";
            this.labelConfPass.Size = new System.Drawing.Size(91, 13);
            this.labelConfPass.TabIndex = 4;
            this.labelConfPass.Text = "Confirm Password";
            // 
            // textBoxConfPass
            // 
            this.textBoxConfPass.Location = new System.Drawing.Point(153, 77);
            this.textBoxConfPass.Name = "textBoxConfPass";
            this.textBoxConfPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxConfPass.TabIndex = 5;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(16, 106);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(86, 13);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "Designated Role";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(153, 103);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRole.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(13, 164);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(205, 164);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateUser";
            this.Text = "Create User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxConfPass;
        private System.Windows.Forms.Label labelConfPass;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
    }
}