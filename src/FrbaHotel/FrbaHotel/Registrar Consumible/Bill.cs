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
    public partial class Bill : Form
    {
        public Int32 id_booking;
        float price;
        StayHandler sh = new StayHandler();
        BookingHandler bh = new BookingHandler();
        BillHandler bih = new BillHandler();
        CreateExtra frm;
        float totalPrice = 0;

        public Bill(CreateExtra frmBack)
        {
            this.frm = frmBack;
            InitializeComponent();
            this.loadHeaders();
            this.loadStay();
            comboBoxMode.Enabled = false;
            buttonCharge.Enabled = false;
        }

        private void loadHeaders() {
            dataGridView.ColumnCount = 4;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Description";
            dataGridView.Columns[2].Name = "Price";
            dataGridView.Columns[3].Name = "Quantity";
        }
        private void loadStay() {
            this.getStayInformation();
            
        }

        private void getStayInformation() {//falta lo de si abandonan antes la habitacion
            price = sh.getStayPrice(id_booking);
            Int32 nights= sh.getNights(id_booking);
            this.addRowToDataGridView(id_booking, "Stay in the hotel", price,nights);
            this.billComplementaryNights(); // si se retiro antes de la fecha para la que realizo el booking se le factura igual
        }
         
        private void addRowToDataGridView(Int32 id, String descr, float price, Int32 quantity) {
            string[] row = new string[] { Convert.ToString(id), descr, Convert.ToString(price), Convert.ToString(quantity) };
            dataGridView.Rows.Add(row);
        }

        private void billComplementaryNights() {
            Int32 extraNights = sh.getExtraNights(id_booking);
            this.addRowToDataGridView(id_booking, "Complementary nights", price,extraNights);
        }

        private void buttonCharge_Click(object sender, EventArgs e)
        {
            Boolean billed = bih.saveBill(id_booking, comboBoxMode.Text);
            if (billed)
            {
                MessageBox.Show("Bill Registered");
                this.Hide();
            }
            else {
                MessageBox.Show("Unable to register bill");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            FormHandler.validateEmptyComboBox(comboBoxMode, errorProvider, buttonCharge);
        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            textBoxBooking.Text = id_booking.ToString();
            comboBoxMode.Enabled = true;
            this.getTotalPrice();
            textBoxPrice.Text = totalPrice.ToString();
        }

        private void getTotalPrice() {
            foreach (DataGridViewRow row in dataGridView.Rows) {
                this.totalPrice = this.totalPrice + ((float)row.Cells["Price"].Value * (Int32)row.Cells["Quantity"].Value); 
            }
        }

        
    }
}
