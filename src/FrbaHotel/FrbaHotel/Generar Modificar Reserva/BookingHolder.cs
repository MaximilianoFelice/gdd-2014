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
    public partial class BookingHolder : Form
    {
        GuestHandler gh = new GuestHandler();
        String mail { get; set; }
        String docType { get; set; }
        Decimal? docNumber { get; set; }
        public Int32 id_guest;
        
        public BookingHolder()
        {
            InitializeComponent();
            this.loadComboBoxDocType();
        }

        private void loadComboBoxDocType()
        {
            FormHandler.loadDocTypesToCombo(comboBoxDocType, this.gh);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.assignFilters();
           DataTable results = gh.filteredSearch(null, null,docType, docNumber, mail);
           BindingSource bs = new BindingSource();
           bs.DataSource = results; 
           dataGridViewResults.DataSource = bs;
        }

        private void assignFilters()
        {
            docType = comboBoxDocType.Text;
            docNumber = Decimal.Parse(textBoxDocNumber.Text);
            mail = textBoxEmail.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHandler.groupBoxCleaner(this.groupBoxFilters);
            FormHandler.clearDataGridView(this.dataGridViewResults);
        }

        private void textBoxDocNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxDocNumber.Text))
            {
                FormHandler.validateDecimalTextBox(textBoxDocNumber, errorProvider, buttonSearch);
            }
        }

        private void textBoxDocNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormHandler.allowOnlyNumbers(sender, e);
        }


        private void dataGridViewResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_guest = Convert.ToInt32(dataGridViewResults.Rows[e.RowIndex].Cells[0].Value.ToString());
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.CreateGuest frm = new FrbaHotel.ABM_de_Cliente.CreateGuest();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK && frm.inserted != 0)
            {
               this.id_guest = frm.inserted;
               DialogResult = DialogResult.OK;
               this.Close();
            }
        }
     
    }
}
