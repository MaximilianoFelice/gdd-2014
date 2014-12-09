using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class BookingConfirmation : Form
    {
        BookingHandler bh = new BookingHandler();
        CreateBooking frm;
        Int32 id_hotel;
        Int32 id_regimen;
        DateTime checkin;
        DateTime checkout;
        Int32 extraGuests;
        Int32 id_roomtype;


        public BookingConfirmation(CreateBooking frmBack)
        {
            this.frm = frmBack;
            InitializeComponent();
           

        }

        public void setTotalPrice(Int32 id_hotel, Int32 id_regimen, DateTime checkin, DateTime checkout, Int32 extraGuests, Int32 id_roomtype) {
            Int32 price = bh.getBookingPrice(id_hotel, id_regimen, checkin, checkout, extraGuests, id_roomtype);
            textBoxTotalPrice.Text = Convert.ToString(price);
        
        }

        public void setValues(Int32 id_h, Int32 id_reg, DateTime cin, DateTime cout, Int32 guests, Int32 id_rt) {
            id_hotel = id_h;
            id_regimen= id_reg;
            checkin= cin;
            checkout = cout;
            extraGuests = guests;
            id_roomtype = id_rt;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Boolean inserted = bh.insertBooking(id_hotel,id_regimen, checkin, checkout, extraGuests, id_roomtype);
            if (inserted)
            {
                MessageBox.Show("Booking registered");
            }
            else {
                MessageBox.Show("Unable to register booking");
            }
        }

    }
}
