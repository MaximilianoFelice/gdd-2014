﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ExtensionMethods;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    public class StatisticsHandler
    {
        public DataTable cancelledBookings(DateTime from, DateTime to){
        
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_STATISTICS_CANCEL_BOOKINGS")
                                .WithParam("@From").As(SqlDbType.DateTime).Value(from)
                                .WithParam("@To").As(SqlDbType.DateTime).Value(to)
                                .WithParam("@ReturnedValues").AsDataTable().AsOutput()
                                 .Execute();


            return (DataTable) results["@ReturnedValues"];
        
        }
             
       public DataTable extraBilled(DateTime from, DateTime to){
        
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_STATISTICS_EXTRA_BILLED")
                                .WithParam("@From").As(SqlDbType.DateTime).Value(from)
                                .WithParam("@To").As(SqlDbType.DateTime).Value(to)
                                .WithParam("@ReturnedValues").AsDataTable().AsOutput()
                                 .Execute();


            return (DataTable) results["@ReturnedValues"];
        }
            
        public DataTable outService(DateTime from, DateTime to){
        
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_STATISTICS_OUT_SERVICE")
                                .WithParam("@From").As(SqlDbType.DateTime).Value(from)
                                .WithParam("@To").As(SqlDbType.DateTime).Value(to)
                                .WithParam("@ReturnedValues").AsDataTable().AsOutput()
                                 .Execute();


            return (DataTable) results["@ReturnedValues"];
        }
        
       public DataTable guestsPoints(DateTime from, DateTime to){
        
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_STATISTICS_GUESTS_POINTS")
                                .WithParam("@From").As(SqlDbType.DateTime).Value(from)
                                .WithParam("@To").As(SqlDbType.DateTime).Value(to)
                                .WithParam("@ReturnedValues").AsDataTable().AsOutput()
                                 .Execute();


            return (DataTable) results["@ReturnedValues"];
        }
                   
        public DataTable occupiedRooms(DateTime from, DateTime to){
        
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_STATISTICS_OCCUPIED_ROOMS")
                                .WithParam("@From").As(SqlDbType.DateTime).Value(from)
                                .WithParam("@To").As(SqlDbType.DateTime).Value(to)
                                .WithParam("@ReturnedValues").AsDataTable().AsOutput()
                                 .Execute();


            return (DataTable) results["@ReturnedValues"];
        }
                  


    }
}
