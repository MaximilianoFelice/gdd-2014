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

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class CreateRoom : Form
    {

        Int32 hotel { get; set; }
        Int32 number { get; set; }
        Int32 floor { get; set; }
        Int32 type { get; set; }
        Int32 location { get; set; }
        String description { get; set; }
        bool insertable = true;


        public CreateRoom()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {


            this.validateInput();



            if (insertable)
            {
                RoomHandler newRoom = new RoomHandler();
                bool roomExists = newRoom.RoomExistance(hotel, number);
                if (!roomExists)
                {
                    Int32 idInserted = newRoom.insertRoom(hotel, number, floor, type,
                                                    location, description);
                }


                MessageBox.Show("Room added with id:");
            }
        }


        public bool validateInput()
        {
            /*
            //validates mandatory field doctype
            hotel = comboBoxHotel.Text;
            if (String.IsNullOrEmpty(hotel))
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
            nationality = textBoxNationality.Text;*/

            return true;

        }





        //allows only numbers and . in docnumber field
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

        //allows only numbers and - on phone numbers
        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
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
            comboBoxHotel.Text = "";
            comboBoxLocation.Text = "";
            comboBoxType.Text = "";
            textBoxFloor.Clear();
            textBoxDescription.Clear();
            textBoxNumber.Clear();

        }

    }
}
