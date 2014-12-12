using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class Manteinance : Form
    {
        DateTime start;
        DateTime end;
        String descr;

        HotelHandler _internalHotel;

        public Manteinance(HotelHandler Hotel)
        {
            InitializeComponent();
            _internalHotel = Hotel;

            dateTimePickerStart.MinDate = DateTime.Today;
            dateTimePickerEnd.MinDate = DateTime.Today.AddDays(1);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBox);
            FormHandler.clearDatePicker(dateTimePickerStart);
            FormHandler.clearDatePicker(dateTimePickerEnd);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.assignParams();
            if (_internalHotel.setForManteinance(start, end, descr)) MessageBox.Show("Hotel set in Manteinance");
            else MessageBox.Show("Unable to set in manteinance");
            this.Close();
        }

        private void assignParams() {
            start= dateTimePickerStart.Value;
            end=dateTimePickerEnd.Value;
            descr=textBoxDescr.Text;
        }
    }
}
