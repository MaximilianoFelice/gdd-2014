using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    public class BookingHandler
    {
        public Boolean checkAvailability(Int32 id_hotel, Int32 id_regimen, DateTime checkin, DateTime checkout, Int32 extraGuests, Int32 id_roomtype) {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_CHECK_AVAILABILITY")
                                .WithParam("@IdHotel").As(SqlDbType.Int).Value(id_hotel)
                                .WithParam("@IdRegimen").As(SqlDbType.Int).Value(id_regimen)
                                .WithParam("@CheckIn").As(SqlDbType.DateTime).Value(checkin)
                                .WithParam("@CheckOut").As(SqlDbType.DateTime).Value(checkout)
                                .WithParam("@ExtraGuests").As(SqlDbType.Int).Value(extraGuests)
                                .WithParam("@IdRoomType").As(SqlDbType.Int).Value(id_roomtype)
                                .WithParam("@Available").As(SqlDbType.Bit).AsOutput()
                                .Execute();
            return (Boolean)results["Available"];
        
        }
        
        public Int32 getBookingPrice(Int32 id_hotel, Int32 id_regimen, DateTime checkin, DateTime checkout, Int32 extraGuests, Int32 id_roomtype) {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_BOOKING_PRICE")
                                .WithParam("@IdHotel").As(SqlDbType.Int).Value(id_hotel)
                                .WithParam("@IdRegimen").As(SqlDbType.Int).Value(id_regimen)
                                .WithParam("@CheckIn").As(SqlDbType.DateTime).Value(checkin)
                                .WithParam("@CheckOut").As(SqlDbType.DateTime).Value(checkout)
                                .WithParam("@ExtraGuests").As(SqlDbType.Int).Value(extraGuests)
                                .WithParam("@IdRoomType").As(SqlDbType.Int).Value(id_roomtype)
                                .WithParam("@Price").As(SqlDbType.Int).AsOutput()
                                .Execute();
            return (Int32)results["Price"];
    }
        public Boolean insertBooking(Int32 id_hotel, Int32 id_regimen, DateTime checkin, DateTime checkout, Int32 extraGuests, Int32 id_roomtype)
        {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_INSERT_BOOKING")
                                .WithParam("@IdHotel").As(SqlDbType.Int).Value(id_hotel)
                                .WithParam("@IdRegimen").As(SqlDbType.Int).Value(id_regimen)
                                .WithParam("@CheckIn").As(SqlDbType.DateTime).Value(checkin)
                                .WithParam("@CheckOut").As(SqlDbType.DateTime).Value(checkout)
                                .WithParam("@ExtraGuests").As(SqlDbType.Int).Value(extraGuests)
                                .WithParam("@IdRoomType").As(SqlDbType.Int).Value(id_roomtype)
                                .WithParam("@Inserted").As(SqlDbType.Bit).AsOutput()
                                .Execute();
            return (Boolean)results["Inserted"];
      
        }



    }
}
