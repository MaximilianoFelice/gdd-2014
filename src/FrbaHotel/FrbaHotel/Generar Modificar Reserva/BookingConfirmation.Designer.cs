namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class BookingConfirmation
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
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHotel = new System.Windows.Forms.Label();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.labelGuests = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxHotel = new System.Windows.Forms.TextBox();
            this.textBoxRegimen = new System.Windows.Forms.TextBox();
            this.textBoxRoomType = new System.Windows.Forms.TextBox();
            this.textBoxExtraGuests = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.textBoxExtraGuests);
            this.groupBoxDetails.Controls.Add(this.textBoxRoomType);
            this.groupBoxDetails.Controls.Add(this.textBoxRegimen);
            this.groupBoxDetails.Controls.Add(this.textBoxHotel);
            this.groupBoxDetails.Controls.Add(this.labelGuests);
            this.groupBoxDetails.Controls.Add(this.labelRoomType);
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Controls.Add(this.labelHotel);
            this.groupBoxDetails.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(303, 173);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Booking Details";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(17, 97);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(62, 13);
            this.labelRoomType.TabIndex = 2;
            this.labelRoomType.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regimen";
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(17, 30);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(32, 13);
            this.labelHotel.TabIndex = 0;
            this.labelHotel.Text = "Hotel";
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.textBoxTotalPrice);
            this.groupBoxPrice.Controls.Add(this.labelPrice);
            this.groupBoxPrice.Location = new System.Drawing.Point(13, 192);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(303, 69);
            this.groupBoxPrice.TabIndex = 1;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "Price";
            // 
            // labelGuests
            // 
            this.labelGuests.AutoSize = true;
            this.labelGuests.Location = new System.Drawing.Point(17, 130);
            this.labelGuests.Name = "labelGuests";
            this.labelGuests.Size = new System.Drawing.Size(67, 13);
            this.labelGuests.TabIndex = 3;
            this.labelGuests.Text = "Extra Guests";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(17, 35);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 13);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Total Price";
            // 
            // textBoxHotel
            // 
            this.textBoxHotel.Location = new System.Drawing.Point(132, 27);
            this.textBoxHotel.Name = "textBoxHotel";
            this.textBoxHotel.ReadOnly = true;
            this.textBoxHotel.Size = new System.Drawing.Size(151, 20);
            this.textBoxHotel.TabIndex = 4;
            // 
            // textBoxRegimen
            // 
            this.textBoxRegimen.Location = new System.Drawing.Point(132, 62);
            this.textBoxRegimen.Name = "textBoxRegimen";
            this.textBoxRegimen.ReadOnly = true;
            this.textBoxRegimen.Size = new System.Drawing.Size(151, 20);
            this.textBoxRegimen.TabIndex = 5;
            // 
            // textBoxRoomType
            // 
            this.textBoxRoomType.Location = new System.Drawing.Point(132, 94);
            this.textBoxRoomType.Name = "textBoxRoomType";
            this.textBoxRoomType.ReadOnly = true;
            this.textBoxRoomType.Size = new System.Drawing.Size(151, 20);
            this.textBoxRoomType.TabIndex = 6;
            // 
            // textBoxExtraGuests
            // 
            this.textBoxExtraGuests.Location = new System.Drawing.Point(132, 127);
            this.textBoxExtraGuests.Name = "textBoxExtraGuests";
            this.textBoxExtraGuests.ReadOnly = true;
            this.textBoxExtraGuests.Size = new System.Drawing.Size(151, 20);
            this.textBoxExtraGuests.TabIndex = 7;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(132, 32);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(151, 20);
            this.textBoxTotalPrice.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 284);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(241, 284);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // BookingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 321);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxPrice);
            this.Controls.Add(this.groupBoxDetails);
            this.Name = "BookingConfirmation";
            this.Text = "Booking Confirmation";
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxPrice.ResumeLayout(false);
            this.groupBoxPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.GroupBox groupBoxPrice;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.TextBox textBoxExtraGuests;
        private System.Windows.Forms.TextBox textBoxRoomType;
        private System.Windows.Forms.TextBox textBoxRegimen;
        private System.Windows.Forms.TextBox textBoxHotel;
        private System.Windows.Forms.Label labelGuests;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
    }
}