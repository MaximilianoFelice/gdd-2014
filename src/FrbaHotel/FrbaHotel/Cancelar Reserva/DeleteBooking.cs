using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.Cancelar_Reserva
{
    public partial class DeleteBooking : Form
    {
        Int32 id_booking;
        String descr;
        BookingHandler bh = new BookingHandler();

        public DeleteBooking()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e){
            FormHandler.groupBoxCleaner(groupBox);
        }

        private void textBoxCode_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBox(textBoxCode);
            FormHandler.validateIntTextBox(textBoxCode, errorProvider, buttonDelete);
        }

        private void textBoxDescr_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBox(textBoxDescr);
        }

        private void validateEmptyTextBox(TextBox textb) {
            FormHandler.validateEmptyTextBox(textb, errorProvider, buttonDelete);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.assignParams();
            Boolean exists = bh.bookingExists(id_booking);
            if (exists) {
                Boolean deleted = bh.deleteBooking(id_booking, descr);//falta loggear quien es el que la elimino
                if (deleted)
                {
                    MessageBox.Show("Booking was deleted");
                }
                else {
                    MessageBox.Show("Unable to delete booking");
                }
            }
        }

        private void assignParams() {
            id_booking = Int32.Parse(textBoxCode.Text);
            descr = textBoxDescr.Text;
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }


        
    }
}
