using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ExtensionMethods;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    public class RegimenHandler
    {

        public Boolean regimenExistance(Int32 regCode){
             SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].regimenExists")
                                    .WithParam("@IdRegimen").As(SqlDbType.Int).Value(regCode)
                                    .WithParam("@RESULT").As(SqlDbType.Bit).AsOutput()
                                    .Execute();

             return (Boolean)results["@RESULT"];
        
        }

        public Boolean createRegimen(int regCode, String description, float price){
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].createRegimen")
                                       .WithParam("@IdRegimen").As(SqlDbType.Int).Value(regCode)
                                       .WithParam("@Description").As(SqlDbType.VarChar).Value(description)
                                       .WithParam("@Price").As(SqlDbType.Float).Value(price)
                                       .WithParam("@RESULT").As(SqlDbType.Bit).AsOutput()
                                       .Execute();

            return (Boolean)results["@RESULT"];
        }

    }
}
