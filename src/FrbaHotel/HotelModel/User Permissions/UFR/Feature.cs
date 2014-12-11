﻿using System;
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

        public String feature_desc = null;

        private HashSet<Control> feature_visible_controls = null;

        private HashSet<Control> feature_accessible_controls = null;

        public HashSet<Control> Visible_Controls { get { return feature_visible_controls; } }
        public HashSet<Control> Accessible_Controls { get { return feature_accessible_controls; } }

        public Feature(DataRow Feature)
        {
            id_feature = (int) Feature["id_feature"];

            feature_desc = (String) Feature["descr"];

            feature_accessible_controls = new HashSet<Control>();

            feature_visible_controls = new HashSet<Control>();

            _LoadedFeatures.Add(feature_desc, this);

        }

        public void CanAcess(Control ctrl)
        {
            PermissionManager.ManagedAccessibleObjects.Add(ctrl);
            feature_accessible_controls.Add(ctrl);
            ActiveUser.RefreshPermissions();
        }

        public void CanView(Control ctrl)
        {
            PermissionManager.ManagedVisibleObjects.Add(ctrl);
            feature_visible_controls.Add(ctrl);
            ActiveUser.RefreshPermissions();
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

        public Boolean HasAccess(Control ctrl) { return feature_accessible_controls.Contains(ctrl); }

        public Boolean HasVisibility(Control ctrl) { return feature_visible_controls.Contains(ctrl); }

        public void Unmanage(Control ctrl)
        {
            feature_visible_controls.Remove(ctrl);
            feature_accessible_controls.Remove(ctrl);
        }

    }
}
