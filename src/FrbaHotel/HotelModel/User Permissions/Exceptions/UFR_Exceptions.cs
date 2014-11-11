using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelModel.User_Permissions.Exceptions
{
    public class ActiveRoleNotSetException : Exception
    {
        public ActiveRoleNotSetException() { }

        public ActiveRoleNotSetException(String mess) : base(mess) {}

        public ActiveRoleNotSetException(String mess, Exception inner) : base(mess, inner) { }
    }
}
