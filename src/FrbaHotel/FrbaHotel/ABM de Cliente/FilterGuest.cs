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

        GuestHandler gh = new GuestHandler();
        ValidationsHandler vh = new ValidationsHandler();
        String name { get; set; }
        String lastname { get; set; }
        String mail { get; set; }
        String docType { get; set; }
        Decimal? docNumber { get; set; }

        public FilterGuest()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           this.assignFilters();
           DataTable results = gh.filteredSearch(name, lastname,docType, docNumber, mail);
           dataGridViewResults.DataSource = results; 

        }


        private void assignFilters() { 
            name=textBoxName.Text;
            lastname=textBoxLastname.Text;
            docType=comboBoxDocType.Text;
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
                try
                {
                    docNumber = Decimal.Parse(textBoxDocNumber.Text);
                    errorProvider.SetError(textBoxDocNumber, "");
                    buttonSearch.Enabled = true;
                }
                catch (FormatException)
                {
                    errorProvider.SetError(textBoxDocNumber, "Invalid document type");
                    buttonSearch.Enabled = false;

                }
            }
            else {
                docNumber = null;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
      
            ABM_de_Cliente.CreateGuest frm = new CreateGuest();

            frm.Text = "Update Guest";
            frm.labelText.Text = "Updating Guest:" + this.dataGridViewResults.CurrentRow.Cells[0].Value.ToString();

            frm.textBoxName.Text = this.dataGridViewResults.CurrentRow.Cells[1].Value.ToString();
            frm.textBoxLastname.Text = this.dataGridViewResults.CurrentRow.Cells[2].Value.ToString();

            frm.comboBoxDocType.Text = this.dataGridViewResults.CurrentRow.Cells[3].Value.ToString();

            frm.textBoxDocNumber.Text = this.dataGridViewResults.CurrentRow.Cells[4].Value.ToString();
            frm.textBoxEmail.Text = this.dataGridViewResults.CurrentRow.Cells[5].Value.ToString();
            frm.textBoxPhone.Text = this.dataGridViewResults.CurrentRow.Cells[6].Value.ToString();

            // falta pasar la fecha frm.dtPickerBirhtDate.

            frm.textBoxStreet.Text = this.dataGridViewResults.CurrentRow.Cells[8].Value.ToString();
            frm.textBoxStreetNum.Text = this.dataGridViewResults.CurrentRow.Cells[9].Value.ToString();
            frm.textBoxFloor.Text = this.dataGridViewResults.CurrentRow.Cells[10].Value.ToString();
            frm.textBoxDept.Text = this.dataGridViewResults.CurrentRow.Cells[11].Value.ToString();
            frm.textBoxNationality.Text = this.dataGridViewResults.CurrentRow.Cells[12].Value.ToString();

            

            if (this.dataGridViewResults.CurrentRow.Cells[12].Value.ToString() == Convert.ToString(1))
            {
                frm.checkBoxEnabled.Enabled = true;
            }
            else {
                frm.checkBoxEnabled.Enabled = false;
            }

            
            frm.ShowDialog();
            this.Hide();



        
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBoxLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBoxDocNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        
    }
}
