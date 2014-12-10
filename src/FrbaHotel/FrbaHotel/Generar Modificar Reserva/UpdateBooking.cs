using System;
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
    public partial class UpdateBooking : Form
    {
        Int32 id_booking; 

        public UpdateBooking()
        {
            InitializeComponent();
            buttonUpdate.Enabled = false;
        }

        private void textBoxCode_Validating(object sender, CancelEventArgs e)
        {
            FormHandler.validateEmptyTextBox(textBoxCode, errorProvider, buttonUpdate);
            FormHandler.validateIntTextBox(textBoxCode, errorProvider, buttonUpdate);
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBox);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            setIdBooking();
            CreateBooking frm = new CreateBooking();
            frm.setParamsForUpdate(id_booking);
            frm.Show();
            this.Hide();
        }

        private void setIdBooking() {
            id_booking = Convert.ToInt32(textBoxCode.Text) ;
        }


    }
}
