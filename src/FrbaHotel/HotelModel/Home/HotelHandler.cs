using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    public class HotelHandler
    {
        

        public DataTable getHotels()
        {
            SqlResults results = new SqlQuery("SELECT name FROM BOBBY_TABLES.HOTELS WHERE stat=401").Execute();
            return (DataTable)results["ReturnedValues"];
        
        }

        public DataSet getRegimensForHotels() {
            SqlResults results = new SqlQuery("SELECT DISTINCT * FROM BOBBY_TABLES.REGIMENS ").Execute();
            return (DataSet)results["ReturnedValues"];
        
        
        }

       

    }
}
