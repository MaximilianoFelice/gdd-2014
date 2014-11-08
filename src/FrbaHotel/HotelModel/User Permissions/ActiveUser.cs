using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelModel;
using HotelModel.DB_Conn_DSL;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;
using HotelModel.User_Permissions.UFR;
using System.Windows.Forms;

namespace HotelModel.User_Permissions
{
    public static class ActiveUser
    {
        private static String User;

        private static List<Role> User_Roles = new List<Role>();

        public static void LoadUser(String Username, DataSet Roles)
        {
            User = Username;

            for (int i = 0; Roles.Tables[0].Rows.Count < i; i++)
            {
                User_Roles.Add(new Role(Roles.Tables[0].Rows[i]));
            }
        }

        public static void HasAccess(Control control) 
        {
            throw new NotImplementedException();
        }

        public static void HasVisibility(Control control)
        {
            throw new NotImplementedException();
        }
    }
}
