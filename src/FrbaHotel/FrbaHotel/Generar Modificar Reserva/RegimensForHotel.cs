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
    public partial class RegimensForHotel : Form
    {
        RegimenHandler rh = new RegimenHandler();
        CreateBooking frm;
        Int32 id_hotel;

        public RegimensForHotel(Generar_Modificar_Reserva.CreateBooking frmBack)
        {
            this.frm = frmBack;
            InitializeComponent();
            id_hotel = Int32.Parse(textBoxId.Text);
            DataTable results = rh.getRegimensForHotel(id_hotel).Tables[0];
            BindingSource bs = new BindingSource();
            bs.DataSource = results;
            dataGridViewReg.DataSource = bs;

        }

        private void dataGridViewReg_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 id_regimen = (Int32)this.dataGridViewReg.Rows[e.RowIndex].Cells[0].Value;
            String name = (String) this.dataGridViewReg.Rows[e.RowIndex].Cells[1].Value;
            this.frm.setRegimen(id_regimen, name);
            this.Hide();
        }

        

      


    }
}
