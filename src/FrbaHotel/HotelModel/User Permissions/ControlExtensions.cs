using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelModel.User_Permissions
{
    public static class ControlExtensions
    {
        public static void HandleVisibility(this Control ctrl)
        {
            PermissionManager.addVisibleControl(ctrl);
        }

        public static void HandleAccess(this Control ctrl)
        {
            PermissionManager.addAccessibleControl(ctrl);
        }
    }
}
