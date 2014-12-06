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


            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_PERSON_EXISTS")
                                        .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                        .WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname)
                                        .WithParam("@DocType").As(SqlDbType.VarChar).Value(docType)
                                        .WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber)
                                        .WithParam("@BirthDate").As(SqlDbType.DateTime).Value(birthDate)
                                        .WithParam("@GuestExist").As(SqlDbType.Int).AsOutput()
                                        .Execute();

            return (bool)results["@GuestExist"];

        }

        public bool PersonExistance(String docType, Decimal docNumber)
        {


            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_PERSON_EXISTS")
                                 .WithParam("@DocType").As(SqlDbType.VarChar).Value(docType)
                                 .WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber)
                                 .WithParam("@GuestExist").As(SqlDbType.Bit).AsOutput()
                                 .Execute();

            return (bool)results["@GuestExist"];

        }

        public Boolean emailExists(String anEmail) {
            if (!String.IsNullOrEmpty(anEmail))
            {
                SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_EMAIL_EXISTS")
                                    .WithParam("@Email").As(SqlDbType.VarChar).Value(anEmail)
                                    .WithParam("@EmailExist").As(SqlDbType.Bit).AsOutput()
                                    .Execute();

                return (Boolean)results["EmailExists"];
            }
            else return false;
        }

        public Int32 insertPerson(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
                                String street, Int32 streetNum, Int32 floor, String dept, String nationality, Int32 state)
        {

            //remember values -1 must not be inserted, designated to show void textboxs
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_INSERT_PERSON")
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
                                        .WithParam("@IdInserted").As(SqlDbType.Bit).AsOutput()
                                        .Execute();

            return (Int32)results["@IdInserted"];

        }






        public Int32 updatePerson(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
                                String street, Int32 streetNum,Int32 floor, String dept, String nationality,Int32 state)
        {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_UPDATE_PERSON")
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


        public DataTable filteredSearch(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
                                String street, Int32 streetNum, Int32 floor, String dept, String nationality, Int32 state) {


                                    SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_FILTER_PERSONS")
                                                             .WithParam("@Name").As(SqlDbType.VarChar).Value(name)
                                                             .WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname)
                                                             .WithParam("@DocType").As(SqlDbType.VarChar).Value(docType)
                                                             .WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber)
                                                             .WithParam("@Mail").As(SqlDbType.VarChar).Value(mail)
                                                             .WithParam("@ReturnedValues").AsDataTable().AsOutput()
                                                             .Execute();


            return (DataTable) results["@ReturnedValues"];
        
        }


        public int deletePerson(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
                                String street, Int32 streetNum, Int32 floor, String dept, String nationality)
        {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_DELETE_PERSON")
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


