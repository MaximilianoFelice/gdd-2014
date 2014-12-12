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
        BindingSource bs;


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
            FormHandler.clearDataGridView(dataGridView);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

    
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.assignFilters();
            DataSet results = HotelHandler.filteredSearch(name, stars, city, country);
            bs = new BindingSource();
            bs.DataSource = results.Tables[0];
            dataGridView.DataSource = bs; 
        }

        private void assignFilters() {
            name=textBoxName.Text;
            city=textBoxCity.Text;
            country=comboBoxCountry.SelectedText;
            if (comboBoxStars.Text != "") stars = Convert.ToInt32(comboBoxStars.Text);
            else stars = null;
        
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            var index = dataGridView.CurrentRow.Index;
            Form toUpdate = new HotelModifier(new HotelHandler( (dataGridView.Rows[index].DataBoundItem as DataRowView).Row) ) ;
            toUpdate.MdiParent = this.MdiParent;
            toUpdate.Show();
        }

        private void buttonManteinance_Click(object sender, EventArgs e)
        {
            var index = dataGridView.CurrentRow.Index;
            ABM_de_Hotel.Manteinance frm = new Manteinance(new HotelHandler((dataGridView.Rows[index].DataBoundItem as DataRowView).Row) );
            frm.Owner = this.MdiParent;
            frm.ShowDialog();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridView.CurrentRow.Index;
            HotelHandler.deleteHotel((dataGridView.Rows[index].DataBoundItem as DataRowView).Row);

        }

        private void FilterHotel_Load(object sender, EventArgs e)
        {

        }

    }
}
