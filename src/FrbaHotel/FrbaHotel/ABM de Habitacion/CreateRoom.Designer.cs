﻿namespace FrbaHotel.ABM_de_Habitacion
{
    partial class CreateRoom
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
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxLoc = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxDescr = new System.Windows.Forms.TextBox();
            this.labelTpye = new System.Windows.Forms.Label();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.labelFloor = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.comboBoxType);
            this.groupBoxData.Controls.Add(this.comboBoxLoc);
            this.groupBoxData.Controls.Add(this.labelDescription);
            this.groupBoxData.Controls.Add(this.labelLocation);
            this.groupBoxData.Controls.Add(this.textBoxDescr);
            this.groupBoxData.Controls.Add(this.labelTpye);
            this.groupBoxData.Controls.Add(this.textBoxFloor);
            this.groupBoxData.Controls.Add(this.labelFloor);
            this.groupBoxData.Controls.Add(this.textBoxNumber);
            this.groupBoxData.Controls.Add(this.labelNumber);
            this.groupBoxData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(268, 188);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Please enter the room information";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(106, 79);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(141, 21);
            this.comboBoxType.TabIndex = 12;
            this.comboBoxType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxType_Validating);
            // 
            // comboBoxLoc
            // 
            this.comboBoxLoc.FormattingEnabled = true;
            this.comboBoxLoc.Location = new System.Drawing.Point(106, 106);
            this.comboBoxLoc.Name = "comboBoxLoc";
            this.comboBoxLoc.Size = new System.Drawing.Size(141, 21);
            this.comboBoxLoc.TabIndex = 11;
            this.comboBoxLoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoc_SelectedIndexChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(9, 137);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(9, 109);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 8;
            this.labelLocation.Text = "Location";
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.Location = new System.Drawing.Point(106, 134);
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.Size = new System.Drawing.Size(141, 20);
            this.textBoxDescr.TabIndex = 7;
            this.textBoxDescr.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescr_Validating);
            // 
            // labelTpye
            // 
            this.labelTpye.AutoSize = true;
            this.labelTpye.Location = new System.Drawing.Point(9, 82);
            this.labelTpye.Name = "labelTpye";
            this.labelTpye.Size = new System.Drawing.Size(62, 13);
            this.labelTpye.TabIndex = 6;
            this.labelTpye.Text = "Room Type";
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(106, 53);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(141, 20);
            this.textBoxFloor.TabIndex = 5;
            this.textBoxFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFloor_KeyPress);
            this.textBoxFloor.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFloor_Validating);
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(9, 57);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(61, 13);
            this.labelFloor.TabIndex = 4;
            this.labelFloor.Text = "Room Floor";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(106, 27);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(141, 20);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            this.textBoxNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumber_Validating);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(9, 30);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(75, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Room Number";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(205, 206);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 206);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 243);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxData);
            this.Name = "CreateRoom";
            this.Text = "Create Room";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxFloor;
        public System.Windows.Forms.Label labelFloor;
        public System.Windows.Forms.TextBox textBoxNumber;
        public System.Windows.Forms.Label labelNumber;
        public System.Windows.Forms.Label labelDescription;
        public System.Windows.Forms.Label labelLocation;
        public System.Windows.Forms.TextBox textBoxDescr;
        public System.Windows.Forms.Label labelTpye;
        public System.Windows.Forms.ComboBox comboBoxType;
        public System.Windows.Forms.ComboBox comboBoxLoc;
        public System.Windows.Forms.GroupBox groupBoxData;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.ErrorProvider errorProvider;
    }
}