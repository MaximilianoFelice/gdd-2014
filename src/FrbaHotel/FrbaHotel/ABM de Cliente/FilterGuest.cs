using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class FilterGuest : Form
    {

        String name { get; set; }
        String lastname { get; set; }
        String mail { get; set; }
        String docType { get; set; }
        Decimal? docNumber { get; set; }
        BindingSource bs;


        public FilterGuest()
        {
            InitializeComponent();
            this.loadComboBoxDocType();
        }

        private void loadComboBoxDocType()
        {
            FormHandler.loadDocTypesToCombo(comboBoxDocType);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           this.assignFilters();
           DataSet results = GuestHandler.filteredSearch(name, lastname, docType, docNumber, mail);
           bs = new BindingSource();
           bs.DataSource = results.Tables[0];
           dataGridViewResults.DataSource = bs; 
        }


        private void assignFilters() { 
            name=textBoxName.Text;
            lastname = textBoxLastname.Text;
            docType=comboBoxDocType.SelectedText;
            if (textBoxDocNumber.Text != "") docNumber = Convert.ToInt32(textBoxDocNumber.Text);
            else docNumber = null; 
            mail=textBoxEmail.Text;
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(this.groupBoxFilters);
            FormHandler.clearDataGridView(this.dataGridViewResults);
       
        }

        private void textBoxDocNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxDocNumber.Text))
            {
                FormHandler.validateDecimalTextBox(textBoxDocNumber, errorProvider, buttonSearch);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var index = dataGridViewResults.CurrentRow.Index;
            Form toUpdate = new UpdateGuest( new GuestHandler((dataGridViewResults.Rows[index].DataBoundItem as DataRowView).Row));
            toUpdate.MdiParent = this.MdiParent;
            toUpdate.Show(); 
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

        private void textBoxLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

        private void textBoxDocNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridViewResults.CurrentRow.Index;
            GuestHandler.deleteGuest((dataGridViewResults.Rows[index].DataBoundItem as DataRowView).Row);

        }

        private void FilterGuest_Load(object sender, EventArgs e)
        {

        }

        
    }
}
