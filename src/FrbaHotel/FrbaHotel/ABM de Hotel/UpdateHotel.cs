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
    public partial class UpdateHotel : Form
    {
        HotelHandler hh = new HotelHandler();
        RegimenHandler rh = new RegimenHandler();
        String name;
        String mail;
        Decimal phone;
        String street;
        Int32 streetNum;
        String city;
        String country;
        Int32 stars;
        DateTime creationDate;

        public UpdateHotel()
        {
            InitializeComponent();
            this.loadRegimens();
            dateTimePicker.MaxDate = DateTime.Now;
        }

        private void loadRegimens()
        {
            DataTable dt = rh.getRegimensForHotels().Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
                checkedListBoxReg.Items.Add(Convert.ToString(dt.Rows[i].ItemArray[1]));

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
           this.assignParams();

            Boolean updated = hh.updateHotel(name, mail, phone, street, streetNum, city, country, stars, creationDate);
            if (updated)
            {
                MessageBox.Show("Hotel updated");

                Int32 id_hotel = (Int32)hh.getIdHotel(name, mail, city).Tables[0].Rows[0].ItemArray[0];

                foreach (object checkItem in checkedListBoxReg.CheckedItems)
                {

                    DataTable ids_regimen = rh.getRegimenIdFromDescr(checkItem.ToString()).Tables[0];
                    Int32 id_regimen = (Int32)ids_regimen.Rows[0].ItemArray[0];

                    Boolean addedRegimenToHotel = hh.addRegimenToHotel(id_hotel, id_regimen);

                    if (!addedRegimenToHotel)
                    {
                        MessageBox.Show("Unable to add regimen to Hotel:" + checkItem.ToString());
                    }

                }

            }
            else
            {
                MessageBox.Show("Unable to update hotel");
            }
        }
      


        private void assignParams()
        {
            name = textBoxName.Text;
            mail = textBoxMail.Text;
            phone = Decimal.Parse(textBoxPhone.Text);
            street = textBoxStreet.Text;
            streetNum = Int32.Parse(textBoxStreetNum.Text);
            city = textBoxCity.Text;
            country = textBoxCountry.Text;
            stars = (Int32)numericUDStars.Value;
            creationDate = dateTimePicker.Value;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.clearDatePicker(dateTimePicker);
            FormHandler.groupBoxCleaner(groupBox1);
        }

       
        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxName);
        }

        private void textBoxMail_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxMail);
        }

        private void textBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxPhone);
            FormHandler.validateDecimalTextBox(textBoxPhone, errorProvider, buttonSave);
        }


        private void textBoxStreet_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxStreet);
        }

        private void textBoxStreetNum_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxStreetNum);
            FormHandler.validateIntTextBox(textBoxStreetNum, errorProvider, buttonSave);
        }

        private void textBoxCity_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxCity);
        }

        private void textBoxCountry_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxCountry);
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowOnlyChars(sender, e);
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowOnlyNumbers(sender, e);
        }

        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowOnlyChars(sender, e);
        }

        private void textBoxStreetNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowOnlyNumbers(sender, e);
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowOnlyChars(sender, e);
        }
        private void textBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowOnlyChars(sender, e);
        }

        private void validateEmptyTextBoxOnHandler(TextBox textb) {
            FormHandler.validateEmptyTextBox(textb,errorProvider,buttonSave);
        }

        private void allowOnlyChars(object sender,KeyPressEventArgs e){
            FormHandler.allowOnlyChars(sender, e);
        }

        private void allowOnlyNumbers(object sender, KeyPressEventArgs e) {
            FormHandler.allowOnlyNumbers(sender, e);
        }
    }
}
