namespace FrbaHotel.ABM_de_Habitacion
{
    partial class FilterRoom
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelFloor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelTpye = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.comboBoxLoc = new System.Windows.Forms.ComboBox();
            this.textBoxDescr = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(542, 370);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(108, 23);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(9, 188);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(641, 176);
            this.dataGridViewResults.TabIndex = 14;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(566, 148);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 148);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.textBoxState);
            this.groupBoxFilters.Controls.Add(this.comboBoxType);
            this.groupBoxFilters.Controls.Add(this.labelFloor);
            this.groupBoxFilters.Controls.Add(this.label1);
            this.groupBoxFilters.Controls.Add(this.textBoxFloor);
            this.groupBoxFilters.Controls.Add(this.textBoxNumber);
            this.groupBoxFilters.Controls.Add(this.labelTpye);
            this.groupBoxFilters.Controls.Add(this.labelNumber);
            this.groupBoxFilters.Controls.Add(this.comboBoxLoc);
            this.groupBoxFilters.Controls.Add(this.textBoxDescr);
            this.groupBoxFilters.Controls.Add(this.labelLocation);
            this.groupBoxFilters.Controls.Add(this.labelDescription);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(638, 116);
            this.groupBoxFilters.TabIndex = 11;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Search Filters";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(465, 76);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(141, 20);
            this.textBoxState.TabIndex = 26;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(136, 76);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(141, 21);
            this.comboBoxType.TabIndex = 24;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(16, 53);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(61, 13);
            this.labelFloor.TabIndex = 17;
            this.labelFloor.Text = "Room Floor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "State";
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(136, 50);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(141, 20);
            this.textBoxFloor.TabIndex = 18;
            this.textBoxFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFloor_KeyPress_1);
            this.textBoxFloor.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFloor_Validating);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(136, 24);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(141, 20);
            this.textBoxNumber.TabIndex = 16;
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            this.textBoxNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumber_Validating);
            // 
            // labelTpye
            // 
            this.labelTpye.AutoSize = true;
            this.labelTpye.Location = new System.Drawing.Point(16, 79);
            this.labelTpye.Name = "labelTpye";
            this.labelTpye.Size = new System.Drawing.Size(62, 13);
            this.labelTpye.TabIndex = 19;
            this.labelTpye.Text = "Room Type";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(16, 27);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(75, 13);
            this.labelNumber.TabIndex = 15;
            this.labelNumber.Text = "Room Number";
            // 
            // comboBoxLoc
            // 
            this.comboBoxLoc.FormattingEnabled = true;
            this.comboBoxLoc.Location = new System.Drawing.Point(465, 24);
            this.comboBoxLoc.Name = "comboBoxLoc";
            this.comboBoxLoc.Size = new System.Drawing.Size(141, 21);
            this.comboBoxLoc.TabIndex = 23;
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.Location = new System.Drawing.Point(465, 50);
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.Size = new System.Drawing.Size(141, 20);
            this.textBoxDescr.TabIndex = 20;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(345, 27);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 21;
            this.labelLocation.Text = "Location";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(345, 53);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 22;
            this.labelDescription.Text = "Description";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FilterRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 402);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxFilters);
            this.Name = "FilterRoom";
            this.Text = "FilterRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.TextBox textBoxState;
        public System.Windows.Forms.ComboBox comboBoxType;
        public System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxFloor;
        public System.Windows.Forms.TextBox textBoxNumber;
        public System.Windows.Forms.Label labelTpye;
        public System.Windows.Forms.Label labelNumber;
        public System.Windows.Forms.ComboBox comboBoxLoc;
        public System.Windows.Forms.TextBox textBoxDescr;
        public System.Windows.Forms.Label labelLocation;
        public System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}