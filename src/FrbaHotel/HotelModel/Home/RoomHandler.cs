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
    public class RoomHandler
    {

        public DataSet getRoomTypes() {
            SqlResults results = new SqlQuery("SELECT * FROM [BOBBY_TABLES].ROOM_TYPE;").Execute();

            return (DataSet) results["ReturnedValues"];
        
        }


        public DataSet getRoomLocations() {
            SqlResults results = new SqlQuery("SELECT * FROM [BOBBY_TABLES].ROOM_LOCATION;").Execute();

            return (DataSet)results["ReturnedValues"];
        }

        public DataSet getRoomTypeIdFromDescr(String descr){
            SqlResults results = new SqlQuery("SELECT id_roomtype FROM [BOBBY_TABLES].ROOM_TYPE WHERE descr =" + descr).Execute();
            return (DataSet)results["ReturnedValues"];
        }

        public DataSet getRoomTypesForHotel(Int32 id_hotel) {
            SqlResults results = new SqlQuery("SELECT DISTICT rt.descr FROM [BOBBY_TABLES].ROOM_TYPE rt"
                                                + "JOIN [BOBBY_TABLES].ROOMS r ON r.id_roomtype= rt.id_roomtype"
                                                + "AND r.id_hotel = " + id_hotel).Execute();
            return (DataSet)results["ReturnedValues"];
        }

        public Boolean roomExists(Int32 roomNum, Int32 idHotel) {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_ROOM_EXISTS")
                                    .WithParam("@RoomNum").As(SqlDbType.Int).Value(roomNum)
                                    .WithParam("@IdHotel").As(SqlDbType.Int).Value(idHotel)
                                    .WithParam("@RoomExists").As(SqlDbType.Bit).AsOutput()
                                    .Execute();

            return (Boolean)results["@RoomExists"];
        
        }

        public Boolean insertRoom(Int32 idHotel,Int32 roomNum,Int32 floor, String location,String type,String descrip){
        
         SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_INSERT_ROOM")
                                .WithParam("@IdHotel").As(SqlDbType.Int).Value(idHotel)
                                .WithParam("@RoomNum").As(SqlDbType.Int).Value(roomNum)
                                .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                .WithParam("@TypeDesc").As(SqlDbType.VarChar).Value(type)
                                .WithParam("@LocationDesc").As(SqlDbType.VarChar).Value(location)
                                .WithParam("@Descr").As(SqlDbType.VarChar).Value(descrip)
                                .WithParam("@Inserted").As(SqlDbType.Bit).AsOutput()
                                .Execute();

            return (Boolean)results["@Inserted"];
        }


        public Boolean updateRoom(Int32 idHotel, Int32 roomNum, Int32 floor, String location, String type, String descrip)
        {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_UPDATE_ROOM")
                                   .WithParam("@IdHotel").As(SqlDbType.Int).Value(idHotel)
                                   .WithParam("@RoomNum").As(SqlDbType.Int).Value(roomNum)
                                   .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                   .WithParam("@TypeDesc").As(SqlDbType.VarChar).Value(type)
                                   .WithParam("@LocationDesc").As(SqlDbType.VarChar).Value(location)
                                   .WithParam("@Descr").As(SqlDbType.VarChar).Value(descrip)
                                   .WithParam("@Updated").As(SqlDbType.Bit).AsOutput()
                                   .Execute();

            return (Boolean)results["@Updated"];
        }
        


        public DataTable filteredSearch(Int32 idHotel,Int32? roomNum,Int32? floor, String location,String type,String descrip)
        {
        
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_FILTER_ROOM")
                                .WithParam("@IdHotel").As(SqlDbType.Int).Value(idHotel)
                                .WithParam("@RoomNum").As(SqlDbType.Int).Value(roomNum)
                                .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                .WithParam("@TypeDesc").As(SqlDbType.VarChar).Value(type)
                                .WithParam("@LocationDesc").As(SqlDbType.VarChar).Value(location)
                                .WithParam("@Descr").As(SqlDbType.VarChar).Value(descrip)
                                .WithParam("@ReturnedValues").AsDataTable().AsOutput()
                                .Execute();


            return (DataTable)results["@ReturnedValues"];

        }


        public Boolean deleteRoom(Int32 id_room)
        {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_DELETE_ROOM")
                                   .WithParam("@IdRoom").As(SqlDbType.Int).Value(id_room)
                                   .WithParam("@Deleted").As(SqlDbType.Bit).AsOutput()
                                   .Execute();             

            return (Boolean)results["@Deleted"];
        }


    }
}
