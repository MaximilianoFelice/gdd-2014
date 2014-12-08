using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class FilterRoom : Form
    {
        RoomHandler rh = new RoomHandler();
        ValidationsHandler vh = new ValidationsHandler();
        Int32 idHotel;
        Int32? roomNum;
        Int32? floor;
        String location;
        String type;
        String descrip;
        String state;

        public FilterRoom()
        {
            InitializeComponent();
            this.loadRoomType();
            this.loadRoomLocation();
        }

        private void loadRoomType()
        {
            comboBoxType.DataSource = rh.getRoomTypes();
        }

        private void loadRoomLocation()
        {
            comboBoxLoc.DataSource = rh.getRoomLocations();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(this.groupBoxFilters);
            FormHandler.clearDataGridView(this.dataGridViewResults);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.assignFilters();
            DataTable results = rh.filteredSearch(idHotel, roomNum,floor, location, type, descrip); //falta asignar el id del hotel
            BindingSource bs = new BindingSource();
            bs.DataSource = results;
            dataGridViewResults.DataSource = bs; 
        }

        private void assignFilters() {
            type=comboBoxType.Text;
            location=comboBoxLoc.Text;
            descrip = textBoxDescr.Text;
            state = textBoxState.Text; // debera encontrar por sp a traves de la descripcion en la tabla de estado el id correspondiente a ese estado
            
        
        }


        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);

        }

        private void textBoxFloor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }

        private void textBoxNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!vh.validateNullString(textBoxNumber.Text))
            {
                try
                {
                    roomNum = Int32.Parse(textBoxNumber.Text);
                    errorProvider.SetError(textBoxNumber, "");
                    buttonSearch.Enabled = true;

                }
                catch (FormatException)
                {
                    errorProvider.SetError(textBoxNumber, "Invalid type");
                    buttonSearch.Enabled = false;
                }
            }
            else {
                roomNum = null;
                buttonSearch.Enabled = true;
            }

        }

        private void textBoxFloor_Validating(object sender, CancelEventArgs e)
        {
            if (!vh.validateNullString(textBoxFloor.Text))
            {
                try
                {
                    floor = Int32.Parse(textBoxFloor.Text);
                    errorProvider.SetError(textBoxFloor, "");
                    buttonSearch.Enabled = true;

                }
                catch (FormatException)
                {
                    errorProvider.SetError(textBoxFloor, "Invalid type");
                    buttonSearch.Enabled = false;
                }
            }
            else
            {
                floor = null;
                buttonSearch.Enabled = true;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.UpdateRoom frm = new UpdateRoom();
            
            frm.textBoxNumber.Text = this.dataGridViewResults.CurrentRow.Cells[1].Value.ToString();
            frm.textBoxFloor.Text = this.dataGridViewResults.CurrentRow.Cells[2].Value.ToString();

            frm.comboBoxType.Text = this.dataGridViewResults.CurrentRow.Cells[3].Value.ToString();
            frm.comboBoxLoc.Text = this.dataGridViewResults.CurrentRow.Cells[4].Value.ToString();
            frm.textBoxDescr.Text = this.dataGridViewResults.CurrentRow.Cells[5].Value.ToString();
            frm.textBoxState.Text = this.dataGridViewResults.CurrentRow.Cells[6].Value.ToString();
     
            frm.ShowDialog();
            this.Hide();


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Int32 id_room = (Int32)this.dataGridViewResults.CurrentRow.Cells[0].Value;
            if (rh.deleteRoom(id_room)) MessageBox.Show("Room Deleted");
            else MessageBox.Show("Unable to delete");
        }

        

    }
}
