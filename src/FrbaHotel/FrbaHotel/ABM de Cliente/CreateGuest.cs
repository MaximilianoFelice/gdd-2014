﻿using System;
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
       


        public CreateGuest()
        {
            InitializeComponent();
            dtPickerBirhtDate.MaxDate = DateTime.Now;

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
                        Int32 inserted = gh.insertPerson(name, lastname, docType,
                                               docNumber, mail, phone, birthDate, street,
                                               streetNum, floor, dept, nationality, state);

                        MessageBox.Show("Guest added");
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
            
            if (comboBoxDocType.SelectedItem == null)
            {
                errorProvider.SetError(comboBoxDocType, "Please enter the document type of the customer.");
                buttonSave.Enabled = false;
              
            }
            else
            {
                errorProvider.SetError(comboBoxDocType, "");
                buttonSave.Enabled = true;
                docType = comboBoxDocType.Text;
                
            }

        }


        private void textBoxDocNumber_Validating(object sender, CancelEventArgs e)
        {

            this.validateEmptyTextBoxOnHandler(textBoxDocNumber);
            this.validateDecTextBoxOnHandler(textBoxDocNumber);
            
        } 
        

        private void textBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            this.validateDecTextBoxOnHandler(textBoxPhone);
          
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
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

            this.validateIntTextBoxOnHandler(textBoxStreetNum);
        }

        private void textBoxFloor_Validating(object sender, CancelEventArgs e)
        {
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
       
 
           //allows only numbers and . in docnumber field
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
        
        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
           {
               if (char.IsLetter(e.KeyChar))
               {

               }
               else
               {
                   e.Handled = e.KeyChar != (char)Keys.Back;
               }

           }

           private void textBoxFloor_KeyPress(object sender, KeyPressEventArgs e)
           {
               if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
               {

               }
               else
               {
                   e.Handled = e.KeyChar != (char)Keys.Back;
               }

           }

           private void textBoxStreetNum_KeyPress(object sender, KeyPressEventArgs e)
           {
               if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
               {

               }
               else
               {
                   e.Handled = e.KeyChar != (char)Keys.Back;
               }

           }

          

           private void textBoxNationality_KeyPress(object sender, KeyPressEventArgs e)
           {

               if (char.IsLetter(e.KeyChar))
               {

               }
               else
               {
                   e.Handled = e.KeyChar != (char)Keys.Back;
               }

           }

           private void textBoxLastname_KeyPress(object sender, KeyPressEventArgs e)
           {
               if (char.IsLetter(e.KeyChar))
               {

               }
               else
               {
                   e.Handled = e.KeyChar != (char)Keys.Back;
               }

           }

           private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
           {
               if (char.IsLetter(e.KeyChar))
               {

               }
               else
               {
                   e.Handled = e.KeyChar != (char)Keys.Back;
               }

           }

           private void textBoxDocNumber_KeyPress_1(object sender, KeyPressEventArgs e)
           {
               if (char.IsNumber(e.KeyChar))
               {

               }
               else
               {
                   e.Handled = e.KeyChar != (char)Keys.Back;
               }
           }

           private void textBoxPhone_KeyPress_1(object sender, KeyPressEventArgs e)
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