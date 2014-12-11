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
    partial class HotelModifier
    {

        private void textBoxName_Validating(object sender, CancelEventArgs e) { validateEmptyTextBoxOnHandler(textBoxName); }

        private void textBoxMail_Validating(object sender, CancelEventArgs e) { validateEmptyTextBoxOnHandler(textBoxMail); }

        private void textBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            validateEmptyTextBoxOnHandler(textBoxPhone);
            FormHandler.validateDecimalTextBox(textBoxPhone, errorProvider, buttonSave);
        }

        private void textBoxStreet_Validating(object sender, CancelEventArgs e) { validateEmptyTextBoxOnHandler(textBoxStreet); }

        private void textBoxStreetNum_Validating(object sender, CancelEventArgs e)
        {
            validateEmptyTextBoxOnHandler(textBoxStreetNum);
            FormHandler.validateIntTextBox(textBoxStreetNum, errorProvider, buttonSave);
        }

        private void textBoxCity_Validating(object sender, CancelEventArgs e) { validateEmptyTextBoxOnHandler(textBoxCity); }

        public void validateEmptyTextBoxOnHandler(TextBox txtb) { FormHandler.validateEmptyTextBox(txtb, errorProvider, buttonSave); }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBox);
            FormHandler.clearItemCheckList(checkedListBoxReg);
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

        private void textBoxStreetNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyChars(sender, e);
        }

        private void comboBoxCountry_Validating(object sender, CancelEventArgs e)
        {
            FormHandler.validateEmptyComboBox(comboBoxCountry, errorProvider, buttonSave);
        }
    }
}
