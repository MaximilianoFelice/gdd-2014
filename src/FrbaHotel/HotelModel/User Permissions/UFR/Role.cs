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
        private static Dictionary<String, Role> _LoadedRoles = null;

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
            _LoadedRoles.Add(role_name, this);

            getRoleFeatures();

        }

        private void getRoleFeatures()
        {
            /* QUERY HERE */
            DataSet res = (DataSet)new SqlStoredProcedure("[BOBBY_TABLES].GetRoleFeatures").WithParam("@Role").Value(role_id).Execute()["ReturnedValues"];

            /* Mapped to corresponding objects */
            features = res.Tables[0].AsEnumerable().Select(x => x["descr"]).ToList().Select(feat => Feature.getFeaturesDictionary[(String) feat]).ToList();
        }

        public static void LoadRoles() 
        {
            _LoadedRoles = new Dictionary<String, Role>();
            DataSet res = (DataSet)new SqlQuery("SELECT * FROM [BOBBY_TABLES].ACTIVE_ROLES;").AsDataSet().Execute()["ReturnedValues"];

            foreach (DataRow row in res.Tables[0].AsEnumerable()) new Role(row);
            
        }

        public Boolean HasAccess(Control ctrl) { return features.Any(feat => feat.HasAccess(ctrl)); }

        public Boolean HasVisibility(Control ctrl) { return features.Any(feat => feat.HasVisibility(ctrl)); }

    }
}
