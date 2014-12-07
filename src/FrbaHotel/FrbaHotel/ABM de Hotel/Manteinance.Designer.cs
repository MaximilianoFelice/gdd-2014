namespace FrbaHotel.ABM_de_Hotel
{
    partial class Manteinance
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelEnd = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelDescr = new System.Windows.Forms.Label();
            this.textBoxDescr = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxDescr);
            this.groupBox.Controls.Add(this.labelDescr);
            this.groupBox.Controls.Add(this.dateTimePickerEnd);
            this.groupBox.Controls.Add(this.labelEnd);
            this.groupBox.Controls.Add(this.dateTimePickerStart);
            this.groupBox.Controls.Add(this.labelStart);
            this.groupBox.Controls.Add(this.textBox1);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(470, 186);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Please enter the maintenance information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(17, 71);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(120, 13);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "Manteinance Start Date";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(161, 65);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(273, 20);
            this.dateTimePickerStart.TabIndex = 3;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(17, 110);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(117, 13);
            this.labelEnd.TabIndex = 4;
            this.labelEnd.Text = "Manteinance End Date";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(161, 104);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(273, 20);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // labelDescr
            // 
            this.labelDescr.AutoSize = true;
            this.labelDescr.Location = new System.Drawing.Point(17, 146);
            this.labelDescr.Name = "labelDescr";
            this.labelDescr.Size = new System.Drawing.Size(60, 13);
            this.labelDescr.TabIndex = 6;
            this.labelDescr.Text = "Description";
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.Location = new System.Drawing.Point(161, 143);
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.Size = new System.Drawing.Size(273, 20);
            this.textBoxDescr.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 204);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(407, 204);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // Manteinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 242);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox);
            this.Name = "Manteinance";
            this.Text = "Manteinance";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDescr;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox textBoxDescr;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
    }
}