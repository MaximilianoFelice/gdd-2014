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
       
        private static DataSet _guests;
        private static SqlDataAdapter _guests_adapter;
        public static SqlDataAdapter guests_adapter { get { if ((guests == null) || true); return _guests_adapter; } }
        public static DataSet guests{
            get
            {
                if (_guests == null)
                {
                    _guests_adapter = (SqlDataAdapter)new SqlQuery("SELECT * FROM BOBBY_TABLES.ACTIVE_PERSONS;").AsDataAdapter().Execute()["ReturnedValues"];
                    _guests = new DataSet();
                    _guests_adapter.Fill(_guests);
                } 
                return _guests;
            }
        }

        public static void Update(DataRow aRow)
        {
            guests_adapter.Update(new DataRow[] {aRow});
        }


        public static void deleteGuest(DataRow guest) { deleteGuest(new GuestHandler(guest)); }
        public static void deleteGuest(GuestHandler guest)
        {
            guest.Guest.Delete();
            _guests_adapter.Update(new DataRow[] { guest.Guest });
        }

        public static GuestHandler newGuest(){
            DataRow newG = guests.Tables[0].NewRow();
            newG["id_person"] = -1;
            guests.Tables[0].Rows.Add(newG);
            return new GuestHandler(newG);
        }
        

        private DataRow _guestRow;
        public DataRow Guest { get {return _guestRow;} }

        
        public GuestHandler(DataRow row)
        {
            _guestRow = row;
        }

        public object this[String val]
        {
            get { return Guest[val]; }
            set { Guest[val] = value; }
        }

        public void Update()
        {
            
            if ((int)Guest["id_hotel"] == -1)
            {
               
                Guest["id_person"] = DBNull.Value;
                guests_adapter.Update(new DataRow[] { Guest });
                Guest["id_person"] = (int)new SqlQuery("SELECT id_person FROM BOBBY_TABLES.PERSONS WHERE doc_type = '" + Guest["doc_type"] + "' AND doc_number = "+ Guest["doc_number"]+ ";").ExecuteScalar();
                Guest.AcceptChanges();

            }
            guests_adapter.Update(new DataRow[] {Guest});
            
        }

        
        public DataSet getPersons() {
            SqlResults results = new SqlQuery("SELECT * FROM [BOBBY_TABLES].PERSONS").Execute();
            return (DataSet)results["ReturnedValues"];
        }

        public bool PersonExistance(String name, String lastname, String docType, Decimal docNumber,  DateTime birthDate)
        {
            DataTable dt = this.getPersons().Tables[0];
            Boolean returnValue = false; ;
            foreach (DataRow row in dt.Rows)
            {
                if (row["name"].ToString() == name && row["lastname"].ToString() == lastname &&
                    row["doc_type"].ToString() == docType && (Decimal)row["doc_number"]== docNumber &&
                    (DateTime)row["birthdate"] == birthDate )
                {
                    returnValue = true;
                }

            }
            return returnValue;

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

        public Boolean emailExists(String anEmail)
        {
            DataTable dt = this.getPersons().Tables[0];
            Boolean returnValue = false; ;
            foreach (DataRow row in dt.Rows)
            {
                if (row["mail"].ToString() == anEmail)
                {
                    returnValue = true;
                }
                
            }
            return returnValue;

        }

        public Boolean emailExistsForUpdate(Int32 id_guest, String mail){
            DataTable dt = this.getPersons().Tables[0];
            Boolean returnValue = false;
            if (id_guest == -1) {
               return this.emailExists(mail);
            } else {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["mail"].ToString() == mail && (Int32)row["id_person"] != id_guest)
                    {
                        returnValue = true;
                    }

                }
                return returnValue;
            }
            
        
        }

        public Int32 insertPerson(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
                                String street, Int32 streetNum, Int32 floor, String dept, String nationality)
        {
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
                                        .WithParam("@IdInserted").As(SqlDbType.Int).AsOutput()
                                        .Execute();

            return (Int32)results["@IdInserted"];

        }


        public Boolean updatePerson(String name, String lastname, String docType, Decimal docNumber, String mail, Decimal phone, DateTime birthDate,
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
                                     .WithParam("@Updated").As(SqlDbType.Bit).AsOutput()
                                                             .Execute();

            return (Boolean)results["@Updated"];
        }


        public static DataSet filteredSearch(String name, String lastname, String docType, Decimal? docNumber, String mail) {
            SqlFunction func = new SqlFunction("[BOBBY_TABLES].SP_FILTER_PERSONS")
                                .WithParam("@Name").As(SqlDbType.Int).Value(name)
                                .WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname)
                                .WithParam("@DocType").As(SqlDbType.VarChar).Value(docType)
                                .WithParam("@Mail").As(SqlDbType.VarChar).Value(mail);
            /*if (name == "") { func.WithParam("@Name").As(SqlDbType.VarChar).Value(DBNull.Value); }
            else { func.WithParam("@Name").As(SqlDbType.Int).Value(name); }
            if (lastname == "") { func.WithParam("@Lastname").As(SqlDbType.VarChar).Value(DBNull.Value); }
            else { func.WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname); }
            if (docType =="") { func.WithParam("@DocType").As(SqlDbType.VarChar).Value(DBNull.Value); }
            else { func.WithParam("@DocType").As(SqlDbType.VarChar).Value(docType); }*/
            if (docNumber == null) {func.WithParam("@DocNumber").As(SqlDbType.Decimal).Value(DBNull.Value);}
            else { func.WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber); }
            /*if (mail == "") { func.WithParam("@Mail").As(SqlDbType.VarChar).Value(DBNull.Value); }
            else { func.WithParam("@Mail").As(SqlDbType.VarChar).Value(mail); }*/

            SqlResults results = func.Execute();
            return (DataSet)results["ReturnedValues"];

        }


        public DataTable getGuestInformation(Int32 id) {
            SqlResults results = new SqlFunction("[BOBBY_TABLES].FUNCT_GET_INFO")
                                .WithParam("@IdPerson").As(SqlDbType.Int).Value(id)
                                .Execute();
            return (DataTable)results["ReturnedValues"];

        }


    }
}


