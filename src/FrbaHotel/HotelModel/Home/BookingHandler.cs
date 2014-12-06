﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    public class BookingHandler
    {
        public Boolean insertBooking(String hotelName, String regimenType, String docType, Decimal docNumber,
                                    Int32 extraGuests, DateTime checkIn, DateTime checkOut)
        { 
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_INSERT_BOOKING")
                                   .WithParam("@Hotel").As(SqlDbType.VarChar).Value(hotelName)
                                   .WithParam("@Regimen").As(SqlDbType.VarChar).Value(regimenType)
                                   .WithParam("@DocTypeHolder").As(SqlDbType.VarChar).Value(docType)
                                   .WithParam("@DocNumberHolder").As(SqlDbType.Decimal).Value(docNumber)
                                   .WithParam("@ExtraGuests").As(SqlDbType.Int).Value(extraGuests)
                                   .WithParam("@CheckInDate").As(SqlDbType.DateTime).Value(checkIn)
                                   .WithParam("@CheckOutDate").As(SqlDbType.DateTime).Value(checkOut)
                                   .WithParam("@Status").As(SqlDbType.Bit).AsOutput()
                                   .Execute();
            return (Boolean)results["Status"];
      
        }
    }
}