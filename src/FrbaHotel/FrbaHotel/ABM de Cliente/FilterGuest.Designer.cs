namespace FrbaHotel.ABM_de_Cliente
{
    partial class FilterGuest
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
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.textBoxDocNumber = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDocNumber = new System.Windows.Forms.Label();
            this.labelDocType = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(9, 188);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(641, 176);
            this.dataGridViewResults.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(566, 148);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 148);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.comboBoxDocType);
            this.groupBox1.Controls.Add(this.textBoxDocNumber);
            this.groupBox1.Controls.Add(this.textBoxLastname);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelDocNumber);
            this.groupBox1.Controls.Add(this.labelDocType);
            this.groupBox1.Controls.Add(this.labelLastname);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(466, 54);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(137, 20);
            this.textBoxEmail.TabIndex = 31;
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Items.AddRange(new object[] {
            "ID - Identity Document",
            "Passport",
            "IC-Identity Card",
            "Driving License"});
            this.comboBoxDocType.Location = new System.Drawing.Point(143, 80);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(137, 21);
            this.comboBoxDocType.TabIndex = 30;
            // 
            // textBoxDocNumber
            // 
            this.textBoxDocNumber.Location = new System.Drawing.Point(466, 28);
            this.textBoxDocNumber.Name = "textBoxDocNumber";
            this.textBoxDocNumber.Size = new System.Drawing.Size(137, 20);
            this.textBoxDocNumber.TabIndex = 29;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(143, 54);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(137, 20);
            this.textBoxLastname.TabIndex = 28;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(137, 20);
            this.textBoxName.TabIndex = 27;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(340, 57);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "E-mail";
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(340, 31);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(96, 13);
            this.labelDocNumber.TabIndex = 21;
            this.labelDocNumber.Text = "Document Number";
            // 
            // labelDocType
            // 
            this.labelDocType.AutoSize = true;
            this.labelDocType.Location = new System.Drawing.Point(21, 83);
            this.labelDocType.Name = "labelDocType";
            this.labelDocType.Size = new System.Drawing.Size(83, 13);
            this.labelDocType.TabIndex = 19;
            this.labelDocType.Text = "Document Type";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(21, 57);
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
            // FilterGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 376);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilterGuest";
            this.Text = "FilterGuest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.TextBox textBoxDocNumber;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDocNumber;
        private System.Windows.Forms.Label labelDocType;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelName;
    }
}