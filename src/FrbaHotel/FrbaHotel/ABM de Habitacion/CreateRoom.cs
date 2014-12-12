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
    public partial class CreateRoom : Form
    {
        RoomHandler rh = new RoomHandler();
        ValidationsHandler vh = new ValidationsHandler();
        Int32 roomNum;
        Int32 floor;
        Int32 location;
        Int32 type;
        String descrip;


        public CreateRoom()
        {
            InitializeComponent();
            this.loadRoomType();
            this.loadRoomLocation();
        }

        private void loadRoomType() {
            comboBoxType.DataSource = rh.getRoomTypes().Tables[0];
            comboBoxType.DisplayMember = "descr";
            comboBoxType.ValueMember = "id_roomtype";
        }
        private void loadRoomLocation() {
            comboBoxLoc.DataSource = rh.getRoomLocations().Tables[0];
            comboBoxLoc.DisplayMember = "descr";
            comboBoxLoc.ValueMember = "id_location";
        }


        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBoxData);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.assignParams();
            if (!rh.roomExists(roomNum, 1)) { // donde va 45 debe ir el id del hotel del administrador, no se como encontrarlo 
                Boolean inserted = rh.insertRoom(1, roomNum, floor, location, type, descrip);

                if(inserted){
                    MessageBox.Show("Room Inserted");
                }else{
                    MessageBox.Show("Unable to insert room");
                }

            }else{
                MessageBox.Show("Room already exists");
            }
        }


        public void assignParams() {
            roomNum=Int32.Parse(textBoxNumber.Text);
            floor=Int32.Parse(textBoxFloor.Text);
            descrip=textBoxDescr.Text;
            type = (Int32)comboBoxType.SelectedValue;
            location = (Int32)comboBoxLoc.SelectedValue;

        }


        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }

        private void textBoxFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
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
            FormHandler.validateEmptyComboBox(comboBoxType, errorProvider, buttonSave);
        }

        private void comboBoxLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormHandler.validateEmptyComboBox(comboBoxLoc, errorProvider, buttonSave);
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
