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
        

        public DataSet getHotels()
        {
            SqlResults results = new SqlQuery("SELECT name FROM BOBBY_TABLES.HOTELS where stat= 401 AND name IS NOT NULL").Execute();
            return (DataSet)results["ReturnedValues"];
        
        }

        

        public Boolean insertHotel(String name, String mail, Decimal phone, String street, Int32 streetNum, 
                                    String city, String country, Int32 stars, DateTime creationDate) 
        {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_INSERT_HOTEL")
                                 .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                 .WithParam("@Mail").As(SqlDbType.VarChar).Value(mail)
                                 .WithParam("@Phone").As(SqlDbType.Decimal).Value(phone)
                                 .WithParam("@Street").As(SqlDbType.VarChar).Value(street)
                                 .WithParam("@StreetNum").As(SqlDbType.Int).Value(streetNum)
                                 .WithParam("@City").As(SqlDbType.VarChar).Value(city)
                                 .WithParam("@Country").As(SqlDbType.VarChar).Value(country)
                                 .WithParam("@Stars").As(SqlDbType.Int).Value(stars)
                                 .WithParam("@CreationDate").As(SqlDbType.DateTime).Value(creationDate)
                                 .WithParam("@Inserted").As(SqlDbType.Bit).AsOutput()
                                 .Execute();
            return (Boolean)results["@Inserted"];

        }


        public Boolean updateHotel(String name, String mail, Decimal phone, String street, Int32 streetNum,
                                    String city, String country, Int32 stars, DateTime creationDate)
        {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_UPDATE_HOTEL")
                                 .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                 .WithParam("@Mail").As(SqlDbType.VarChar).Value(mail)
                                 .WithParam("@Phone").As(SqlDbType.Decimal).Value(phone)
                                 .WithParam("@Street").As(SqlDbType.VarChar).Value(street)
                                 .WithParam("@StreetNum").As(SqlDbType.Int).Value(streetNum)
                                 .WithParam("@City").As(SqlDbType.VarChar).Value(city)
                                 .WithParam("@Country").As(SqlDbType.VarChar).Value(country)
                                 .WithParam("@Stars").As(SqlDbType.Int).Value(stars)
                                 .WithParam("@CreationDate").As(SqlDbType.DateTime).Value(creationDate)
                                 .WithParam("@Updated").As(SqlDbType.Bit).AsOutput()
                                 .Execute();
            return (Boolean)results["@Updated"];

        }


        public Boolean addRegimenToHotel(Int32 idHotel, Int32 idRegimen) {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_INSERT_REGIMENS_HOTEL")
                                .WithParam("@IdHotel").As(SqlDbType.Int).Value(idHotel)
                                .WithParam("@IdRegimen").As(SqlDbType.Int).Value(idRegimen)
                                .WithParam("@Inserted").As(SqlDbType.Bit).AsOutput()
                                .Execute();
            return (Boolean)results["Inserted"];

        
        }

        public DataSet getIdHotel(String name, String mail, String city) {
            SqlResults results = new SqlQuery("SELECT id_hotel FROM BOBBY_TABLES.HOTELS" 
                                              +"where name="+ name+" AND mail="+mail+" AND city="+city)
                                              .Execute();
            return (DataSet)results["ReturnedValues"];
        }

        public DataSet getIdHotelByName(String name)
        {
            SqlResults results = new SqlQuery("SELECT id_hotel FROM BOBBY_TABLES.HOTELS"
                                              + "where name=" + name)
                                              .Execute();
            return (DataSet)results["ReturnedValues"];
        }

        public DataTable filteredSearch(String name, Int32? stars, String city, String country) {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_FILTER_HOTELS")
                                .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                .WithParam("@Stars").As(SqlDbType.Int).Value(stars)
                                .WithParam("@City").As(SqlDbType.VarChar).Value(city)
                                .WithParam("@Country").As(SqlDbType.VarChar).Value(country)
                                .WithParam("@ReturnedValues").AsDataTable().AsOutput()
                                .Execute();


            return (DataTable)results["@ReturnedValues"];
        }

        public Boolean hotelForManteinance(Int32 id_hotel, DateTime start, DateTime end, String descr) {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_HOTEL_MANTEINANCE")
                                 .WithParam("@IdHotel").As(SqlDbType.Int).Value(id_hotel)
                                 .WithParam("@Start").As(SqlDbType.DateTime).Value(start)
                                 .WithParam("@End").As(SqlDbType.DateTime).Value(end)
                                 .WithParam("@Descr").As(SqlDbType.VarChar).Value(descr)
                                 .WithParam("@Manteined").As(SqlDbType.Bit).AsOutput()
                                 .Execute();
            return (Boolean)results["@Manteined"];
        
        }


    }
}
