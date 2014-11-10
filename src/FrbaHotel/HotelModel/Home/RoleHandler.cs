using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    public class RoleHandler
    {
        public Boolean insertRole(String roleName) {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].insertRole")
                                            .WithParam("@RoleName").As(SqlDbType.VarChar).Value(roleName)
                                            .WithParam("@RoleCreated").As(SqlDbType.Int).AsOutput()
                                            .Execute();

            return (Boolean)results["RoleCreated"];
        }

    }
}
