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
            Int32 bookingCode = bh.insertBooking(id_hotel, id_regimen, checkin, checkout, extraGuests, id_roomtype);
            if (bookingCode > 0)
            {

                BookingHolder frm = new BookingHolder();
                var result = frm.ShowDialog();
                if (result == DialogResult.OK && frm.id_guest != 0)
                {
                   Boolean inserted = this.addGuestToBooking(bookingCode, frm.id_guest);
                   if (inserted)
                   {
                       MessageBox.Show("Booking registered with code:" + Convert.ToString(bookingCode));
                   }
                   else {
                       MessageBox.Show("Unable to set the booking holder.");
                   }
                }

              
            }else{
                MessageBox.Show("Unable to register booking");
            } 
            
        }


        public Boolean addGuestToBooking(Int32 id_booking, Int32 id_guest) {
            return bh.insertHolderToBooking(id_booking, id_guest);
        }

    }
}
