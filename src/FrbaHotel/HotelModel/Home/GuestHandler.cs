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


      

        public static GuestHandler newGuest(){
            DataRow newG = guests.Tables[0].NewRow();
            newG["id_person"] = -1; //Important!! We set -1 for new hotels
            guests.Tables[0].Rows.Add(newG);
            return new GuestHandler(newG);
        }
        

        private DataRow _guestRow;
        public DataRow Guest { get {return _guestRow;} }

        /*
        private DataSet _regimens;
        private SqlDataAdapter _regimens_adapter;
        public SqlDataAdapter regimens_adapter { get { if ((regimens == null) || true); return _regimens_adapter; } }
        public DataSet regimens{
            get
            {
                if (_regimens == null)
                {
                    _regimens_adapter = (SqlDataAdapter) new SqlQuery("SELECT id_hotel, id_regimen FROM BOBBY_TABLES.REGIMEN_HOTEL where id_hotel = " + Hotel["id_hotel"] ).AsDataAdapter().Execute()["ReturnedValues"];
                    _regimens = new DataSet();
                    _regimens_adapter.Fill(_regimens);
                } 
                return _regimens;
            }
        }
        
        

        public Boolean HasRegimen(int id_reg)
        {
            return regimens.Tables[0].AsEnumerable().Any(x => (int)x["id_regimen"] == id_reg);
        }*/
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
                /* Obtiene el ID */
                Guest["id_person"] = DBNull.Value;
                guests_adapter.Update(new DataRow[] { Guest });
                Guest["id_person"] = (int)new SqlQuery("SELECT id_person FROM BOBBY_TABLES.PERSONS WHERE doc_type = '" + Guest["doc_type"] + "' AND doc_number = "+ Guest["doc_number"]+ ";").ExecuteScalar();
                Guest.AcceptChanges();

                /* Carga todos los regimenes con ese ID */
               // regimens.Tables[0].AsEnumerable().IMap(x => x["id_hotel"] = Hotel["id_hotel"]);
            }
            guests_adapter.Update(new DataRow[] {Guest});
            //regimens_adapter.Update(regimens);
        }

        /*public void AddRegimen(int id_reg)
        {
            DataRow newR = regimens.Tables[0].NewRow();
            newR["id_hotel"] = Hotel["id_hotel"];
            newR["id_regimen"] = id_reg;

            regimens.Tables[0].Rows.Add(newR);
        }

        public void RemoveRegimen(int id_reg)
        {
            regimens.Tables[0].Select("id_hotel = " + Hotel["id_hotel"] + " AND id_regimen = " + id_reg).IMap(x => x.Delete());
        }
        */
        
        public DataSet getPersons() {
            SqlResults results = new SqlQuery("SELECT * FROM [BOBBY_TABLES].PERSONS").Execute();
            return (DataSet)results["ReturnedValues"];
        }

        public DataSet getDocTypes() {
            SqlResults results = new SqlQuery("SELECT * FROM [BOBBY_TABLES].DOC_TYPE").Execute();
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
            if (!String.IsNullOrEmpty(mail))
            {
                SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_EMAIL_EXISTS_UPDATE")
                                    .WithParam("@Id").As(SqlDbType.Int).Value(id_guest)
                                    .WithParam("@Email").As(SqlDbType.VarChar).Value(mail)
                                    .WithParam("@EmailExist").As(SqlDbType.Bit).AsOutput()
                                    .Execute();

                return (Boolean)results["@EmailExist"];
            }
            else return false;
        
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


        /*public DataTable filters(String name, String lastname, String docType, Decimal? docNumber, String mail) {
            SqlResults results = new SqlQuery()
        }*/
        public static DataSet filteredSearch(String name, String lastname, String docType, Decimal? docNumber, String mail) {
            SqlFunction func = new SqlFunction("[BOBBY_TABLES].SP_FILTER_PERSONS");
            if (name == "") { func.WithParam("@Name").As(SqlDbType.VarChar).Value(DBNull.Value); }
            else { func.WithParam("@Name").As(SqlDbType.Int).Value(name); }
            if (lastname == "") { func.WithParam("@Lastname").As(SqlDbType.VarChar).Value(DBNull.Value); }
            else { func.WithParam("@Lastname").As(SqlDbType.VarChar).Value(lastname); }
            if (docType =="") { func.WithParam("@DocType").As(SqlDbType.VarChar).Value(DBNull.Value); }
            else { func.WithParam("@DocType").As(SqlDbType.VarChar).Value(docType); }
            if (docNumber == null) {func.WithParam("@DocNumber").As(SqlDbType.Decimal).Value(DBNull.Value);}
            else { func.WithParam("@DocNumber").As(SqlDbType.Decimal).Value(docNumber); }
            if (mail == "") { func.WithParam("@Mail").As(SqlDbType.VarChar).Value(DBNull.Value); }
            else { func.WithParam("@Mail").As(SqlDbType.VarChar).Value(mail); }

            SqlResults results = func.Execute();
            return (DataSet)results["ReturnedValues"];

        }


        public Boolean deletePerson(Int32 id_guest)
        {

            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_DELETE_PERSON")
                                     .WithParam("@IdGuest").As(SqlDbType.Int).Value(id_guest)
                                     .WithParam("@Deleted").As(SqlDbType.Bit).AsOutput()
                                     .Execute();

            return (Boolean)results["@Deleted"];
        }

        public DataTable getGuestInformation(Int32 id) {
            SqlResults results = new SqlFunction("[BOBBY_TABLES].FUNCT_GET_INFO")
                                .WithParam("@IdPerson").As(SqlDbType.Int).Value(id)
                                .Execute();
            return (DataTable)results["ReturnedValues"];

        }


    }
}


