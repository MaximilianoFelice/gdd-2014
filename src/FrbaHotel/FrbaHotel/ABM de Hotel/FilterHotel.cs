using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class FilterHotel : Form
    {
        String name;
        String city;
        String country;
        Int32? stars;

        public FilterHotel()
        {
            InitializeComponent();
            this.loadComboBoxCountries();
        }

        private void loadComboBoxCountries() {
            FormHandler.loadCountriesToCombo(comboBoxCountry);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBox);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

    
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.assignFilters();
            DataTable results = HotelHandler.filteredSearch(name, stars, city, country);
            BindingSource bs = new BindingSource();
            bs.DataSource = results;
            dataGridView.DataSource = bs; 
        }

        private void assignFilters() {
            name=textBoxName.Text;
            city=textBoxCity.Text;
            country=comboBoxCountry.SelectedText;
            stars = Convert.ToInt32(comboBoxStars.Text);
        
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // TODO
            /*
            Form frm = new HotelModifier(HotelHandler.updateHotel());

            frm.textBoxName.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.textBoxMail.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.textBoxPhone.Text=this.dataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.textBoxStreet.Text=this.dataGridView.CurrentRow.Cells[4].Value.ToString();
            frm.textBoxStreetNum.Text=this.dataGridView.CurrentRow.Cells[5].Value.ToString();
            frm.textBoxCity.Text=this.dataGridView.CurrentRow.Cells[6].Value.ToString();
            //frm.textBoxCountry.Text=this.dataGridView.CurrentRow.Cells[7].Value.ToString();
            frm.numericUDStars.Value= (Decimal)this.dataGridView.CurrentRow.Cells[8].Value;
            //add regimens to checklist
            frm.dateTimePicker.Value = (DateTime)this.dataGridView.CurrentRow.Cells[9].Value ;

            frm.ShowDialog();
            this.Hide();
             * */
        }

        private void buttonManteinance_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.Manteinance frm = new Manteinance();

            frm.textBoxName.Text= this.dataGridView.CurrentRow.Cells[1].Value.ToString();

            frm.ShowDialog();
            this.Hide();
        }
    }
}
