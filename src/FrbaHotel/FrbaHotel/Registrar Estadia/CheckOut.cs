using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class CheckOut : Form
    {
        Int32 id_booking;
        BookingHandler bh = new BookingHandler();
        StayHandler sh = new StayHandler();
        Int32 holder;
        DateTime checkin;
        Int32 hotel;
        Int32 regimen;
        Int32 nights;
        Int32 roomType;
        Int32 extraGuests;
        Stay stay;

        public CheckOut(Stay frmBack)
        {
            stay = frmBack;
            InitializeComponent();
            this.loadInformation();
        }
        private void loadInformation() {
            textBoxId.Text = id_booking.ToString();
            this.setBookingInfo();
            this.setHolder();
        }

        private void setBookingInfo() {
            DataTable dt = bh.getBookingInformation(id_booking).Tables[0];
            checkin = (DateTime)dt.Rows[0][5];
            textBoxCheckIn.Text = checkin.ToString();
            nights = (Int32)dt.Rows[0][6];
            textBoxNights.Text = nights.ToString();
            hotel = Convert.ToInt32(dt.Rows[0][2]);
            textBoxHotel.Text = hotel.ToString();
            regimen = Convert.ToInt32(dt.Rows[0][1]);
            textBoxRegimen.Text = regimen.ToString();
            extraGuests = (Int32)dt.Rows[0][4];
            textBoxGuests.Text = extraGuests.ToString();
            // add when merge with new table with roomtype field in booking table textBoxRoomType.Text = dt.Rows[0][].ToString();
        }

        private void setHolder() {
            DataTable holders = bh.getHolderBooking().Tables[0];
            holder = Convert.ToInt32(holders.Rows[0][0]);
        }

        public void setIdBooking(Int32 id) {
            id_booking = id;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            stay.Show();
            this.Hide();
        }

        private void buttonExtras_Click(object sender, EventArgs e)
        {
            this.setGuestsOfBookingCheckedOut();
            Registrar_Consumible.EnterExtraStay frm = new FrbaHotel.Registrar_Consumible.EnterExtraStay();
            frm.textBoxCode.Text = id_booking.ToString();

        }

        private void setGuestsOfBookingCheckedOut(){
            Boolean ok = sh.setCheckOutGuests(this.id_booking);
            
        }
    }
}
