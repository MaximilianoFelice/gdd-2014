namespace FrbaHotel.ABM_de_Hotel
{
    partial class FilterHotel
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxStars = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonManteinance = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxCountry);
            this.groupBox.Controls.Add(this.textBoxCity);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.comboBoxStars);
            this.groupBox.Controls.Add(this.labelCountry);
            this.groupBox.Controls.Add(this.labelCity);
            this.groupBox.Controls.Add(this.labelStars);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Location = new System.Drawing.Point(13, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(542, 100);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Search Filters";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Location = new System.Drawing.Point(17, 54);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(31, 13);
            this.labelStars.TabIndex = 1;
            this.labelStars.Text = "Stars";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(293, 28);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(293, 54);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 3;
            this.labelCountry.Text = "Country";
            // 
            // comboBoxStars
            // 
            this.comboBoxStars.FormattingEnabled = true;
            this.comboBoxStars.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxStars.Location = new System.Drawing.Point(81, 51);
            this.comboBoxStars.Name = "comboBoxStars";
            this.comboBoxStars.Size = new System.Drawing.Size(155, 21);
            this.comboBoxStars.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(81, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(358, 25);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(155, 20);
            this.textBoxCity.TabIndex = 6;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(358, 51);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(155, 20);
            this.textBoxCountry.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(13, 120);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "button1";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(480, 120);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(480, 306);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonManteinance
            // 
            this.buttonManteinance.Location = new System.Drawing.Point(347, 306);
            this.buttonManteinance.Name = "buttonManteinance";
            this.buttonManteinance.Size = new System.Drawing.Size(127, 23);
            this.buttonManteinance.TabIndex = 5;
            this.buttonManteinance.Text = "Close for Manteinance";
            this.buttonManteinance.UseVisualStyleBackColor = true;
            // 
            // FilterHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 338);
            this.Controls.Add(this.buttonManteinance);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox);
            this.Name = "FilterHotel";
            this.Text = "FilterHotel";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxStars;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonManteinance;
    }
}