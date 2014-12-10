using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    public class StayHandler
    {
        public DataSet getStays(Int32 id_booking) {
            SqlResults results = new SqlQuery("SELECT * FROM BOBBY_TABLES.STAYS").Execute();
            return (DataSet)results["ReturnedValues"];
 
        }

        public float getStayPrice(Int32 id_booking) {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_GET_STAY_PRICE")
                                .WithParam("@IdBooking").As(SqlDbType.Int).Value(id_booking)
                                .WithParam("@Price").As(SqlDbType.Float).AsOutput()
                                .Execute();
            return (float)results["@Price"];
        }

        public Int32 getNights(Int32 id_booking)
        {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_GET_NIGHTS")
                                .WithParam("IdBooking").As(SqlDbType.Int).Value(id_booking)
                                .WithParam("@Nights").As(SqlDbType.Int).AsOutput()
                                .Execute();
            return (Int32)results["@Nights"];
        }

        public Int32 getExtraNights(Int32 id_booking) {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_GET_EXTRA_NIGHTS")
                                .WithParam("IdBooking").As(SqlDbType.Int).Value(id_booking)
                                .WithParam("@Extra").As(SqlDbType.Int).AsOutput()
                                .Execute();
            return (Int32)results["@Extra"];
        }


    }
}
