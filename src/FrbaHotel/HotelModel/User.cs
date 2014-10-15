using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelModel;
using HotelModel.DB_Conn_DSL;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;


namespace FrbaHotel
{
    public static class User
    {

        public static Boolean ValidateLogin(String user, String password)
        {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].validateUserPass")
                                                .WithParam("@User").As(SqlDbType.VarChar).Value(user.ToString())
                                                .WithParam("@Pass").As(SqlDbType.VarChar).Value(password.ToString())
                                                .WithParam("@RESULT").As(SqlDbType.Bit).AsOutput()
                                                .Execute();

            return (Boolean) results["@RESULT"];
        }


    }
}
