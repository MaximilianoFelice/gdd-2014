using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel;
using HotelModel.DB_Conn_DSL;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class CreateRoom : Form
    {
        public bool insertable = false;
        public CreateRoom()
        {
            InitializeComponent();
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
                this.insertRoom();
            }
            else
            {
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
            validateRoomExistance();

            //validates that all the mandatory fields have values
            validateMandatoryFields();



        }


        public void validateRoomExistance()
        {

            SqlResults results = new SqlQuery("SELECT *FROM [BOBBY_TABLES].").Execute();

            DataSet ReturnedSet = (DataSet)results["ReturnedValues"];

            if (ReturnedSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Room already exists. Try Updating the information");
            }
            else
            {
                insertable = true;
            }

        }
        public void validateMandatoryFields()
        {

            if (insertable)
            {
                MessageBox.Show("Missing mandatory information. Please enter a valid Document Type, Document Number and E-mail");
            }
            else
            {
                insertable = true;

            }
        }

        public void insertRoom()
        {

            //open the DB connection
            HotelModel.ConnectionManager.OpenConnection();

            SqlStoredProcedure insertPerson = new SqlStoredProcedure("insertPerson");
            //query insert into table
            SqlResults query = new SqlQuery("INSERT INTO BOBBY_TABLES.").Execute();

            //close DB connection
            HotelModel.ConnectionManager.CloseConnection();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
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

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            DataTable hotels = getHotels();
            comboBoxHotel.DataSource = hotels.Columns;
        }

        public DataTable getHotels()
        {
            DataTable dataTable = new DataTable();

            //open the DB connection
            HotelModel.ConnectionManager.OpenConnection();

            //SqlStoredProcedure insertPerson = new SqlStoredProcedure("insertPerson");
            //query insert into table
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOBBY_TABLES.Hotels");
            //SqlResults query = new SqlQuery("SELECT * FROM BOBBY_TABLES.Hotels").Execute();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);

            //close DB connection
            HotelModel.ConnectionManager.CloseConnection();

            return dataTable;
        }
    }
}
