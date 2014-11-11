using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;
using HotelModel.DB_Conn_DSL;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class DeleteGuest : Form
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


        public DeleteGuest()
        {
            InitializeComponent();
        }



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

        private void buttonSearchAll_Click(object sender, EventArgs e)
        {

            SqlResults results = new SqlQuery("SELECT * FROM [BOBBY_TABLES].PERSONS;").AsDataTable().Execute();

            DataTable ReturnedTable = (DataTable)results["ReturnedValues"];

            dataGridViewResults.DataSource = ReturnedTable;


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            this.validateInput();
            GuestHandler searchGuests = new GuestHandler();
            DataTable dt = searchGuests.filteredSearch(name, lastname, docType,
                                          docNumber, mail, phone, birthDate, street,
                                          streetNum, floor, dept, nationality, state);
            dataGridViewResults.DataSource = dt; 
            dataGridViewResults.AutoGenerateColumns = true;
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
            {
                Name = "Delete",
                HeaderText = "Select to Delete",
                FalseValue = 0,
                TrueValue = 1,
                Visible = true
            };
            dataGridViewResults.Columns.Add(chk);
            
        }

     




        public bool validateInput()
        {
         
            name = textBoxName.Text;
            lastname = textBoxLastname.Text;
            docType = comboBoxDocType.Text;
          
            //validates decimal type in docnumber
            if(!String.IsNullOrEmpty(textBoxDocNumber.Text)){
                try
                {
                     docNumber = Decimal.Parse(textBoxDocNumber.Text);
                }
                catch (FormatException)
                {
                
                    MessageBox.Show("Document Number has an invalid type");
                }

            }else{
                    docNumber= -1;
            }

            //validates decimal type in phone
            if(!String.IsNullOrEmpty(textBoxPhone.Text))
            {
                try
                 {
                     phone = Decimal.Parse(textBoxPhone.Text); ;

                  }
                 catch (FormatException)
                 {
               
                     MessageBox.Show("Phone Number has an invalid type");
                  }
            }else{
                phone=-1;
            }




            //validates datetime type in birthdate
            if(!String.IsNullOrEmpty(textBoxBirthDate.Text))
            {
                try
                {
                     birthDate = DateTime.Parse(textBoxBirthDate.Text);
                }
                catch (FormatException)
                {
                   MessageBox.Show("Birth Date has an invalid type");
                }
            }




            //validates int type in street num
            try
            {
                streetNum = Int32.Parse(textBoxStreetNum.Text);
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Street Num has an invalid type");
            }

            //validates int type in floor
            try
            {
                floor = Int32.Parse(textBoxFloor.Text);
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Street Num has an invalid type");
            }

            return true;

    }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            //https://social.msdn.microsoft.com/Forums/en-US/4aca22b9-4453-40d9-a76d-a69ed4399783/how-to-remove-selected-checkbox-item-of-datagridview-as-well-as-database-item?forum=csharplanguage
            List<int> rowsToDelete = new List<int>();
 

            foreach (DataGridViewRow row in dataGridViewResults.Rows)
                    {
                        DataGridViewCheckBoxCell checkBox = dataGridViewResults[0, row.Index] as DataGridViewCheckBoxCell;
                            
                        if (Convert.ToBoolean(checkBox.Value) == true)//checking if tick is added
                            {
                                //deleting from DB:
                                GuestHandler gh = new GuestHandler();
                                int idDeleted = gh.deletePerson(name,lastname,docType,docNumber,mail,phone,birthDate,
                                     street,streetNum,floor,dept,nationality);

                               
                                //deleting from DGV (now adding into a list, and deleting it afterwards):
                                rowsToDelete.Add(row.Index);
                            }
                        }
             //deleting rows from DGV:
            foreach (int row in rowsToDelete)
                dataGridViewResults.Rows.RemoveAt(row);
         }
    }
           
}
