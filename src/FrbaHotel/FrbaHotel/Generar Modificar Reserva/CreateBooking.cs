using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.DB_Conn_DSL;
using HotelModel.Home;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class CreateBooking : Form
    {

        Boolean insertable = true;
        String hotelName;
        String docType;
        Int32 extraGuests;
        String regimenType;
        Decimal docNumber;
        DateTime checkIn;
        DateTime checkOut;

        public CreateBooking()
        {
            InitializeComponent();
            loadHotels();
           
        }

        private void loadHotels() {
            HotelHandler activeHotels = new HotelHandler();
            comboBoxHotel.DataSource = activeHotels.getHotels();
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRegimenTypeForHotel(comboBoxHotel.SelectedValue.ToString());
        }

        private void loadRegimenTypeForHotel(String hotelName) {
            RegimenHandler reg = new RegimenHandler();
            comboBoxRegimen.DataSource = reg.getRegimensForHotel(hotelName);

        }

 
  

        private void buttonSave_Click(object sender, EventArgs e)
        {

            this.validateInput();
            if (insertable) {
                BookingHandler newBooking = new BookingHandler();
                Boolean status = newBooking.insertBooking(hotelName,regimenType, docType,docNumber, extraGuests, 
                                    checkIn, checkOut);
            }

        }

        private void validateInput()
        {
            validateHotel(comboBoxHotel.SelectedValue.ToString());

            validateRegimen(comboBoxRegimen.SelectedValue.ToString());

            validateDocNumberType(textBoxDocNumber.Text);

            validateDocType(comboBoxDocType.SelectedValue.ToString());

            validateGuestExistance(docType,docNumber);

            validateExtraGuests(textBoxExtraGuests.Text);

            validateCheckInDate(dateTimePickerIn.Value);

            validateCheckOutDate(dateTimePickerOut.Value);


        }

        private void validateHotel(String aHotel) {
            if (String.IsNullOrEmpty(aHotel))
            {
                MessageBox.Show("Please enter a hotel. Mandatory Field");
                insertable = false;
            }
            else
            {
                hotelName = aHotel;
            }
        }

        private void validateRegimen (String aRegimen)
        {
            if (String.IsNullOrEmpty(aRegimen))
            {
                MessageBox.Show("Please enter a regimen. Mandatory Field");
                insertable = false;
            }
            else
            {
                insertable = true;
                regimenType = aRegimen;
            }
        }

        private void validateDocNumberType(String aDocNum)
        {
            try
            {
                insertable = true;
                docNumber = Decimal.Parse(aDocNum);

            }
            catch (FormatException) {
                insertable = false;
                MessageBox.Show("Invalid type at document number");

            }
            
        }

        private void validateDocType(String aDocType)
        {
            if (String.IsNullOrEmpty(aDocType))
            {
                MessageBox.Show("Please enter a document type. Mandatory Field");
                insertable = false;
            }
            else
            {
                insertable = true;
                docType = aDocType;
            }
        }

        public void validateGuestExistance(String dType, Decimal dNumber) 
        {
            GuestHandler guestExists = new GuestHandler();
            if(!guestExists.PersonExistance(dType, dNumber)){
                MessageBox.Show("Guest doesn't exist. Do you want to create it?");
                //go to create guest form on OK click, return to create booking otherwise

            }
        }

        private void validateExtraGuests(String extra)
        {
            try
            {
                extraGuests = Int32.Parse(extra);
                insertable = true;
            }
            catch (FormatException)
            {
                insertable = false;
                MessageBox.Show("Invalid format at extra guests. Int expected");
            }
        }

        private void validateCheckInDate(DateTime checkin)
        {
            if (checkin < DateTime.Now)
            {
                insertable = false;
                MessageBox.Show("Invalid Date at checkin");
            }
            else {
                insertable = true;
                checkIn = checkin;
            }
        
        }
        
        private void validateCheckOutDate(DateTime checkout)
        {
            if (checkout < checkIn)
            {
                MessageBox.Show("Invalid date at check out");
                insertable = false;
            }
            else {
                insertable = true;
                checkOut = checkout;
            }
        
        }



        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDocNumber.Clear();
            textBoxExtraGuests.Clear();
            //to clear combo box set selectindex twice in -1 
            //http://support2.microsoft.com/default.aspx?scid=kb;en-us;327244
            comboBoxHotel.SelectedIndex = -1;
            comboBoxHotel.SelectedIndex = -1;
            comboBoxDocType.SelectedIndex = -1;
            comboBoxDocType.SelectedIndex = -1;
            comboBoxRegimen.SelectedIndex = -1;
            comboBoxRegimen.SelectedIndex = -1;
            dateTimePickerIn.ResetText();
            dateTimePickerOut.ResetText();

        }

        private void textBoxDocNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }

        }

        private void textBoxExtraGuests_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }

        }


        

       


    }
}
