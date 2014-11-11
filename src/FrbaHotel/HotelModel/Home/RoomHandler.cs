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

        public bool RoomExistance(Int32 hotel, Int32 number)
        {


            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].RoomExists")
                                        .WithParam("@Hotel").As(SqlDbType.Int).Value(hotel)
                                        .WithParam("@Number").As(SqlDbType.Int).Value(number)
                                        .WithParam("@GuestExist").As(SqlDbType.Int).AsOutput()
                                        .Execute();

            return (bool)results["GuestExist"];

        }
        
        public Int32 insertRoom(Int32 hotel, Int32 number, Int32 floor, Int32 type,  Int32 location, String description)
        {


            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].insertRoom")
                                        .WithParam("@Hotel").As(SqlDbType.Int).Value(hotel)
                                        .WithParam("@Number").As(SqlDbType.Int).Value(number)
                                        .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                        .WithParam("@Type").As(SqlDbType.Int).Value(type)
                                        .WithParam("@Location").As(SqlDbType.Int).Value(location)
                                        .WithParam("@Description").As(SqlDbType.VarChar).Value(description)
                                        .WithParam("@IdRoomInserted").As(SqlDbType.Int).AsOutput()
                                        .Execute();

            return (Int32)results["IdRoomInserted"];

        }






        public Int32 updateRoom(Int32 hotel, Int32 number, Int32 floor, Int32 type,  Int32 location, String description)
        {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].UpdateRoom")
                                     .WithParam("@Hotel").As(SqlDbType.Int).Value(hotel)
                                     .WithParam("@Number").As(SqlDbType.Int).Value(number)
                                     .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                     .WithParam("@Type").As(SqlDbType.Int).Value(type)
                                     .WithParam("@Location").As(SqlDbType.Int).Value(location)
                                     .WithParam("@Description").As(SqlDbType.VarChar).Value(description)
                                     .WithParam("@IdRoomUpdated").As(SqlDbType.Int).AsOutput()
                                                             .Execute();

            return (Int32)results["@IdRoomUpdated"];
        }


        public DataSet filteredSearch(Int32 hotel, Int32 number, Int32 floor, Int32 type,  Int32 location, String description) {


                                    SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].filteredRoom")
                                                             .WithParam("@Hotel").As(SqlDbType.Int).Value(hotel)
                                                             .WithParam("@Number").As(SqlDbType.Int).Value(number)
                                                             .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                                             .WithParam("@Type").As(SqlDbType.Int).Value(type)
                                                             .WithParam("@Location").As(SqlDbType.Int).Value(location)
                                                             .WithParam("@Description").As(SqlDbType.VarChar).Value(description)
                                                             .WithParam("@ReturnedValues").AsDataSet().AsOutput()
                                                                                     .Execute();


            return (DataSet) results["ReturnedValues"];
        
        }


        public int deletePerson(Int32 hotel, Int32 number, Int32 floor, Int32 type,  Int32 location, String description)
        {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].updatePerson")
                                     .WithParam("@Hotel").As(SqlDbType.Int).Value(hotel)
                                     .WithParam("@Number").As(SqlDbType.Int).Value(number)
                                     .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                     .WithParam("@Type").As(SqlDbType.Int).Value(type)
                                     .WithParam("@Location").As(SqlDbType.Int).Value(location)
                                     .WithParam("@Description").As(SqlDbType.VarChar).Value(description)
                                     .WithParam("@IdRoomDeleted").As(SqlDbType.Int).AsOutput()
                                                             .Execute();

            return (Int32)results["@IdRoomDeleted"];
        }


    }
}
