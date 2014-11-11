﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    
    
    public class FeatureHandler
    {
        
        
        public DataTable getFeatures() { 
             SqlResults results = new SqlQuery("SELECT feature_key FROM BOBBY_TABLES.FEATURES").Execute();
             return (DataTable) results["ReturnedValues"];
            
             
        }

        public Boolean assignFeature(String roleName, String featureKey) {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].SP_INSERT_FEATURE_TO_ROLE")
                                           .WithParam("@RoleName").As(SqlDbType.VarChar).Value(roleName)
                                           .WithParam("@FeatureKey").As(SqlDbType.VarChar).Value(featureKey)
                                           .WithParam("@FeatureAssigned").As(SqlDbType.Int).AsOutput()
                                           .Execute();

            return (Boolean)results["FeatureAssigned"];
        
        }

    }
}