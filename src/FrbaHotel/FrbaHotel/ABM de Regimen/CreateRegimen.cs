using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.ABM_de_Regimen
{
    public partial class CreateRegimen : Form
    {
        Int32 idRegimen;
        String description;
        float price;
        bool insertable =true;
        
        public CreateRegimen()
        {
            InitializeComponent();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            textBoxDescription.Clear();
            textBoxPrice.Clear();
        }

        public void buttonSave_Click(object sender, EventArgs e)
        {
            this.validateInput();
            if (insertable) {
                RegimenHandler newRegimen = new RegimenHandler();
                Boolean regimenExists = newRegimen.regimenExistance(idRegimen);
                if (!regimenExists)
                {
                    Boolean created =newRegimen.createRegimen(idRegimen, description, price);
                    if (created)
                    {
                        MessageBox.Show("Regimen Created");
                    }
                    else {
                        MessageBox.Show("Unable to create regimen");
                    }

                }
                else {
                    MessageBox.Show("Regimen already exists");
                };


                
            }
        }


        private void validateInput(){

            try {
                idRegimen = Int32.Parse(textBoxRegCode.Text);
            }
            catch(FormatException) {
                MessageBox.Show("Regimen Code has an invalid type");    
            }
            
            
            if (String.IsNullOrEmpty(textBoxDescription.Text))
            {
                MessageBox.Show("Please enter a Regimen description");
                insertable = false;
            }
            else {
                description = textBoxDescription.Text;
                
            }

            try 
            {
                price = float.Parse(textBoxPrice.Text);
            }catch(FormatException) {
                insertable = false;
                MessageBox.Show("Invalid type at Price");
                
            }




        
        
        }

       
    }
}
