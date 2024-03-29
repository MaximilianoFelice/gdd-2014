﻿namespace FrbaHotel.Generar_Modificar_Reserva
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxHotel = new System.Windows.Forms.GroupBox();
            this.labelRegimen = new System.Windows.Forms.Label();
            this.comboBoxRegimen = new System.Windows.Forms.ComboBox();
            this.labelHotel = new System.Windows.Forms.Label();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.groupBoxArrival = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEnd = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.groupBoxRoom = new System.Windows.Forms.GroupBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelGuests = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAvailability = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxHotel.SuspendLayout();
            this.groupBoxArrival.SuspendLayout();
            this.groupBoxRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxHotel
            // 
            this.groupBoxHotel.Controls.Add(this.labelRegimen);
            this.groupBoxHotel.Controls.Add(this.comboBoxRegimen);
            this.groupBoxHotel.Controls.Add(this.labelHotel);
            this.groupBoxHotel.Controls.Add(this.comboBoxHotel);
            this.groupBoxHotel.Location = new System.Drawing.Point(13, 13);
            this.groupBoxHotel.Name = "groupBoxHotel";
            this.groupBoxHotel.Size = new System.Drawing.Size(392, 100);
            this.groupBoxHotel.TabIndex = 0;
            this.groupBoxHotel.TabStop = false;
            this.groupBoxHotel.Text = "Hotel Information";
            // 
            // labelRegimen
            // 
            this.labelRegimen.AutoSize = true;
            this.labelRegimen.Location = new System.Drawing.Point(22, 60);
            this.labelRegimen.Name = "labelRegimen";
            this.labelRegimen.Size = new System.Drawing.Size(49, 13);
            this.labelRegimen.TabIndex = 3;
            this.labelRegimen.Text = "Regimen";
            // 
            // comboBoxRegimen
            // 
            this.comboBoxRegimen.FormattingEnabled = true;
            this.comboBoxRegimen.Location = new System.Drawing.Point(151, 57);
            this.comboBoxRegimen.Name = "comboBoxRegimen";
            this.comboBoxRegimen.Size = new System.Drawing.Size(197, 21);
            this.comboBoxRegimen.TabIndex = 2;
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(22, 23);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(32, 13);
            this.labelHotel.TabIndex = 1;
            this.labelHotel.Text = "Hotel";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(151, 20);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHotel.TabIndex = 0;
            this.comboBoxHotel.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxHotel_Validating);
            this.comboBoxHotel.SelectedValueChanged += new System.EventHandler(this.comboBoxHotel_SelectedValueChanged);
            // 
            // groupBoxArrival
            // 
            this.groupBoxArrival.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxArrival.Controls.Add(this.labelEnd);
            this.groupBoxArrival.Controls.Add(this.dateTimePickerStart);
            this.groupBoxArrival.Controls.Add(this.labelStart);
            this.groupBoxArrival.Location = new System.Drawing.Point(13, 119);
            this.groupBoxArrival.Name = "groupBoxArrival";
            this.groupBoxArrival.Size = new System.Drawing.Size(392, 100);
            this.groupBoxArrival.TabIndex = 1;
            this.groupBoxArrival.TabStop = false;
            this.groupBoxArrival.Text = "Arrival information";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(151, 68);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerEnd_Validating);
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(25, 68);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(82, 13);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "Check-out Date";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(151, 31);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(25, 31);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(76, 13);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Check-In Date";
            // 
            // groupBoxRoom
            // 
            this.groupBoxRoom.Controls.Add(this.comboBoxRoomType);
            this.groupBoxRoom.Controls.Add(this.labelRoom);
            this.groupBoxRoom.Controls.Add(this.numericUpDown);
            this.groupBoxRoom.Controls.Add(this.labelGuests);
            this.groupBoxRoom.Location = new System.Drawing.Point(13, 226);
            this.groupBoxRoom.Name = "groupBoxRoom";
            this.groupBoxRoom.Size = new System.Drawing.Size(393, 100);
            this.groupBoxRoom.TabIndex = 2;
            this.groupBoxRoom.TabStop = false;
            this.groupBoxRoom.Text = "Guests and Room Information";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(151, 68);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRoomType.TabIndex = 3;
            this.comboBoxRoomType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxRoomType_Validating);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(28, 68);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(62, 13);
            this.labelRoom.TabIndex = 2;
            this.labelRoom.Text = "Room Type";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(151, 35);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown.TabIndex = 1;
            // 
            // labelGuests
            // 
            this.labelGuests.AutoSize = true;
            this.labelGuests.Location = new System.Drawing.Point(25, 35);
            this.labelGuests.Name = "labelGuests";
            this.labelGuests.Size = new System.Drawing.Size(67, 13);
            this.labelGuests.TabIndex = 0;
            this.labelGuests.Text = "Extra Guests";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(13, 333);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAvailability
            // 
            this.buttonAvailability.Location = new System.Drawing.Point(280, 333);
            this.buttonAvailability.Name = "buttonAvailability";
            this.buttonAvailability.Size = new System.Drawing.Size(116, 23);
            this.buttonAvailability.TabIndex = 4;
            this.buttonAvailability.Text = "Check Availability";
            this.buttonAvailability.UseVisualStyleBackColor = true;
            this.buttonAvailability.Click += new System.EventHandler(this.buttonAvailability_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 362);
            this.Controls.Add(this.buttonAvailability);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxRoom);
            this.Controls.Add(this.groupBoxArrival);
            this.Controls.Add(this.groupBoxHotel);
            this.Name = "CreateBooking";
            this.Text = "CreateBooking";
            this.groupBoxHotel.ResumeLayout(false);
            this.groupBoxHotel.PerformLayout();
            this.groupBoxArrival.ResumeLayout(false);
            this.groupBoxArrival.PerformLayout();
            this.groupBoxRoom.ResumeLayout(false);
            this.groupBoxRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHotel;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.Label labelRegimen;
        private System.Windows.Forms.ComboBox comboBoxRegimen;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.GroupBox groupBoxArrival;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.GroupBox groupBoxRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label labelGuests;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAvailability;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}