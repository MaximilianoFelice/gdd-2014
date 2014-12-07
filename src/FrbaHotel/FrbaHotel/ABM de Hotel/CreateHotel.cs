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
    public partial class CreateHotel : Form
    {
        HotelHandler hh = new HotelHandler();
        String name;
        String mail;
        Decimal phone;
        String street;
        Int32 streetNum;
        String city;
        String country;
        Int32  starts;
        //CheckListReg.CheckItemColletion regimens;
        DateTime creationDate;

        public CreateHotel()
        {
            InitializeComponent();
            this.loadRegimens();
        }

        private void loadRegimens() {

            //corregir, por cada item del dataset hacer checklist.items.add
            //checkedListBoxReg.DataSource = hh.getRegimensForHotels();
            DataTable dt = hh.getRegimensForHotels().Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
                checkedListBoxReg.Items.Add(Convert.ToString(dt.Rows[i].ItemArray[1]));
        
        }
        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            validateEmptyTextBoxOnHandler(textBoxName);

        }

        private void textBoxMail_Validating(object sender, CancelEventArgs e)
        {
            validateEmptyTextBoxOnHandler(textBoxMail);

        }

        private void textBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            validateEmptyTextBoxOnHandler(textBoxPhone);
            FormHandler.validateDecimalTextBox(textBoxPhone, errorProvider, buttonSave);
        }

        private void textBoxStreet_Validating(object sender, CancelEventArgs e)
        {
            validateEmptyTextBoxOnHandler(textBoxStreet);
        }

        private void textBoxStreetNum_Validating(object sender, CancelEventArgs e)
        {
            validateEmptyTextBoxOnHandler(textBoxStreetNum);
            FormHandler.validateIntTextBox(textBoxStreetNum, errorProvider, buttonSave);
        }

        private void textBoxCity_Validating(object sender, CancelEventArgs e)
        {
            validateEmptyTextBoxOnHandler(textBoxCity);
        }

        private void textBoxCountry_Validating(object sender, CancelEventArgs e)
        {
            validateEmptyTextBoxOnHandler(textBoxCountry);
        }

        public void validateEmptyTextBoxOnHandler(TextBox txtb) {
            FormHandler.validateEmptyTextBox(txtb, errorProvider, buttonSave);
        }
       

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBox);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.assignParams();

        }

        private void assignParams() {
            name=textBoxName.Text;
            mail=textBoxMail.Text;
            phone=Decimal.Parse(textBoxPhone.Text);
            street=textBoxStreet.Text;
            streetNum=Int32.Parse(textBoxStreetNum.Text);
            city=textBoxCity.Text;
            country=textBoxCountry.Text;
            starts= (Int32)numericUDStars.Value;
            //regimens= checkedListBoxReg.CheckedItems;
            creationDate=dateTimePicker.Value;

        
        }
    }
}
