namespace FrbaHotel.Registrar_Consumible
{
    partial class CreateExtra
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
            this.buttonclear = new System.Windows.Forms.Button();
            this.dataGridViewExtras = new System.Windows.Forms.DataGridView();
            this.buttonBill = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelExtra = new System.Windows.Forms.Label();
            this.comboBoxExtra = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(12, 380);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(105, 23);
            this.buttonclear.TabIndex = 1;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // dataGridViewExtras
            // 
            this.dataGridViewExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExtras.Location = new System.Drawing.Point(12, 147);
            this.dataGridViewExtras.Name = "dataGridViewExtras";
            this.dataGridViewExtras.Size = new System.Drawing.Size(496, 227);
            this.dataGridViewExtras.TabIndex = 3;
            // 
            // buttonBill
            // 
            this.buttonBill.Location = new System.Drawing.Point(403, 380);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(105, 23);
            this.buttonBill.TabIndex = 5;
            this.buttonBill.Text = "Bill";
            this.buttonBill.UseVisualStyleBackColor = true;
            this.buttonBill.Click += new System.EventHandler(this.buttonBill_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(12, 118);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(105, 23);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove Item -";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelExtra
            // 
            this.labelExtra.AutoSize = true;
            this.labelExtra.Location = new System.Drawing.Point(111, 36);
            this.labelExtra.Name = "labelExtra";
            this.labelExtra.Size = new System.Drawing.Size(36, 13);
            this.labelExtra.TabIndex = 7;
            this.labelExtra.Text = "Extras";
            // 
            // comboBoxExtra
            // 
            this.comboBoxExtra.FormattingEnabled = true;
            this.comboBoxExtra.Location = new System.Drawing.Point(195, 33);
            this.comboBoxExtra.Name = "comboBoxExtra";
            this.comboBoxExtra.Size = new System.Drawing.Size(195, 21);
            this.comboBoxExtra.TabIndex = 8;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(111, 68);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 9;
            this.labelQuantity.Text = "Quantity";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(195, 66);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(195, 20);
            this.numericUpDown.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(403, 118);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add Item +";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.comboBoxExtra);
            this.groupBox.Controls.Add(this.labelExtra);
            this.groupBox.Controls.Add(this.labelQuantity);
            this.groupBox.Controls.Add(this.numericUpDown);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(496, 100);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Please enter all the extras consume during the stay ";
            // 
            // CreateExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 417);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonBill);
            this.Controls.Add(this.dataGridViewExtras);
            this.Controls.Add(this.buttonclear);
            this.Name = "CreateExtra";
            this.Text = "Register Extra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.DataGridView dataGridViewExtras;
        private System.Windows.Forms.Button buttonBill;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelExtra;
        private System.Windows.Forms.ComboBox comboBoxExtra;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox;
    }
}