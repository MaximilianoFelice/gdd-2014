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
    public class GuestHandler
    {
      
        public bool PersonExistance(String name, String lastname, String docType, Decimal docNumber,  DateTime birthDate)
        {


            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].PersonExists")
                                        .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                        .WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname)
                                        .WithParam("@DocType").As(SqlDbType.VarChar).Value(docType)
                                        .WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber)
                                        .WithParam("@BirthDate").As(SqlDbType.DateTime).Value(birthDate)
                                        .WithParam("@GuestExist").As(SqlDbType.Int).AsOutput()
                                        .Execute();

            return (bool)results["GuestExist"];

        }
        
        public Int32 insertPerson(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
                                String street, Int32 streetNum, Int32 floor, String dept, String nationality)
        {


            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].insertPerson")
                                        .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                        .WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname)
                                        .WithParam("@DocType").As(SqlDbType.VarChar).Value(docType)
                                        .WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber)
                                        .WithParam("@Mail").As(SqlDbType.VarChar).Value(mail)
                                        .WithParam("@Phone").As(SqlDbType.Decimal).Value(phone)
                                        .WithParam("@BirthDate").As(SqlDbType.DateTime).Value(birthDate)
                                        .WithParam("@Street").As(SqlDbType.VarChar).Value(street)
                                        .WithParam("@StreetNum").As(SqlDbType.Int).Value(streetNum)
                                        .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                        .WithParam("@Dept").As(SqlDbType.VarChar).Value(dept)
                                        .WithParam("@Nationality").As(SqlDbType.VarChar).Value(nationality)
                                        .WithParam("@IdPersonInserted").As(SqlDbType.Int).AsOutput()
                                        .Execute();

            return (Int32)results["IdPersonInserted"];

        }






        public Int32 updatePerson(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
                                String street, Int32 streetNum,Int32 floor, String dept, String nationality,Int32 state)
        {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].UpdatePerson")
                                     .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                     .WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname)
                                     .WithParam("@DocType").As(SqlDbType.VarChar).Value(docType)
                                     .WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber)
                                     .WithParam("@Mail").As(SqlDbType.VarChar).Value(mail)
                                     .WithParam("@Phone").As(SqlDbType.Decimal).Value(phone)
                                     .WithParam("@BirthDate").As(SqlDbType.DateTime).Value(birthDate)
                                     .WithParam("@Street").As(SqlDbType.VarChar).Value(street)
                                     .WithParam("@StreetNum").As(SqlDbType.Int).Value(streetNum)
                                     .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                     .WithParam("@Dept").As(SqlDbType.VarChar).Value(dept)
                                     .WithParam("@Nationality").As(SqlDbType.VarChar).Value(nationality)
                                     .WithParam("@State").As(SqlDbType.Int).Value(state)
                                     .WithParam("@IdPersonUpdated").As(SqlDbType.Int).AsOutput()
                                                             .Execute();

            return (Int32)results["@IdPersonUpdated"];
        }


        public DataSet filteredSearch(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
                                String street, Int32 streetNum, Int32 floor, String dept, String nationality, Int32 state) {


                                    SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].filteredPerson")
                                                             .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                                             .WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname)
                                                             .WithParam("@DocType").As(SqlDbType.VarChar).Value(docType)
                                                             .WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber)
                                                             .WithParam("@Mail").As(SqlDbType.VarChar).Value(mail)
                                                             .WithParam("@Phone").As(SqlDbType.Decimal).Value(phone)
                                                             .WithParam("@BirthDate").As(SqlDbType.DateTime).Value(birthDate)
                                                             .WithParam("@Street").As(SqlDbType.VarChar).Value(street)
                                                             .WithParam("@StreetNum").As(SqlDbType.Int).Value(streetNum)
                                                             .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                                             .WithParam("@Dept").As(SqlDbType.VarChar).Value(dept)
                                                             .WithParam("@Nationality").As(SqlDbType.VarChar).Value(nationality)
                                                             .WithParam("@ReturnedValues").AsDataSet().AsOutput()
                                                                                     .Execute();


            return (DataSet) results["ReturnedValues"];
        
        }


        public int deletePerson(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
                                String street, Int32 streetNum, Int32 floor, String dept, String nationality)
        {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].updatePerson")
                                     .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                     .WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname)
                                     .WithParam("@DocType").As(SqlDbType.VarChar).Value(docType)
                                     .WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber)
                                     .WithParam("@Mail").As(SqlDbType.VarChar).Value(mail)
                                     .WithParam("@Phone").As(SqlDbType.Decimal).Value(phone)
                                     .WithParam("@BirthDate").As(SqlDbType.DateTime).Value(birthDate)
                                     .WithParam("@Street").As(SqlDbType.VarChar).Value(street)
                                     .WithParam("@StreetNum").As(SqlDbType.Int).Value(streetNum)
                                     .WithParam("@Floor").As(SqlDbType.Int).Value(floor)
                                     .WithParam("@Dept").As(SqlDbType.VarChar).Value(dept)
                                     .WithParam("@Nationality").As(SqlDbType.VarChar).Value(nationality)
                                     .WithParam("@IdPersonDeleted").As(SqlDbType.Int).AsOutput()
                                                             .Execute();

            return (Int32)results["@IdPersonDeleted"];
        }


    }
}


