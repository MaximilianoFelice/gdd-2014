using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel;
using HotelModel.DB_Conn_DSL;


namespace FrbaHotel.ABM_de_Cliente
{
    public partial class CreateGuest : Form
    {
        public bool insertable = false;
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

        private void comboBoxDocType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*validates that the input data corresponds to data format and obligatory values
             * if data is correct, then insertable true
             * if data is incorrect, then insertable false
             */ 
            this.validateInput();
            if (insertable)
            {
                /*insert the loaded data to persons table*/
                this.insertPerson();
            }
            else { 
                //Message
            }
           
            
        }

        public void validateInput()
        {
            /*verificar que la fecha no sea mayor a hoy
             * verificar el formato de las fechas
            */
            //validateDateTime();

            //validates if guest already exists
            validateGuestExistance();
            
            //validates that all the mandatory fields have values
            validateMandatoryFields();



        }


        public void validateGuestExistance() { 
        
         SqlResults results = new SqlQuery("SELECT *FROM [BOBBY_TABLES].PERSONS WHERE doc_type ="
                                            +comboBoxDocType+", doc_number ="+textBoxDocNumber+
                                            ", lastname ="+textBoxLastname+", name="+textBoxName+
                                            "birthdate="+textBoxBirthDate+";").Execute();

         DataSet ReturnedSet = (DataSet) results["ReturnedValues"];
            
         if (ReturnedSet.Tables[0].Rows.Count > 0)
         {
             MessageBox.Show("Guest already exists. Try Updating the information");
         }
        else
        {
            insertable = true;
        
        }
        
        }
        public void validateMandatoryFields() { 
        
            if (insertable || (textBoxEmail.Text == " ") || (textBoxDocNumber.Text == " ") || (comboBoxDocType.Text == " "))
            {
                MessageBox.Show("Missing mandatory information. Please enter a valid Document Type, Document Number and E-mail");
            }
            else 
            {
                insertable = true;
                  
            }
        }

        public void insertPerson() {

           //open the DB connection
            HotelModel.ConnectionManager.OpenConnection();

            //query insert into table
            SqlResults query = new SqlQuery("INSERT INTO BOBBY_TABLES.Persons (name, lastname, doc_type, doc_number, mail, phone, birthdate, addr, nationality) VALUES" 
                                            + textBoxName+ textBoxLastname+ comboBoxDocType + textBoxDocNumber+ 
                                            textBoxEmail+textBoxPhone+ textBoxBirthDate+textBoxAddress+textBoxNationality).Execute();
          
            //close DB connection
            HotelModel.ConnectionManager.CloseConnection();   
        }

        private void textBoxDocNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)|| e.KeyChar== '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

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

    }
}
