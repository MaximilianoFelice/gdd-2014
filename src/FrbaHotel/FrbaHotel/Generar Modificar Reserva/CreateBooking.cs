﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class CreateBooking : Form
    {
        HotelHandler hh = new HotelHandler();
        RegimenHandler rh = new RegimenHandler();
        RoomHandler roh = new RoomHandler();
        BookingHandler bh = new BookingHandler();
        Int32 id_hotel;
        Int32 id_regimen;
        DateTime checkin;
        DateTime checkout;
        Int32 extraGuests;
        Int32 id_roomtype;

        public CreateBooking()
        {
            InitializeComponent();
            dateTimePickerStart.MinDate = DateTime.Today;
            dateTimePickerEnd.MinDate = DateTime.Today.AddDays(1);
            this.loadHotels();
        }

        private void loadHotels() {
            comboBoxHotel.DataSource = hh.getHotels().Tables[0];
            
        }

        private void comboBoxHotel_SelectedValueChanged(object sender, EventArgs e)
        {
            this.assignIdHotel();
            this.loadRegimensForHotel();
            this.loadRoomTypeForHotel();
        }


        private void loadRegimensForHotel() {
            //no funciona tira exception key not found ?? revisar
            comboBoxRegimen.DataSource = rh.getRegimensDescrForHotel(id_hotel);
        
        }

        private void loadRoomTypeForHotel() {
            comboBoxRoomType.DataSource = roh.getRoomTypesForHotel(id_hotel);
        }

        private void comboBoxHotel_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyComboBox(comboBoxHotel);
        }


        private void dateTimePickerEnd_Validating(object sender, CancelEventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            if (endDate < startDate)
            {
                errorProvider.SetError(dateTimePickerEnd, "Date is previous to checkin date. Change it");
                buttonAvailability.Enabled = false;
            }
            else {
                errorProvider.SetError(dateTimePickerEnd, "");
                buttonAvailability.Enabled = true;
            }
        }

        private void comboBoxRoomType_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyComboBox(comboBoxRoomType);
        }

        private void validateEmptyComboBox(ComboBox combo) {
            FormHandler.validateEmptyComboBox(combo, errorProvider, buttonAvailability);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBoxHotel);
            FormHandler.groupBoxCleaner(groupBoxArrival);
            FormHandler.clearDatePicker(dateTimePickerStart);
            FormHandler.clearDatePicker(dateTimePickerEnd);
            FormHandler.groupBoxCleaner(groupBoxRoom);
        }

        private void buttonAvailability_Click(object sender, EventArgs e)
        {
            this.assignParams();
            Boolean available = bh.checkAvailability(id_hotel, id_regimen, checkin, checkout, extraGuests, id_roomtype);
            if (available)
            {
                Generar_Modificar_Reserva.BookingConfirmation frm = new BookingConfirmation(this);
                frm.textBoxHotel.Text = comboBoxHotel.Text;
                frm.textBoxRegimen.Text = comboBoxRegimen.Text;
                frm.textBoxRoomType.Text = comboBoxRoomType.Text;
                frm.textBoxExtraGuests.Text = Convert.ToString(extraGuests);
                frm.textBoxCheckIn.Text = Convert.ToString(checkin);
                frm.textBoxCheckout.Text = Convert.ToString(checkout);
                frm.setTotalPrice(id_hotel, id_regimen, checkin, checkout, extraGuests, id_roomtype);
                frm.setValues(id_hotel, id_regimen, checkin, checkout, extraGuests, id_roomtype);
                frm.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("There is no availability for Hotel on this period for the regimen and roomtype selected. Try some other period or regimen or roomtype");
            }
        }

        private void assignParams() {
            this.assignIdRegimen();
            checkin = dateTimePickerStart.Value;
            checkout = dateTimePickerEnd.Value;
            extraGuests = (Int32)numericUpDown.Value;
            this.assignIdRoomType();
        }

        private void assignIdHotel() {
            String name = comboBoxHotel.Text;
            DataTable dt =  hh.getIdHotelByName(name).Tables[0];
            id_hotel = Convert.ToInt32(dt.Rows[0].ToString());
        }
        private void assignIdRegimen() {
            if (comboBoxRegimen.SelectedItem == null)
            {
                Generar_Modificar_Reserva.RegimensForHotel frm = new RegimensForHotel(this);
                frm.textBoxId.Text = Convert.ToString(this.id_hotel);
                frm.textBoxName.Text = this.comboBoxHotel.Text;
                frm.Show();
            }
            else {
                String descr = comboBoxRegimen.Text;
                DataTable dt = rh.getRegimenIdFromDescr(descr).Tables[0];
                id_regimen = Convert.ToInt32(dt.Rows[0].ToString());
            }
        }

        public void setRegimen(Int32 id_reg, String name) {
            id_regimen = id_reg;
            this.comboBoxRegimen.SelectedIndex = this.comboBoxRegimen.FindStringExact(name);
           
        }
        private void assignIdRoomType() {
            String descr = comboBoxRoomType.Text;
            DataTable dt = roh.getRoomTypeIdFromDescr(descr).Tables[0];
            id_roomtype = Convert.ToInt32(dt.Rows[0].ToString());

        }

     

       
    }
}
