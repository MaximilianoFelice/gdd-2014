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


namespace FrbaHotel.ABM_de_Cliente
{
    public partial class CreateGuest : Form
    {

        String name { get; set; }
        String lastname { get; set; }
        String docType { get; set; }
        Decimal docNumber { get; set; }
        String mail { get; set; }
        Decimal phone { get; set; }
        DateTime birthDate { get; set; }
        String street { get; set; }
        Int32 streetNum { get; set; }
        Int32 floor { get; set; }
        String dept { get; set; }
        String nationality { get; set; }
        Int32 state { get; set; }
        ValidationsHandler vh = new ValidationsHandler();
        GuestHandler gh = new GuestHandler();
        public Int32 inserted;
       


        public CreateGuest()
        {
            InitializeComponent();
            dtPickerBirhtDate.MaxDate = DateTime.Now;
            buttonSave.Enabled = false;
            this.loadComboBoxDocType();

        }

        private void loadComboBoxDocType() {
            FormHandler.loadDocTypesToCombo(comboBoxDocType, this.gh);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.setParams();
                this.assignState();

                if (this.validEmail())
                {
                    if (!this.guestsExists())
                    {
                       inserted = gh.insertPerson(name, lastname, docType,
                                               docNumber, mail, phone, birthDate, street,
                                               streetNum, floor, dept, nationality, state);

                        if (inserted > 0) MessageBox.Show("Guest added");
                        else MessageBox.Show("Unable to add guest");
                    }
                    else { 
                        MessageBox.Show("Guest already exists");
                    }
                }else{
                    MessageBox.Show("Mail already exists. Change it.");
                }

            }else {
                MessageBox.Show("Invalid Input Data");
            }
                
                
            }     
            


        //clears all fields
        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBoxGuest);
            FormHandler.clearDatePicker(dtPickerBirhtDate);

        }

        private void assignState() {
            if (checkBoxEnabled.Checked)
            {
                state = 1;
            }
            else {
                state = 0;
            }
        
        }

        private void setParams() {
            name = textBoxName.Text;
            lastname = textBoxLastname.Text;
            docType = comboBoxDocType.Text;
            docNumber = Decimal.Parse(textBoxDocNumber.Text);
            phone=Decimal.Parse(textBoxPhone.Text);
            mail=textBoxEmail.Text;
            birthDate=dtPickerBirhtDate.Value;
            nationality = textBoxNationality.Text;
            street = textBoxStreet.Text;
            streetNum=Int32.Parse(textBoxStreetNum.Text);
            floor=Int32.Parse(textBoxFloor.Text);
            dept = textBoxDept.Text;
           
        }

        private Boolean validEmail() {
            return vh.validateEmailExistance(mail);
        }

        private Boolean guestsExists() {
            return gh.PersonExistance(name, lastname, docType,docNumber, birthDate);
        }
        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxName);
        }
       
        

        private void textBoxLastname_Validated(object sender, EventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxLastname);
        }
        


        private void comboBoxDocType_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyComboBoxOnHandler(comboBoxDocType);
        }



        private void textBoxDocNumber_Validating1(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxDocNumber);
            this.validateDecTextBoxOnHandler(textBoxDocNumber);
        }

        private void textBoxPhone_Validating_1(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxPhone);
            this.validateDecTextBoxOnHandler(textBoxPhone);
        }
        

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            this.validateEmptyTextBoxOnHandler(textBoxEmail);
            if (!String.IsNullOrEmpty(textBoxEmail.Text)) {
                if (!(textBoxEmail.Text.Contains('.') || textBoxEmail.Text.Contains('@')) || textBoxEmail.Text.Contains(" ")) {
                    errorProvider.SetError(textBoxEmail, "Mail has invalid type, has spaces or does not contain '.' or '@'");
                    buttonSave.Enabled = false;
                } else {
                    errorProvider.SetError(textBoxEmail, "");
                    buttonSave.Enabled = true;
                }
            }

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

        public void validateIntTextBoxOnHandler(TextBox txtb) {
            FormHandler.validateIntTextBox(txtb, errorProvider, buttonSave);
        }

        public void validateDecTextBoxOnHandler(TextBox txtb) {
            FormHandler.validateDecimalTextBox(txtb, errorProvider, buttonSave);
        }

        public void validateEmptyComboBoxOnHandler(ComboBox combo) {
            FormHandler.validateEmptyComboBox(combo, errorProvider, buttonSave);
        }
       
 
           //allows only numbers and . in docnumber field
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
               FormHandler.allowOnlyNumbers(sender, e);
           }

          

           private void textBoxNationality_KeyPress(object sender, KeyPressEventArgs e)
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

           

           

    }
}