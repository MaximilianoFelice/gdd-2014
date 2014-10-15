using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ExtensionMethods;

namespace HotelModel.DB_Conn_DSL
{
    public abstract class SqlWithParams : SqlCommandDSL
    {
        public Stack<SqlParameter> Parameters = new Stack<SqlParameter>();

        /* Private Internal methods */
        override public void Build()
        {
            foreach (SqlParameter Param in Parameters)
            {
                StoredCommand.Parameters.Add(Param);

                AnalyzeParam(Param);
            }

        }

        virtual public void AnalyzeParam(SqlParameter Param) {}

    }
}
