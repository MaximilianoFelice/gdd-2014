using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    public class RegimenHandler
    {
        public DataSet getRegimensForHotels()
        {
            SqlResults results = new SqlQuery("SELECT DISTINCT * FROM BOBBY_TABLES.REGIMENS").Execute();
            return (DataSet)results["ReturnedValues"];

        }

        public DataSet getRegimenIdFromDescr(String descr)
        {
            SqlResults results = new SqlQuery("SELECT id_regimen FROM BOBBY_TABLES.REGIMENS WHERE descr="+descr).Execute();
            return (DataSet) results["ReturnedValues"];
        }
    }
}
