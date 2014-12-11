using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class CheckOut : Form
    {
        Int32 id_booking;

        public CheckOut()
        {
            InitializeComponent();
        }

        public void setIdBooking(Int32 id) {
            id_booking = id;
        }
    }
}
