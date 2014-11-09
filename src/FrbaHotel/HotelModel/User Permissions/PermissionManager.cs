using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelModel;
using HotelModel.DB_Conn_DSL;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;

namespace HotelModel.User_Permissions
{
    public static class PermissionMgr
    {
        public static void Login(String Username, String Password)
        {
            /* Validating login */
            // TODO: Convert password to SHA_256
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].validateUserPass")
                                    .WithParam("@User").As(SqlDbType.VarChar).Value(Username.ToString())
                                    .WithParam("@Pass").As(SqlDbType.VarChar).Value(Password.ToString())
                                    .WithParam("@RESULT").As(SqlDbType.Bit).AsOutput()
                                    .Execute();

            if (!(Boolean)results["@RESULT"]) throw new NotImplementedException(); // TODO: Create new exception here

            /* Loading Active User */
            ActiveUser.LoadUser(Username, (DataSet) results["ReturnedValues"]); // Returned Values containing user roles
            
        }

        public static void LoadPermissions()
        {
            throw new NotImplementedException();
        }

    }
}
