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
        ValidationsHandler vh;
        GuestHandler gh;
       


        public CreateGuest()
        {
            InitializeComponent();
            dtPickerBirhtDate.MaxDate = DateTime.Now;

        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                mail = textBoxEmail.Text;
                street = textBoxStreet.Text;
                dept = textBoxDept.Text;
                nationality = textBoxNationality.Text;
                this.assignState();


                bool guestExists = gh.PersonExistance(name, lastname, docType,
                                         docNumber, birthDate);
                if (!guestExists)
                {
                    Boolean inserted = gh.insertPerson(name, lastname, docType,
                                           docNumber, mail, phone, birthDate, street,
                                           streetNum, floor, dept, nationality, state);

                    if (inserted)
                    {
                        MessageBox.Show("Guest added");
                    }
                    else
                    {
                        MessageBox.Show("Error while inserting");

                    }

                }




            }
            else {
                MessageBox.Show("Invalid Input Data");
            }
                
                
                
            }


        //clears all fields
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxLastname.Clear();
            comboBoxDocType.Text = "";
            textBoxDocNumber.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            //textBoxBirthDate.Clear();
            textBoxStreet.Clear();
            textBoxDept.Clear();
            textBoxFloor.Clear();
            textBoxStreetNum.Clear();
            textBoxDept.Clear();
            textBoxNationality.Clear();
            

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

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            ValidationsHandler vh = new ValidationsHandler();
            if (vh.validateNullString(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, "Please enter the name of the customer.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxName, "");
                name = textBoxName.Text;
                e.Cancel = false;
            }

        }

        private void textBoxLastname_Validating(object sender, CancelEventArgs e)
        {
            ValidationsHandler vh = new ValidationsHandler();
            if (vh.validateNullString(textBoxLastname.Text))
            {
                errorProvider.SetError(textBoxLastname, "Please enter the lastname of the customer.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxLastname, "");
                lastname = textBoxLastname.Text;
                e.Cancel = false;
            }

        }

        private void comboBoxDocType_Validating(object sender, CancelEventArgs e)
        {
            ValidationsHandler vh = new ValidationsHandler();
            if (vh.validateNullString(comboBoxDocType.Text))
            {
                errorProvider.SetError(textBoxLastname, "Please enter the document type of the customer.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxLastname, "");
                docType = comboBoxDocType.Text;
                e.Cancel = false;
            }

        }


        private void textBoxDocNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidationsHandler vh = new ValidationsHandler();
            if (vh.validateDecimal(textBoxDocNumber.Text))
            {
                errorProvider.SetError(textBoxDocNumber, "Invalid type");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxDocNumber, "");
                 if(vh.validateNullString(textBoxPhone.Text))
                {
                    docNumber=-1;
                }else{
                    docNumber = Decimal.Parse(textBoxDocNumber.Text);
                }
                
                e.Cancel = false;
            }
        }

        private void textBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidationsHandler vh = new ValidationsHandler();
            if (vh.validateDecimal(textBoxPhone.Text))
            {
                errorProvider.SetError(textBoxPhone, "Invalid type");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(textBoxPhone, "");
                if(vh.validateNullString(textBoxPhone.Text))
                {
                    phone=-1;
                }else{
                    phone = Decimal.Parse(textBoxPhone.Text);
                }
                e.Cancel = false;
            }
        }


        private void textBoxStreetNum_Validating(object sender, CancelEventArgs e)
        {
            ValidationsHandler vh = new ValidationsHandler();
            if (vh.validateInt32(textBoxStreetNum.Text))
            {
                errorProvider.SetError(textBoxStreetNum, "Invalid type");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(textBoxStreetNum, "");
                if (vh.validateNullString(textBoxPhone.Text))
                {
                    streetNum = -1;
                }
                else
                {
                    streetNum = Int32.Parse(textBoxStreetNum.Text);
                }
                
                e.Cancel = false;
            }
        }

        private void textBoxFloor_Validating(object sender, CancelEventArgs e)
        {
            ValidationsHandler vh = new ValidationsHandler();
            if (vh.validateInt32(textBoxFloor.Text))
            {
                errorProvider.SetError(textBoxFloor, "Invalid type");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(textBoxFloor, "");
                if (vh.validateNullString(textBoxPhone.Text))
                {
                   floor = -1;
                }
                else
                {
                    floor = Int32.Parse(textBoxFloor.Text);
                } 
                e.Cancel = false;
            }
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

           //allows only numbers and - on phone numbers
           private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
           {
               if (char.IsNumber(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '(' || e.KeyChar == ')')
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

          

           


           
        

           

      

       

    }
}