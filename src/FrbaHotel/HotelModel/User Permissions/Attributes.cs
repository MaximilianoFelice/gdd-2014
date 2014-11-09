using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelModel.User_Permissions
{
    [AttributeUsage(AttributeTargets.All)]
    public class HandlePermissionsAttribute : System.Attribute
    { 

    }

    [AttributeUsage(AttributeTargets.All)]
    public class HandleVisibilityAttribute : System.Attribute
    {

    }
}
