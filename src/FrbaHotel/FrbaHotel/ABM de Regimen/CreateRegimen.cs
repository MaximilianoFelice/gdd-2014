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
        ValidationsHandler vh = new ValidationsHandler();
        RegimenHandler rh = new RegimenHandler();
        
        public CreateRegimen()
        {
            InitializeComponent();
        }

        

        private void buttonClear_Click(object sender, EventArgs e)
        {


            textBoxPrice.Clear();
        }

        public void buttonSave_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren()){
                Boolean regimenExists = rh.regimenExistance(description, price);
                if (!regimenExists)
                {
                    Boolean created =rh.createRegimen(description, price);
                    if (created)
                    {
                        MessageBox.Show("Regimen Created");
                    }
                    else {
                        MessageBox.Show("Unable to create regimen");
                    }

                }else {
                    MessageBox.Show("Regimen already exists");
                }
            
            }else{
                MessageBox.Show("Invalid Input Data");
            }
            


                
            }



        private void textBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            if(vh.validateNullString(textBoxDescription.Text)){
                errorProvider.SetError(textBoxDescription, "Please enter the regimen description.");
                e.Cancel = true;
            }else{
                errorProvider.SetError(textBoxDescription, "");
                description=textBoxDescription.Text;
                e.Cancel=false;
            }

        
        }

        private void textBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            if(vh.validateNullString(textBoxPrice.Text)){
                errorProvider.SetError(textBoxPrice, "Please enter the regimen price.");
                e.Cancel = true;
            }else{
                if(vh.validateFloat(textBoxPrice.Text)){
                    errorProvider.SetError(textBoxPrice, "Invalid type");
                    e.Cancel = true;
                }else{
                    errorProvider.SetError(textBoxPrice, "");
                    price=float.Parse(textBoxPrice.Text);
                    e.Cancel=false;
                }
            }
        
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

       

  }     
        
}

        
