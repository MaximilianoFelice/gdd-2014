using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelModel.User_Permissions
{
    public interface PermissionManager
    { 
        void LoadPermissions();

        Boolean HasAccess(object Obj);

        Boolean HasVisibility(Control Control);
    }

}
