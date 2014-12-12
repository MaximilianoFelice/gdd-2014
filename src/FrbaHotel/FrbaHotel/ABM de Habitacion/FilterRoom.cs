using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;
using HotelModel.Model;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class FilterRoom : Form
    {
        BindingSource bs;
        Int32 idHotel;
        Int32? roomNum;
        Int32? floor;
        String location;
        String type;
        String descrip;
        String state;
        Int32 id_hotel;

        public FilterRoom()
        {
            InitializeComponent();
            this.BindControls();
            
        }

        private void BindControls()
        {
            RoomTypeModel.BindTo(comboBoxType);
            RoomLocationModel.BindTo(comboBoxLoc);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(this.groupBoxFilters);
            FormHandler.clearDataGridView(this.dataGridViewResults);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.assignFilters();
            DataSet results = RoomHandler.filteredSearch(roomNum,floor,location, type, descrip);
            bs = new BindingSource();
            bs.DataSource = results.Tables[0];
            dataGridViewResults.DataSource = bs;  
        }

        private void assignFilters() {
            if (textBoxNumber.Text != "") roomNum = Convert.ToInt32(textBoxNumber.Text);
            else roomNum = null;
            if(textBoxFloor.Text !="" ) floor= Convert.ToInt32(textBoxFloor.Text);
            else roomNum = null;
            type = comboBoxType.SelectedText;
            location=comboBoxLoc.SelectedText;
            descrip = textBoxDescr.Text; 
        
        }


        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);

        }

        private void textBoxFloor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var index = dataGridViewResults.CurrentRow.Index;
            Form toUpdate = new UpdateRoom(new RoomHandler((dataGridViewResults.Rows[index].DataBoundItem as DataRowView).Row));
            toUpdate.MdiParent = this.MdiParent;
            toUpdate.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridViewResults.CurrentRow.Index;
            RoomHandler.deleteRoom((dataGridViewResults.Rows[index].DataBoundItem as DataRowView).Row); 
           
        }

        

    }
}
