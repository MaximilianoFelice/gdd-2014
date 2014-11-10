using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.Home
{
    
    
    public class FeatureHandler
    {
        DataSet returnedValues;
        
        public DataSet getFeatures() { 
             SqlResults results = new SqlQuery("SELECT feature_key FROM BOBBY_TABLES.FEATURES").Execute();
             returnedValues= (DataSet) results["ReturnedValues"];
             return returnedValues;
             
        }

        public Boolean assignFeature(String roleName, String featureKey) {
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].insertRole")
                                           .WithParam("@RoleName").As(SqlDbType.VarChar).Value(roleName)
                                           .WithParam("@FeatureKey").As(SqlDbType.VarChar).Value(featureKey)
                                           .WithParam("@FeatureAssigned").As(SqlDbType.Int).AsOutput()
                                           .Execute();

            return (Boolean)results["FeatureAssigned"];
        
        }

    }
}
