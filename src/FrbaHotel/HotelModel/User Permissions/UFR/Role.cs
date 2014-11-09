using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelModel;
using HotelModel.DB_Conn_DSL;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HotelModel.User_Permissions.UFR
{

    public class Role
    {
        private int role_id;
        
        private String role_name;

        public Role(DataRow RoleRow)
        {
            role_id = (int)RoleRow["id_role"];
            role_name = (String)RoleRow["name"];

        }
    }
}
