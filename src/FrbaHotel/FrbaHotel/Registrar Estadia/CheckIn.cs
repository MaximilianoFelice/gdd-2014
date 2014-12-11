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
    public partial class CheckIn : Form
    {
        Int32 id_booking;
        Int32 id_holder;
        DateTime checkin;
        Int32 nights;
        Int32 hotel;
        Int32 regimen;
        Int32 roomType;
        Int32 extraGuests;
        BookingHandler bh = new BookingHandler();
        GuestHandler gh = new GuestHandler();
        StayHandler sh = new StayHandler();
     
        public CheckIn()
        {
            InitializeComponent();
            this.loadHeadersDataGridView();
            this.loadInformation();
        }

        private void loadHeadersDataGridView() {
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "Id Guest";
            dataGridView.Columns[1].Name = "Name, Lastname";
            dataGridView.Columns[2].Name = "Doc Type";
            dataGridView.Columns[3].Name = "Doc Number";
            dataGridView.Columns[4].Name = "Mail";
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
        private void setHolder()
        {
            DataTable holder = bh.getHolderBooking().Tables[0];
            foreach (DataRow row in holder.Rows)
            {
                if (Convert.ToInt32(row["id_booking"]) == id_booking && Convert.ToInt32(row["stat"].ToString()) == 904)
                {
                    id_holder = Convert.ToInt32(row["id_person"]);
                    textBoxHolder.Text = id_holder.ToString();
                    this.addHolderToDataGrid();
                }

            }
        }

        private void addHolderToDataGrid() {
            DataTable dt = gh.getGuestInformation(id_holder);
            String name = dt.Rows[0][0].ToString();
            String lastname = dt.Rows[0][1].ToString();
            String docType = dt.Rows[0][2].ToString();
            Decimal docNumber = (Decimal)dt.Rows[0][3];
            String mail = dt.Rows[0][4].ToString();
            addRowToDataGrid(id_holder, name + lastname, docType, docNumber, mail);
        }

        public void addRowToDataGrid(Int32 id, String completeName, String docType, Decimal docNumber, String mail) {
            string[] row = new string[] {id.ToString(), completeName, docType, docNumber.ToString(), mail};
            dataGridView.Rows.Add(row);
        }
        public void setIdBooking(Int32 id)
        {
            id_booking = id;
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (checkin != DateTime.Today)
            {
                MessageBox.Show("The date of your reservation has passes. You need to register again your booking");
            }
            else {
                if(dataGridView.Rows.Count == extraGuests){
                    MessageBox.Show("There is a mismatch between the booking extra guests and the ones added");
                }else{
                    foreach (DataGridViewRow row in dataGridView.Rows) {
                        Boolean inserted = bh.insertGuestToBooking(id_booking, (Int32)row.Cells["Id Guest"].Value);
                        if (!inserted) {
                            MessageBox.Show("Unable to insert guest with id:" + row.Cells["Id Guest"].Value);
                        } 
                    }

                    this.checkIn();
                }
                
            }
        }

        private void checkIn() {
            Int32 roomNumber = sh.insertStay(id_booking, hotel, regimen,roomType, checkin, nights);
            if (roomNumber > 0) MessageBox.Show("Welcome. Your room number is: " + roomNumber.ToString());
            else MessageBox.Show("Unable to checkin");
        }
    }
}
