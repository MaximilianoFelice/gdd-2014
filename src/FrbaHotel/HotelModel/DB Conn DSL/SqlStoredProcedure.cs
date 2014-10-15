﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ExtensionMethods;

namespace HotelModel.DB_Conn_DSL
{

    public class SqlStoredProcedure : SqlWithParams
    {
        public Stack<SqlParameter> OutputParameters = new Stack<SqlParameter>();

        public SqlStoredProcedure(String ProcName)
        {
            this.StoredCommand = new SqlCommand(ProcName, ConnectionManager.sqlConn);
            this.StoredCommand.CommandType = CommandType.StoredProcedure;
        }

        public SqlStoredProcedure AsOutput()
        {
            Parameters.SetPropertyToLast("Direction", System.Data.ParameterDirection.Output);

            return this;
        }

        public SqlStoredProcedure AsInputOutput()
        {
            Parameters.SetPropertyToLast("Direction", System.Data.ParameterDirection.InputOutput);

            return this;
        }


        /* Private Internal methods */
        override public void AnalyzeParam(SqlParameter Param)
        {
            if (Param.Direction == ParameterDirection.Output) OutputParameters.Push(Param);
        }

        override public SqlResults AnalyzeResults()
        {
            SqlResults RetValues = new SqlResults();

            foreach (SqlParameter Param in OutputParameters)
            {
                RetValues.Add(Param.ParameterName, Param.Value);
            }

            return RetValues;
        }
    }
}
