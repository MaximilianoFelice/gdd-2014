namespace FrbaHotel.ABM_de_Cliente
{
    partial class UpdateGuest
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
            this.components = new System.ComponentModel.Container();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxGuest = new System.Windows.Forms.GroupBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxDept = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxStreetNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPickerBirhtDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.textBoxDocNumber = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDocNumber = new System.Windows.Forms.Label();
            this.labelDocType = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxGuest.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(328, -9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(0, 13);
            this.labelText.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 254);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(549, 254);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // groupBoxGuest
            // 
            this.groupBoxGuest.Controls.Add(this.comboBoxNationality);
            this.groupBoxGuest.Controls.Add(this.groupBox2);
            this.groupBoxGuest.Controls.Add(this.dtPickerBirhtDate);
            this.groupBoxGuest.Controls.Add(this.textBoxPhone);
            this.groupBoxGuest.Controls.Add(this.textBoxEmail);
            this.groupBoxGuest.Controls.Add(this.comboBoxDocType);
            this.groupBoxGuest.Controls.Add(this.textBoxDocNumber);
            this.groupBoxGuest.Controls.Add(this.textBoxLastname);
            this.groupBoxGuest.Controls.Add(this.textBoxName);
            this.groupBoxGuest.Controls.Add(this.labelNationality);
            this.groupBoxGuest.Controls.Add(this.labelBirthDate);
            this.groupBoxGuest.Controls.Add(this.labelPhone);
            this.groupBoxGuest.Controls.Add(this.labelEmail);
            this.groupBoxGuest.Controls.Add(this.labelDocNumber);
            this.groupBoxGuest.Controls.Add(this.labelDocType);
            this.groupBoxGuest.Controls.Add(this.labelLastname);
            this.groupBoxGuest.Controls.Add(this.labelName);
            this.groupBoxGuest.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGuest.Name = "groupBoxGuest";
            this.groupBoxGuest.Size = new System.Drawing.Size(612, 236);
            this.groupBoxGuest.TabIndex = 6;
            this.groupBoxGuest.TabStop = false;
            this.groupBoxGuest.Text = "Please insert the new guest information";
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(449, 54);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(137, 21);
            this.comboBoxNationality.TabIndex = 48;
            this.comboBoxNationality.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxNationality_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxStreet);
            this.groupBox2.Controls.Add(this.textBoxDept);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxFloor);
            this.groupBox2.Controls.Add(this.textBoxStreetNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(324, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 146);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Street";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(125, 24);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(137, 20);
            this.textBoxStreet.TabIndex = 38;
            this.textBoxStreet.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStreet_Validating);
            // 
            // textBoxDept
            // 
            this.textBoxDept.Location = new System.Drawing.Point(125, 102);
            this.textBoxDept.Name = "textBoxDept";
            this.textBoxDept.Size = new System.Drawing.Size(137, 20);
            this.textBoxDept.TabIndex = 41;
            this.textBoxDept.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDept_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Street Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Department";
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(125, 76);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(137, 20);
            this.textBoxFloor.TabIndex = 40;
            this.textBoxFloor.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFloor_Validating);
            // 
            // textBoxStreetNum
            // 
            this.textBoxStreetNum.Location = new System.Drawing.Point(125, 50);
            this.textBoxStreetNum.Name = "textBoxStreetNum";
            this.textBoxStreetNum.Size = new System.Drawing.Size(137, 20);
            this.textBoxStreetNum.TabIndex = 39;
            this.textBoxStreetNum.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStreetNum_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Floor";
            // 
            // dtPickerBirhtDate
            // 
            this.dtPickerBirhtDate.Location = new System.Drawing.Point(143, 166);
            this.dtPickerBirhtDate.Name = "dtPickerBirhtDate";
            this.dtPickerBirhtDate.Size = new System.Drawing.Size(137, 20);
            this.dtPickerBirhtDate.TabIndex = 42;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(143, 140);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(137, 20);
            this.textBoxPhone.TabIndex = 32;
            this.textBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPhone_Validating_1);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(449, 28);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(137, 20);
            this.textBoxEmail.TabIndex = 31;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating_1);
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(143, 83);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(137, 21);
            this.comboBoxDocType.TabIndex = 30;
            this.comboBoxDocType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxDocType_Validating_1);
            // 
            // textBoxDocNumber
            // 
            this.textBoxDocNumber.Location = new System.Drawing.Point(143, 110);
            this.textBoxDocNumber.Name = "textBoxDocNumber";
            this.textBoxDocNumber.Size = new System.Drawing.Size(137, 20);
            this.textBoxDocNumber.TabIndex = 29;
            this.textBoxDocNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDocNumber_Validating_1);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(143, 54);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(137, 20);
            this.textBoxLastname.TabIndex = 28;
            this.textBoxLastname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastname_Validating);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(137, 20);
            this.textBoxName.TabIndex = 27;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating_1);
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(333, 57);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(56, 13);
            this.labelNationality.TabIndex = 26;
            this.labelNationality.Text = "Nationality";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(21, 172);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(54, 13);
            this.labelBirthDate.TabIndex = 24;
            this.labelBirthDate.Text = "Birth Date";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(21, 140);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 13);
            this.labelPhone.TabIndex = 23;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(333, 31);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "E-mail";
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(20, 114);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(96, 13);
            this.labelDocNumber.TabIndex = 21;
            this.labelDocNumber.Text = "Document Number";
            // 
            // labelDocType
            // 
            this.labelDocType.AutoSize = true;
            this.labelDocType.Location = new System.Drawing.Point(20, 91);
            this.labelDocType.Name = "labelDocType";
            this.labelDocType.Size = new System.Drawing.Size(83, 13);
            this.labelDocType.TabIndex = 19;
            this.labelDocType.Text = "Document Type";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(20, 57);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(53, 13);
            this.labelLastname.TabIndex = 18;
            this.labelLastname.Text = "Lastname";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UpdateGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 287);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxGuest);
            this.Name = "UpdateGuest";
            this.Text = "UpdateGuest";
            this.groupBoxGuest.ResumeLayout(false);
            this.groupBoxGuest.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelText;
        public System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.GroupBox groupBoxGuest;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxStreet;
        public System.Windows.Forms.TextBox textBoxDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxFloor;
        public System.Windows.Forms.TextBox textBoxStreetNum;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtPickerBirhtDate;
        public System.Windows.Forms.TextBox textBoxPhone;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.ComboBox comboBoxDocType;
        public System.Windows.Forms.TextBox textBoxDocNumber;
        public System.Windows.Forms.TextBox textBoxLastname;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.Label labelNationality;
        public System.Windows.Forms.Label labelBirthDate;
        public System.Windows.Forms.Label labelPhone;
        public System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.Label labelDocNumber;
        public System.Windows.Forms.Label labelDocType;
        public System.Windows.Forms.Label labelLastname;
        public System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.ComboBox comboBoxNationality;
    }
}