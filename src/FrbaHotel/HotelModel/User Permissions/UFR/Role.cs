using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelModel;
using HotelModel.DB_Conn_DSL;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HotelModel.User_Permissions.UFR
{

    public class Role
    {
        private static Dictionary<String, Role> _LoadedRoles = new Dictionary<String,Role>();

        public static Dictionary<String, Role> getRoles{
            get { return _LoadedRoles; }
        }

        private int role_id;
        
        private String role_name;

        private List<Feature> features;

        public Role(DataRow RoleRow)
        {
            role_id = (int)RoleRow["id_role"];
            role_name = (String)RoleRow["name"];
            features = new List<Feature>();

            getRoleFeatures();

        }

        private void getRoleFeatures()
        {
            /* QUERY HERE */
            DataSet res = (DataSet) new SqlStoredProcedure("GetRoleFeatures").WithParam("@Role").Value(role_id).Execute()["ReturnedValues"];

            /* Mapped to corresponding objects */
            features = res.Tables[0].AsEnumerable().Select(x => x["descr"]).ToList().Select(feat => Feature.getFeaturesDictionary[(String) feat]).ToList();
        }

        public static void LoadRoles() 
        {
            DataSet res = (DataSet)new SqlQuery("SELECT * FROM [BOBBY_TABLES].ACTIVE_ROLES;").AsDataSet().Execute()["ReturnedValues"];

            foreach (DataRow row in res.Tables[0].AsEnumerable()) new Role(row);
            
        }

    }
}
