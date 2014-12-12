using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelModel.User_Permissions.UI
{
    public partial class ChooseOption : Form
    {
        private DataTable _internalTable;
        private Action<object> _callback;

        public ChooseOption(DataTable dt, String value, String display, Action<object> callback)
        {
            InitializeComponent();

            _internalTable = dt;
            _callback = callback;

            lstRoles.DataSource = _internalTable;
            lstRoles.ValueMember = value;
            lstRoles.DisplayMember = display;

        }

        private void lstRoles_DoubleClick(object sender, EventArgs e)
        {
            _callback.Invoke(lstRoles.SelectedValue);
            this.Close();
        }
    }
}
