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

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class UpdateGuest : Form
    {
        GuestHandler handler; 
    
        public UpdateGuest(GuestHandler guestToModify)
        {
            InitializeComponent();
            handler = guestToModify;
            bindControls();
            dtPickerBirhtDate.MaxDate = DateTime.Now;

        }

        private void bindControls() {
            /* Binding countries to comboBox */
            CountryModel.BindTo(comboBoxNationality);
            DocTypeModel.BindTo(comboBoxDocType);

           
            textBoxName.Text= (handler["name"] == DBNull.Value) ? "" : (String)handler["name"];
            textBoxLastname.Text = (handler["lastname"] == DBNull.Value) ? "" : (String)handler["lastname"]; ;
            textBoxDocNumber.Text = (handler["doc_number"] == DBNull.Value) ? "" : ((Decimal)handler["doc_number"]).ToString();
            textBoxPhone.Text = (handler["phone"] == DBNull.Value) ? "" : ((Decimal)handler["phone"]).ToString() ;
            textBoxEmail.Text = (handler["mail"] == DBNull.Value) ? "" : (String)handler["mail"];
            //dtPickerBirhtDate.Value = (handler["birthdate"] == DBNull.Value) ? "" : Convert.ToString(((DateTime)handler["birthdate"]));
            textBoxStreet.Text = (handler["street"] == DBNull.Value) ? "" : (String)handler["street"];
            textBoxStreetNum.Text = (handler["street_num"] == DBNull.Value) ? "" : ((int)handler["street_num"]).ToString();
            textBoxFloor.Text = (handler["dir_floor"] == DBNull.Value) ? "" : ((int)handler["dir_floor"]).ToString();
            textBoxDept.Text = (handler["dir_dpt"] == DBNull.Value) ? "" : (String)handler["dir_dpt"];
         
        }
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            handler["name"] = textBoxName.Text;
            handler["lastname"] = textBoxLastname.Text;
            handler["doc_type"] = comboBoxDocType.SelectedValue;
            handler["doc_number"] = textBoxDocNumber.Text;
            handler["mail"] = textBoxEmail.Text;
            handler["phone"] = textBoxPhone.Text;
            handler["birthdate"] = dtPickerBirhtDate.Value;
            handler["street"] = textBoxStreet.Text;
            handler["street_num"] = textBoxStreetNum.Text;
            handler["dir_floor"] = textBoxFloor.Text;
            handler["dir_dpt"] = textBoxDept.Text;

            handler.Update();
            this.Close();
        }     
            


        //clears all fields
        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBoxGuest);
        }

        private void textBoxStreetNum_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxStreetNum);
            this.validateIntTextBoxOnHandler(textBoxStreetNum);
        }

        private void textBoxFloor_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxFloor);
            this.validateIntTextBoxOnHandler(textBoxFloor);

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

        public void validateEmptyComboBox(ComboBox combo)
        {
            FormHandler.validateEmptyComboBox(combo, errorProvider, buttonSave);
        }


        private void textBoxDocNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }

        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);

        }

        private void textBoxFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);

        }

        private void textBoxStreetNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);

        }


        private void textBoxLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

        private void textBoxDocNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }

        private void textBoxPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);

        }

        private void textBoxName_Validating_1(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxName);
        }

        private void textBoxLastname_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxLastname);
        }

        private void comboBoxDocType_Validating_1(object sender, CancelEventArgs e)
        {
            this.validateEmptyComboBox(comboBoxDocType);
        }

        private void textBoxDocNumber_Validating_1(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxDocNumber);
            this.validateDecTextBoxOnHandler(textBoxDocNumber);
        }

        private void textBoxPhone_Validating_1(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxPhone);
            this.validateDecTextBoxOnHandler(textBoxPhone);
        }

        private void textBoxEmail_Validating_1(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxEmail);
            if (!String.IsNullOrEmpty(textBoxEmail.Text))
            {
                if (!(textBoxEmail.Text.Contains('.') || textBoxEmail.Text.Contains('@')) || textBoxEmail.Text.Contains(" "))
                {
                    errorProvider.SetError(textBoxEmail, "Mail has invalid type, has spaces or does not contain '.' or '@'");
                    buttonSave.Enabled = false;
                }
                else
                {
                    errorProvider.SetError(textBoxEmail, "");
                    buttonSave.Enabled = true;
                }
            }
        }

        private void comboBoxNationality_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyComboBox(comboBoxNationality);
        }

        private void textBoxStreet_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxStreet);
        }

        private void textBoxDept_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxDept);
        }

       


    }
}
