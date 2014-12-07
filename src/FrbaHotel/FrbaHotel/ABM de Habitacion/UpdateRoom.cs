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
    public partial class UpdateRoom : Form
    {
        RoomHandler rh = new RoomHandler();
        ValidationsHandler vh = new ValidationsHandler();
        Int32 roomNum;
        Int32 floor;
        String location;
        String type;
        String descrip;


        public UpdateRoom()
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
            FormHandler.groupBoxCleaner(groupBoxData);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
                this.assignParams();
             // donde va 45 debe ir el id del hotel del administrador, no se como encontrarlo 
                Boolean updated = rh.updateRoom(45, roomNum, floor, location, type, descrip);

                if (updated)
                {
                    MessageBox.Show("Room Updated");
                }
                else
                {
                    MessageBox.Show("Unable to update room");
                }

            
        }

        private void assignParams() { 
            descrip = textBoxDescr.Text;
            floor = Int32.Parse(textBoxFloor.Text);
            roomNum = Int32.Parse(textBoxNumber.Text);
        }




        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBoxFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBoxNumber_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxNumber);
            this.validateIntTextBoxOnHandler(textBoxNumber);
        }

        private void textBoxFloor_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxFloor);
            this.validateIntTextBoxOnHandler(textBoxFloor);
        }

        private void comboBoxType_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxType.SelectedItem == null)
            {
                errorProvider.SetError(comboBoxType, "Select a room type");
                buttonSave.Enabled = false;

            }
            else
            {
                errorProvider.SetError(comboBoxType, "");
                buttonSave.Enabled = true;
                type = comboBoxType.Text;

            }
        }

        private void comboBoxLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLoc.SelectedItem == null)
            {
                errorProvider.SetError(comboBoxLoc, "Select a room location");
                buttonSave.Enabled = false;

            }
            else
            {
                errorProvider.SetError(comboBoxLoc, "");
                buttonSave.Enabled = true;
                location = comboBoxLoc.Text;

            }
        }

        private void textBoxDescr_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxDescr);
        }

        public void validateEmptyTextBoxOnHandler(TextBox txtb)
        {
            FormHandler.validateEmptyTextBox(txtb, errorProvider, buttonSave);
        }

        public void validateIntTextBoxOnHandler(TextBox txtb)
        {
            FormHandler.validateIntTextBox(txtb, errorProvider, buttonSave);
        }

        public void validateDecTextBoxOnHandler(TextBox txtb)
        {
            FormHandler.validateDecimalTextBox(txtb, errorProvider, buttonSave);
        }

    }
}
