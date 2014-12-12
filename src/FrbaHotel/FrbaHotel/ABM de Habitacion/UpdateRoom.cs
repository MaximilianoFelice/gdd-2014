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
    public partial class UpdateRoom : Form
    {
        RoomHandler handler;
        


        public UpdateRoom(RoomHandler roomToModify)
        {
            InitializeComponent();
            handler = roomToModify;
            this.bindControls();
        }

        private void bindControls() {
            RoomTypeModel.BindTo(comboBoxType);
            RoomLocationModel.BindTo(comboBoxLoc);

            textBoxNumber.Text = (handler["number"] == DBNull.Value) ? "" : ((int)handler["number"]).ToString();
            textBoxFloor.Text = (handler["room_floor"] == DBNull.Value) ? "" : ((int)handler["floor"]).ToString();
            comboBoxType.SelectedValue = (handler["id_roomtype"]==DBNull.Value) ? 0 : (int)handler["id_roomtype"];
            comboBoxLoc.SelectedValue = (handler["id_location"] == DBNull.Value) ? 0 : (int)handler["id_location"];
            textBoxDescr.Text = (handler["descr"] == DBNull.Value) ? "" : (String)handler["descr"];
            
        }
        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBoxData);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
                handler["number"] = textBoxNumber.Text;
                handler["floor"] = textBoxFloor.Text;
                handler["id_roomtype"] = comboBoxType.SelectedText;
                handler["id_location"] = comboBoxLoc.SelectedText;
                handler["descr"] = textBoxDescr.Text;
               
                handler.Update();

                this.Close();
            
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

        private void comboBoxLoc_Validating(object sender, CancelEventArgs e)
        {
            FormHandler.validateEmptyComboBox(comboBoxLoc, errorProvider, buttonSave);
        }

    }
}
