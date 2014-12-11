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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Boolean ret = User.ValidateLogin("MaximilianoFelice", "53acbedaad48d8d482fe1a9bf8cd8b8e329ff8033c5c1dc81dcccdff38dd197f");
            ActiveUser.LoadUser("MaximilianoFelice", User.GetRoles("MaximilianoFelice"));
            ActiveUser.ActivateRole("admin");

            this.Close();
        }
    }
}
