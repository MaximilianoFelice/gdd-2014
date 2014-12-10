using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class EnterExtraStay : Form
    {
        public EnterExtraStay()
        {
            InitializeComponent();
        }

        private void textBoxCode_Validating(object sender, CancelEventArgs e)
        {
            FormHandler.validateEmptyTextBox(textBoxCode, errorProvider, buttonEnter);
            FormHandler.validateIntTextBox(textBoxCode, errorProvider, buttonEnter);
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBox);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Registrar_Consumible.CreateExtra frm = new Registrar_Consumible.CreateExtra();
            frm.setIdBooking(Convert.ToInt32(textBoxCode.Text));
        }

     
    }
}
