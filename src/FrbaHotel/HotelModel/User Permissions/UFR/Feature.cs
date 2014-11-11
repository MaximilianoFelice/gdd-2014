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
    public class Feature
    {

        private int id_feature;

        private String feature_desc = null;

        private List<Control> feature_visible_controls = null;

        private List<Control> feature_accesible_controls = null;

        public Feature(DataRow Feature)
        {
            id_feature = (int) Feature["id_feature"];

            feature_desc = (String) Feature["descr"];

            feature_accesible_controls = new List<Control>();

            feature_visible_controls = new List<Control>();

            _LoadedFeatures.Add(feature_desc, this);

        }

        public void CanAcess(Control ctrl)
        {
            PermissionManager.ManagedObjects.Add(ctrl);
            feature_accesible_controls.Add(ctrl);
        }

        public void CanView(Control ctrl)
        {
            PermissionManager.ManagedObjects.Add(ctrl);
            feature_visible_controls.Add(ctrl);
        }

        private static Dictionary<String, Feature> _LoadedFeatures = null;

        public static List<Feature> getFeatures{
            get { return _LoadedFeatures.Values.ToList(); }
        }

        public static List<String> getFeaturesNames
        {
            get { return _LoadedFeatures.Keys.ToList(); }
        }

        public static Dictionary<String, Feature> getFeaturesDictionary
        {
            get { return _LoadedFeatures; }
        }

        public static void LoadFeatures()
        {
            _LoadedFeatures = new Dictionary<String, Feature>();

            /* Loading Features from database */
            DataSet res = (DataSet) new SqlQuery("SELECT * FROM [BOBBY_TABLES].ACTIVE_FEATURES").AsDataSet().Execute()["ReturnedValues"];

            foreach (DataRow row in res.Tables[0].AsEnumerable()) new Feature(row);
            
            
        }

        public Boolean HasAccess(Control ctrl) { return feature_accesible_controls.Contains(ctrl); }

        public Boolean HasVisibility(Control ctrl) { return feature_visible_controls.Contains(ctrl); }

    }
}
