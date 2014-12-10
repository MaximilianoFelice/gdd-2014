using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class CreateExtra : Form
    {
        Int32 id_booking;
        ExtraHandler eh = new ExtraHandler();
        Int32 id_extra;
        String descr;
        float price;
        Int32 quantity;

        public CreateExtra()
        {
            InitializeComponent();
            this.loadComboBox();
            this.loadHeadersDataGridView();
           
        }

        private void loadComboBox() {
            //deberian ser extras para el hotel en particular
            comboBoxExtra.DataSource = eh.getExtras().Tables[0];
            comboBoxExtra.DisplayMember = "descr";
            comboBoxExtra.ValueMember = "id_extra";
        }

        private void loadHeadersDataGridView() {
            dataGridViewExtras.ColumnCount = 4;
            dataGridViewExtras.Columns[0].Name = "ID Extra";
            dataGridViewExtras.Columns[1].Name = "Extra Description";
            dataGridViewExtras.Columns[2].Name = "Price";
            dataGridViewExtras.Columns[3].Name = "Quantity";
        }

        public void setIdBooking(Int32 id) {
            id_booking = id;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            dataGridViewExtras.Rows.RemoveAt(dataGridViewExtras.CurrentRow.Index);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.setColumns();
            this.addRow();
        }

        private void setColumns() {
            descr= comboBoxExtra.Text;
            DataTable dt = eh.getExtras().Tables[0];
            foreach (DataRow row in dt.Rows) {
                if (row["descr"].ToString() == descr) { 
                    id_extra = Convert.ToInt32(row["id_extra"].ToString());
                    price= float.Parse(row["price"].ToString());
                }
            }

            quantity= (Int32)numericUpDown.Value;
        }

        private void addRow(){
            string[] row = new string[] { Convert.ToString(id_extra),descr ,Convert.ToString(price),Convert.ToString(quantity)};
            dataGridViewExtras.Rows.Add(row);
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
           Boolean allInclusive = validateDiscounts();
           if (allInclusive)
           {
               this.removeItems();
           }
           else {
               this.billItems();
           }
        }

        private Boolean validateDiscounts() {
            return eh.bookingHasAllInclusive(id_booking);
        }

        private void removeItems(){
            FormHandler.clearDataGridView(dataGridViewExtras);
        }

        private void billItems() {
          foreach(DataGridViewRow row in dataGridViewExtras.Rows){
              Int32 id = eh.addExtraToStay(id_booking, (Int32)row.Cells["id_extra"].Value);
              if (!(id > 0)) MessageBox.Show("Unable to insert extra with code:" + id.ToString());
          }
          Bill frm = new Bill(this);
          frm.dataGridView.DataSource = dataGridViewExtras.Rows;
          frm.textBoxBooking.Text = id_booking.ToString();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(groupBox);
            FormHandler.clearDataGridView(dataGridViewExtras);
        }
    }
}
