namespace FrbaHotel.ABM_de_Hotel
{
    partial class UpdateHotel
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxReg = new System.Windows.Forms.CheckedListBox();
            this.numericUDStars = new System.Windows.Forms.NumericUpDown();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreetNum = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelCreationDate = new System.Windows.Forms.Label();
            this.labelRegimens = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreetNum = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(613, 255);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 255);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCountry);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.checkedListBoxReg);
            this.groupBox1.Controls.Add(this.numericUDStars);
            this.groupBox1.Controls.Add(this.textBoxCity);
            this.groupBox1.Controls.Add(this.textBoxStreetNum);
            this.groupBox1.Controls.Add(this.textBoxStreet);
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.labelCreationDate);
            this.groupBox1.Controls.Add(this.labelRegimens);
            this.groupBox1.Controls.Add(this.labelCountry);
            this.groupBox1.Controls.Add(this.labelStars);
            this.groupBox1.Controls.Add(this.labelCity);
            this.groupBox1.Controls.Add(this.labelStreetNum);
            this.groupBox1.Controls.Add(this.labelStreet);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 237);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please enter the hotel information";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(440, 191);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker.TabIndex = 19;
            // 
            // checkedListBoxReg
            // 
            this.checkedListBoxReg.FormattingEnabled = true;
            this.checkedListBoxReg.Location = new System.Drawing.Point(440, 91);
            this.checkedListBoxReg.Name = "checkedListBoxReg";
            this.checkedListBoxReg.Size = new System.Drawing.Size(195, 94);
            this.checkedListBoxReg.TabIndex = 18;
            // 
            // numericUDStars
            // 
            this.numericUDStars.Location = new System.Drawing.Point(440, 65);
            this.numericUDStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUDStars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDStars.Name = "numericUDStars";
            this.numericUDStars.Size = new System.Drawing.Size(195, 20);
            this.numericUDStars.TabIndex = 16;
            this.numericUDStars.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(96, 171);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(195, 20);
            this.textBoxCity.TabIndex = 15;
            this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity_KeyPress);
            this.textBoxCity.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCity_Validating);
            // 
            // textBoxStreetNum
            // 
            this.textBoxStreetNum.Location = new System.Drawing.Point(96, 145);
            this.textBoxStreetNum.Name = "textBoxStreetNum";
            this.textBoxStreetNum.Size = new System.Drawing.Size(195, 20);
            this.textBoxStreetNum.TabIndex = 14;
            this.textBoxStreetNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStreetNum_KeyPress);
            this.textBoxStreetNum.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStreetNum_Validating);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(96, 117);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(195, 20);
            this.textBoxStreet.TabIndex = 13;
            this.textBoxStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStreet_KeyPress);
            this.textBoxStreet.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStreet_Validating);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(96, 90);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(195, 20);
            this.textBoxPhone.TabIndex = 12;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            this.textBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPhone_Validating);
            // 
            // labelCreationDate
            // 
            this.labelCreationDate.AutoSize = true;
            this.labelCreationDate.Location = new System.Drawing.Point(352, 197);
            this.labelCreationDate.Name = "labelCreationDate";
            this.labelCreationDate.Size = new System.Drawing.Size(72, 13);
            this.labelCreationDate.TabIndex = 11;
            this.labelCreationDate.Text = "Creation Date";
            // 
            // labelRegimens
            // 
            this.labelRegimens.AutoSize = true;
            this.labelRegimens.Location = new System.Drawing.Point(352, 93);
            this.labelRegimens.Name = "labelRegimens";
            this.labelRegimens.Size = new System.Drawing.Size(54, 13);
            this.labelRegimens.TabIndex = 10;
            this.labelRegimens.Text = "Regimens";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(352, 41);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Country";
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Location = new System.Drawing.Point(352, 67);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(31, 13);
            this.labelStars.TabIndex = 8;
            this.labelStars.Text = "Stars";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(25, 174);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "City";
            // 
            // labelStreetNum
            // 
            this.labelStreetNum.AutoSize = true;
            this.labelStreetNum.Location = new System.Drawing.Point(22, 148);
            this.labelStreetNum.Name = "labelStreetNum";
            this.labelStreetNum.Size = new System.Drawing.Size(60, 13);
            this.labelStreetNum.TabIndex = 6;
            this.labelStreetNum.Text = "Street Num";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(25, 120);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(35, 13);
            this.labelStreet.TabIndex = 5;
            this.labelStreet.Text = "Street";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(25, 93);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(96, 64);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(195, 20);
            this.textBoxMail.TabIndex = 3;
            this.textBoxMail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMail_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mail";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = " Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(96, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(440, 35);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(195, 21);
            this.comboBoxCountry.TabIndex = 20;
            this.comboBoxCountry.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCountry_Validating);
            // 
            // UpdateHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 294);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateHotel";
            this.Text = "UpdateHotel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.CheckedListBox checkedListBoxReg;
        public System.Windows.Forms.NumericUpDown numericUDStars;
        public System.Windows.Forms.TextBox textBoxCity;
        public System.Windows.Forms.TextBox textBoxStreetNum;
        public System.Windows.Forms.TextBox textBoxStreet;
        public System.Windows.Forms.TextBox textBoxPhone;
        public System.Windows.Forms.Label labelCreationDate;
        public System.Windows.Forms.Label labelRegimens;
        public System.Windows.Forms.Label labelCountry;
        public System.Windows.Forms.Label labelStars;
        public System.Windows.Forms.Label labelCity;
        public System.Windows.Forms.Label labelStreetNum;
        public System.Windows.Forms.Label labelStreet;
        public System.Windows.Forms.Label labelPhone;
        public System.Windows.Forms.TextBox textBoxMail;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox comboBoxCountry;
    }
}