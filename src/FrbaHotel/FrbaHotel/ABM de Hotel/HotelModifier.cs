using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;
using HotelModel.Model;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class HotelModifier : Form
    {
        HotelHandler handler;

        public HotelModifier(HotelHandler HotelToModify)
        {
            InitializeComponent();

            handler = HotelToModify;

            BindControls();

            CheckRegimens();
        }

        private void BindControls()
        {
            /* Binding countries to comboBox */
            CountryModel.BindTo(comboBoxCountry);

            /* Binding regimens to checked listbox */
            checkedListBoxReg.DataSource = RegimenModel.regimen.Tables[0];
            checkedListBoxReg.DisplayMember = "descr";
            checkedListBoxReg.ValueMember = "id_regimen";
        }

        public void CheckRegimens()
        {
            for (int i = 0; i < checkedListBoxReg.Items.Count; i++)
            {
                DataRowView item = ((DataRowView)checkedListBoxReg.Items[i]);
                var res = false;
                if (handler.HasRegimen( (int) item.Row["id_regimen"] ) ) res = true;

                checkedListBoxReg.SetItemChecked(i, res);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            handler["name"] = textBoxName.Text;
            handler["mail"] = textBoxMail.Text;
            handler["phone"] = textBoxPhone.Text;
            handler["street"] = textBoxStreet.Text;
            handler["street_num"] = textBoxStreetNum.Text;
            handler["city"] = textBoxCity.Text;
            handler["country"] = comboBoxCountry.SelectedValue;
            handler["stars"] = numericUDStars.Value;

            handler.Update();
        }

        private void checkedListBoxReg_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /* Se agrega un nuevo state al check */
            if (e.NewValue == CheckState.Checked)
            {
                handler.AddRegimen((int) checkedListBoxReg.SelectedValue);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                handler.RemoveRegimen((int) checkedListBoxReg.SelectedValue);
            }
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }




        

 
    }
}
