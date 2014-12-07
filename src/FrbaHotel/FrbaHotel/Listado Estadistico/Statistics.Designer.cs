namespace FrbaHotel.Listado_Estadistico
{
    partial class Statistics
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxLFilter = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCriteria = new System.Windows.Forms.ComboBox();
            this.comboBoxQuarter = new System.Windows.Forms.ComboBox();
            this.labelQuarter = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxCriteria);
            this.groupBox1.Location = new System.Drawing.Point(272, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics Filters";
            // 
            // checkBoxLFilter
            // 
            this.checkBoxLFilter.FormattingEnabled = true;
            this.checkBoxLFilter.Location = new System.Drawing.Point(20, 57);
            this.checkBoxLFilter.Name = "checkBoxLFilter";
            this.checkBoxLFilter.Size = new System.Drawing.Size(245, 94);
            this.checkBoxLFilter.TabIndex = 2;
            this.checkBoxLFilter.Validating += new System.ComponentModel.CancelEventHandler(this.checkBoxLFilter_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Filter Top 5";
            // 
            // comboBoxCriteria
            // 
            this.comboBoxCriteria.FormattingEnabled = true;
            this.comboBoxCriteria.Items.AddRange(new object[] {
            "Hotels",
            "Rooms",
            "Guests"});
            this.comboBoxCriteria.Location = new System.Drawing.Point(113, 30);
            this.comboBoxCriteria.Name = "comboBoxCriteria";
            this.comboBoxCriteria.Size = new System.Drawing.Size(152, 21);
            this.comboBoxCriteria.TabIndex = 0;
            this.comboBoxCriteria.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCriteria_Validating);
            this.comboBoxCriteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriteria_SelectedIndexChanged);
            // 
            // comboBoxQuarter
            // 
            this.comboBoxQuarter.FormattingEnabled = true;
            this.comboBoxQuarter.Location = new System.Drawing.Point(76, 42);
            this.comboBoxQuarter.Name = "comboBoxQuarter";
            this.comboBoxQuarter.Size = new System.Drawing.Size(181, 21);
            this.comboBoxQuarter.TabIndex = 1;
            // 
            // labelQuarter
            // 
            this.labelQuarter.AutoSize = true;
            this.labelQuarter.Location = new System.Drawing.Point(12, 45);
            this.labelQuarter.Name = "labelQuarter";
            this.labelQuarter.Size = new System.Drawing.Size(42, 13);
            this.labelQuarter.TabIndex = 2;
            this.labelQuarter.Text = "Quarter";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(15, 78);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Year";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(167, 210);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(148, 23);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Show Top 5";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(15, 260);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(554, 150);
            this.dataGridViewResults.TabIndex = 6;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(76, 76);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(181, 20);
            this.numericUpDownYear.TabIndex = 7;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 424);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelQuarter);
            this.Controls.Add(this.comboBoxQuarter);
            this.Controls.Add(this.groupBox1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCriteria;
        private System.Windows.Forms.CheckedListBox checkBoxLFilter;
        private System.Windows.Forms.ComboBox comboBoxQuarter;
        private System.Windows.Forms.Label labelQuarter;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}