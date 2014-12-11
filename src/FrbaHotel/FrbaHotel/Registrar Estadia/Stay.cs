using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class Stay : Form
    {
        Int32 id_booking;
        BookingHandler bh = new BookingHandler();

        public Stay()
        {
            InitializeComponent();
            this.loadComboBox();
            buttonEnter.Enabled = false;
        }

        private void loadComboBox() {
            string[] items = new string[] { "Check-In", "Check-Out" };
            comboBox.DataSource = items;
            comboBox.SelectedIndex = 0;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBox);
        }

        private void textBoxCode_Validating(object sender, CancelEventArgs e)
        {
            FormHandler.validateEmptyTextBox(textBoxCode, errorProvider, buttonEnter);
            FormHandler.validateIntTextBox(textBoxCode, errorProvider, buttonEnter);

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (bh.bookingExists(id_booking))
            {
                this.id_booking = Convert.ToInt32(textBoxCode.Text);
                if (comboBox.SelectedValue.ToString() == "Check-In")
                {
                    CheckIn frm = new CheckIn();
                    frm.setIdBooking(id_booking);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    CheckOut frm = new CheckOut();
                    frm.setIdBooking(id_booking);
                    frm.Show();
                    this.Hide();
                }
            }
            else { 
                MessageBox.Show("Booking Number does not exists");
            }
        }

        
    }
}
