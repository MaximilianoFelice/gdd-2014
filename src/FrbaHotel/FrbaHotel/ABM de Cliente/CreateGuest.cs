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
        bool insertable = false;


        public CreateGuest()
        {
            InitializeComponent();
            /*if we decide to add a table typedoc, add here: 
             * connect to db, select to load combobox values and closed connection
             * // Connect to DB
             * HotelModel.ConnectionManager.OpenConnection();
             * //Get all doc types from DB, something like:
             *SqlResults results = new SqlQuery("SELECT DocTypeName FROM BOBBY_TABLES.TypeDoc").Execute();
             * DataSet ReturnedSet = (DataSet) results["ReturnedValues"]
             * while (ReturnedSet distinto de nuo){
             *   comboBoxDocType.Items.Add(lector.GetString(0));//added to a list 
             * }
             * HotelModel.ConnectionManager.CloseConnection();
             */
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {


            this.validateInput();



            if (insertable)
            {
                GuestHandler newGuest = new GuestHandler();
                bool guestExists = newGuest.PersonExistance(name, lastname, docType,
                                         docNumber, birthDate);
                if (!guestExists)
                {
                    Int32 idInserted = newGuest.insertPerson(name, lastname, docType,
                                          docNumber, mail, phone, birthDate, street,
                                          streetNum, floor, dept, nationality);
                }


                MessageBox.Show("Guest added with id:");
            }
        }


        public bool validateInput()
        {
            var insertable = true;

            //validates mandatory field name
            name = textBoxName.Text;
            if (!String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the name. Mandatory Field");
            }


            //validates mandatory field lastname
            lastname = textBoxLastname.Text;
            if (!String.IsNullOrEmpty(lastname))
            {
                insertable = false;
                MessageBox.Show("Please enter the lastname. Mandatory Field");
            }


            //validates mandatory field doctype
            docType = comboBoxDocType.Text;
            if (!String.IsNullOrEmpty(docType))
            {
                insertable = false;
                MessageBox.Show("Please enter the document type. Mandatory Field");
            }


            //validates decimal type in docnumber
            try
            {
                docNumber = Decimal.Parse(textBoxDocNumber.Text);
            }
            catch (FormatException)
            {
                insertable = false;
                MessageBox.Show("Document Number has an invalid type");
            }



            //validates decimal type in phone
            try
            {
                phone = Decimal.Parse(textBoxPhone.Text); ;

            }
            catch (FormatException)
            {
                insertable = false;
                MessageBox.Show("Phone Number has an invalid type");
            }




            //validates datetime type in birthdate
            try
            {
                birthDate = DateTime.Parse(textBoxBirthDate.Text);

            }
            catch (FormatException)
            {
                insertable = false;
                MessageBox.Show("Birth Date has an invalid type");
            }




            //validates int type in street num
            try
            {
                streetNum = Int32.Parse(textBoxStreetNum.Text);
            }
            catch (FormatException)
            {
                insertable = false;
                MessageBox.Show("Street Num has an invalid type");
            }

            //validates int type in floor
            try
            {
                floor = Int32.Parse(textBoxFloor.Text);
            }
            catch (FormatException)
            {
                insertable = false;
                MessageBox.Show("Street Num has an invalid type");
            }


            //complete assignments
            street = textBoxStreet.Text;
            mail = textBoxEmail.Text;
            dept = textBoxDept.Text;
            nationality = textBoxNationality.Text;

            return insertable;

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
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
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
            textBoxBirthDate.Clear();
            textBoxStreet.Clear();
            textBoxDept.Clear();
            textBoxFloor.Clear();
            textBoxStreetNum.Clear();
            textBoxDept.Clear();
            textBoxNationality.Clear();

        }

    }
}