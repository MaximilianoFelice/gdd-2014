namespace FrbaHotel.ABM_de_Usuario
{
    partial class NewAdminOrReceptionist
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelDocType = new System.Windows.Forms.Label();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.textBoxDocNumber = new System.Windows.Forms.TextBox();
            this.labelDocNumber = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelHotel = new System.Windows.Forms.Label();
            this.checkedListBoxHotel = new System.Windows.Forms.CheckedListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxHotel);
            this.groupBox1.Controls.Add(this.labelHotel);
            this.groupBox1.Controls.Add(this.labelBirthDate);
            this.groupBox1.Controls.Add(this.textBoxBirthDate);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.labelMail);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.labelDocNumber);
            this.groupBox1.Controls.Add(this.textBoxDocNumber);
            this.groupBox1.Controls.Add(this.comboBoxDocType);
            this.groupBox1.Controls.Add(this.labelDocType);
            this.groupBox1.Controls.Add(this.textBoxLastname);
            this.groupBox1.Controls.Add(this.labelLastname);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please enter the new user information";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(154, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(7, 56);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(53, 13);
            this.labelLastname.TabIndex = 2;
            this.labelLastname.Text = "Lastname";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(154, 53);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(120, 20);
            this.textBoxLastname.TabIndex = 3;
            // 
            // labelDocType
            // 
            this.labelDocType.AutoSize = true;
            this.labelDocType.Location = new System.Drawing.Point(7, 83);
            this.labelDocType.Name = "labelDocType";
            this.labelDocType.Size = new System.Drawing.Size(83, 13);
            this.labelDocType.TabIndex = 4;
            this.labelDocType.Text = "Document Type";
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Items.AddRange(new object[] {
            "ID - Identity Document",
            "IC - Identity Card",
            "Driving License",
            "Passport"});
            this.comboBoxDocType.Location = new System.Drawing.Point(154, 80);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(120, 21);
            this.comboBoxDocType.TabIndex = 5;
            // 
            // textBoxDocNumber
            // 
            this.textBoxDocNumber.Location = new System.Drawing.Point(154, 108);
            this.textBoxDocNumber.Name = "textBoxDocNumber";
            this.textBoxDocNumber.Size = new System.Drawing.Size(120, 20);
            this.textBoxDocNumber.TabIndex = 6;
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(7, 111);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(96, 13);
            this.labelDocNumber.TabIndex = 7;
            this.labelDocNumber.Text = "Document Number";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(154, 135);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(120, 20);
            this.textBoxMail.TabIndex = 8;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(7, 138);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(35, 13);
            this.labelMail.TabIndex = 9;
            this.labelMail.Text = "E-mail";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(154, 162);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(120, 20);
            this.textBoxPhone.TabIndex = 10;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(7, 165);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 13);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Phone Number";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(154, 189);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(120, 20);
            this.textBoxAddress.TabIndex = 12;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(6, 192);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 13;
            this.labelAddress.Text = "Address";
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(154, 216);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(120, 20);
            this.textBoxBirthDate.TabIndex = 14;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(7, 219);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(54, 13);
            this.labelBirthDate.TabIndex = 15;
            this.labelBirthDate.Text = "Birth Date";
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(10, 249);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(92, 13);
            this.labelHotel.TabIndex = 16;
            this.labelHotel.Text = "Hotel employee at";
            // 
            // checkedListBoxHotel
            // 
            this.checkedListBoxHotel.FormattingEnabled = true;
            this.checkedListBoxHotel.Location = new System.Drawing.Point(154, 249);
            this.checkedListBoxHotel.Name = "checkedListBoxHotel";
            this.checkedListBoxHotel.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxHotel.TabIndex = 17;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 371);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(218, 371);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // NewAdminOrReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 406);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewAdminOrReceptionist";
            this.Text = "New User Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.Label labelDocType;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelDocNumber;
        private System.Windows.Forms.TextBox textBoxDocNumber;
        private System.Windows.Forms.CheckedListBox checkedListBoxHotel;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
    }
}