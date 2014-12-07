using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.Listado_Estadistico
{
    public partial class Statistics : Form
    {
       
        StatisticsHandler sh = new StatisticsHandler();

        public Statistics()
        {
            InitializeComponent();
            this.loadComboBoxQuarters();
            checkBoxLFilter.SelectionMode = SelectionMode.One;
        }



        private void loadComboBoxQuarters()
        {
            comboBoxQuarter.Items.Add(new KeyValuePair<Int32, String>(1, "January, February, March"));
            comboBoxQuarter.Items.Add(new KeyValuePair<Int32, String>(2, "April, May, June"));
            comboBoxQuarter.Items.Add(new KeyValuePair<Int32, String>(3, "July, August, September"));
            comboBoxQuarter.Items.Add(new KeyValuePair<Int32, String>(4, "October, November, December"));

            comboBoxQuarter.ValueMember = "Key";
            comboBoxQuarter.DisplayMember = "Value";
            comboBoxQuarter.SelectedIndex = 0;
        }

        private void loadCriteria(String selectedCriteria)
        {
 
            this.checkBoxLFilter.Items.Clear();

            if (selectedCriteria == "Hotels") 
            {
                this.checkBoxLFilter.Items.Add("Top Hotels with Cancelled Bookings");
                this.checkBoxLFilter.Items.Add("Top Hotels with Extras Billed ");
                this.checkBoxLFilter.Items.Add("Top Hotels with Out of Service days");
            }
            
            if (selectedCriteria == "Rooms"){
                this.checkBoxLFilter.Items.Add("Most occupied rooms");
            }
            if (selectedCriteria == "Guests") {
                this.checkBoxLFilter.Items.Add("Guests with more points");
            }
        }

        private void criterios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkBoxLFilter.Items.Count; i++)
            {
                if (i != e.Index) checkBoxLFilter.SetItemChecked(i, false);
            } 
        }
           

        private void comboBoxCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadCriteria(Convert.ToString(comboBoxCriteria.SelectedItem));
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
  

            dataGridViewResults.DataSource = null;

            Int32 quarter = ((KeyValuePair<Int32, String>)comboBoxQuarter.SelectedItem).Key - 1;
            Int32 year = (Int32)numericUpDownYear.Value;
            DateTime from = new DateTime(year, 1 + quarter * 3, 1);
            DateTime to;

            if (quarter == 3)
                to = new DateTime(year + 1, 1, 1).AddDays(-1);
            else
                to = new DateTime(year, 1 + (quarter + 1) * 3, 1).AddDays(-1);


            if (Convert.ToString(this.comboBoxCriteria.SelectedItem) == "Hotels")
            {
                switch (FormHandler.selectItemIndex(this.checkBoxLFilter))
                {
                    case 0:
                        dataGridViewResults.DataSource = sh.cancelledBookings(from, to);
                        break;
                    case 1:
                        dataGridViewResults.DataSource = sh.extraBilled(from, to);
                        break;
                    case 2:
                        dataGridViewResults.DataSource = sh.outService(from, to);
                        break;
                }
            }
            else
            {
                if (Convert.ToString(this.comboBoxCriteria.SelectedItem) == "Guests")
                {
                    dataGridViewResults.DataSource = sh.guestsPoints(from, to);
                   
                }
                else
                {
                    dataGridViewResults.DataSource = sh.occupiedRooms(from, to);
                  
                }
            }
           
            
           

       

        }

        private void comboBoxCriteria_Validating(object sender, CancelEventArgs e)
        {
            if (this.comboBoxCriteria.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxCriteria, "Please select a criteria");
                buttonShow.Enabled = false;
            }
            else {
                errorProvider.SetError(comboBoxCriteria, "");
                buttonShow.Enabled = true;
            }
        }

        private void checkBoxLFilter_Validating(object sender, CancelEventArgs e)
        {
            if (FormHandler.checkBoxListEmpty(checkBoxLFilter)){
                errorProvider.SetError(checkBoxLFilter, "Please select an item");
                buttonShow.Enabled=false;
            }else{
                errorProvider.SetError(checkBoxLFilter, "");
                buttonShow.Enabled=true;
            }
                
        }

       
    }
}
