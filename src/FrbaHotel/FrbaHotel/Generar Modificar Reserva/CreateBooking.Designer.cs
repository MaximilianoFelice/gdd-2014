namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class CreateBooking
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
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.labelHotel = new System.Windows.Forms.Label();
            this.monthCalendarCheckin = new System.Windows.Forms.MonthCalendar();
            this.labelCheckin = new System.Windows.Forms.Label();
            this.monthCalendarCheckout = new System.Windows.Forms.MonthCalendar();
            this.labelCheckout = new System.Windows.Forms.Label();
            this.comboBoxRegimen = new System.Windows.Forms.ComboBox();
            this.labelRegimen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDocNumber = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelDocNumber = new System.Windows.Forms.Label();
            this.textBoxExtraGuests = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxExtraGuests);
            this.groupBox1.Controls.Add(this.labelDocNumber);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxDocNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelRegimen);
            this.groupBox1.Controls.Add(this.comboBoxRegimen);
            this.groupBox1.Controls.Add(this.labelCheckout);
            this.groupBox1.Controls.Add(this.monthCalendarCheckout);
            this.groupBox1.Controls.Add(this.labelCheckin);
            this.groupBox1.Controls.Add(this.monthCalendarCheckin);
            this.groupBox1.Controls.Add(this.labelHotel);
            this.groupBox1.Controls.Add(this.comboBoxHotel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please enter the booking information";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(161, 32);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(227, 21);
            this.comboBoxHotel.TabIndex = 0;
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(15, 40);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(32, 13);
            this.labelHotel.TabIndex = 1;
            this.labelHotel.Text = "Hotel";
            // 
            // monthCalendarCheckin
            // 
            this.monthCalendarCheckin.Location = new System.Drawing.Point(161, 170);
            this.monthCalendarCheckin.Name = "monthCalendarCheckin";
            this.monthCalendarCheckin.TabIndex = 2;
            // 
            // labelCheckin
            // 
            this.labelCheckin.AutoSize = true;
            this.labelCheckin.Location = new System.Drawing.Point(15, 170);
            this.labelCheckin.Name = "labelCheckin";
            this.labelCheckin.Size = new System.Drawing.Size(75, 13);
            this.labelCheckin.TabIndex = 3;
            this.labelCheckin.Text = "Check-in Date";
            // 
            // monthCalendarCheckout
            // 
            this.monthCalendarCheckout.Location = new System.Drawing.Point(602, 170);
            this.monthCalendarCheckout.Name = "monthCalendarCheckout";
            this.monthCalendarCheckout.TabIndex = 4;
            // 
            // labelCheckout
            // 
            this.labelCheckout.AutoSize = true;
            this.labelCheckout.Location = new System.Drawing.Point(452, 170);
            this.labelCheckout.Name = "labelCheckout";
            this.labelCheckout.Size = new System.Drawing.Size(82, 13);
            this.labelCheckout.TabIndex = 5;
            this.labelCheckout.Text = "Check-out Date";
            // 
            // comboBoxRegimen
            // 
            this.comboBoxRegimen.FormattingEnabled = true;
            this.comboBoxRegimen.Location = new System.Drawing.Point(602, 32);
            this.comboBoxRegimen.Name = "comboBoxRegimen";
            this.comboBoxRegimen.Size = new System.Drawing.Size(227, 21);
            this.comboBoxRegimen.TabIndex = 6;
            // 
            // labelRegimen
            // 
            this.labelRegimen.AutoSize = true;
            this.labelRegimen.Location = new System.Drawing.Point(443, 35);
            this.labelRegimen.Name = "labelRegimen";
            this.labelRegimen.Size = new System.Drawing.Size(76, 13);
            this.labelRegimen.TabIndex = 7;
            this.labelRegimen.Text = "Regimen Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Extra Guests";
            // 
            // textBoxDocNumber
            // 
            this.textBoxDocNumber.Location = new System.Drawing.Point(602, 74);
            this.textBoxDocNumber.Name = "textBoxDocNumber";
            this.textBoxDocNumber.Size = new System.Drawing.Size(227, 20);
            this.textBoxDocNumber.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(140, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Booking Holder\'s Doc. Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(443, 77);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(153, 13);
            this.labelDocNumber.TabIndex = 12;
            this.labelDocNumber.Text = "Booking Holder\'s Doc. Number";
            // 
            // textBoxExtraGuests
            // 
            this.textBoxExtraGuests.Location = new System.Drawing.Point(161, 122);
            this.textBoxExtraGuests.Name = "textBoxExtraGuests";
            this.textBoxExtraGuests.Size = new System.Drawing.Size(227, 20);
            this.textBoxExtraGuests.TabIndex = 13;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 379);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 29);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(766, 379);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(89, 29);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 420);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateBooking";
            this.Text = "Create Booking";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCheckout;
        private System.Windows.Forms.MonthCalendar monthCalendarCheckout;
        private System.Windows.Forms.Label labelCheckin;
        private System.Windows.Forms.MonthCalendar monthCalendarCheckin;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRegimen;
        private System.Windows.Forms.ComboBox comboBoxRegimen;
        private System.Windows.Forms.Label labelDocNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDocNumber;
        private System.Windows.Forms.TextBox textBoxExtraGuests;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
    }
}