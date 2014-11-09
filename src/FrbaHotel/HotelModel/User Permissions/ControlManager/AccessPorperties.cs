using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelModel.User_Permissions.ControlManager
{
     partial class Control{

        private bool isNum = true;

        [PropertyTab("IsNumaric")]
        [Browsable(true)]
        [Description("TextBox only valid for numbers only"), Category("EmSoft")]
        public bool IsNumaricTextBox
        {
            get { return isNum; }
            set { isNum = value; }
        }

    }
}
