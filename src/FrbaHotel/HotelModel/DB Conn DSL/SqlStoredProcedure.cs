using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ExtensionMethods;

namespace HotelModel.DB_Conn_DSL
{
    public class SqlStoredProcedure : SqlCommandDSL
    {
        public SqlCommand StoredProc;

        public Stack<SqlParameter> Parameters = new Stack<SqlParameter>();

        public Stack<SqlParameter> OutputParameters = new Stack<SqlParameter>();

        public SqlStoredProcedure(String ProcName)
        {
            this.StoredProc = new SqlCommand(ProcName, ConnectionManager.sqlConn);
            this.StoredProc.CommandType = CommandType.StoredProcedure;
        }


        public SqlStoredProcedure WithParam(String ParamName)
        {
            SqlParameter newParam = new SqlParameter();

            newParam.ParameterName = ParamName;

            Parameters.Push(newParam);

            return this;
        }

        public SqlStoredProcedure As(SqlDbType Type)
        {
            Parameters.SetPropertyToLast("SqlDbType", Type);

            return this;
        }

        public SqlStoredProcedure Value<T>(T value)
        {
            Parameters.SetPropertyToLast("Value", value);

            return this;
        }

        public SqlStoredProcedure AsOutput()
        {
            Parameters.SetPropertyToLast("Direction", System.Data.ParameterDirection.Output);

            return this;
        }

        public SqlStoredProcedure AsInput()
        {
            Parameters.SetPropertyToLast("Direction", System.Data.ParameterDirection.Input);

            return this;
        }

        public SqlStoredProcedure AsInputOutput()
        {
            Parameters.SetPropertyToLast("Direction", System.Data.ParameterDirection.InputOutput);

            return this;
        }

        public SqlStoredProcedure AsReturnValue()
        {
            Parameters.SetPropertyToLast("Direction", System.Data.ParameterDirection.ReturnValue);

            return this;
        }

        public Dictionary<String, object> Execute()
        {
            Dictionary<String, object> RetValues = new Dictionary<String, object>();

            Build();

            ConnectionManager.OpenConnection();

            StoredProc.ExecuteNonQuery();

            foreach (SqlParameter Param in OutputParameters)
            {
                RetValues.Add( Param.ParameterName, Param.Value );
            }

            ConnectionManager.CloseConnection();

            return RetValues;
        }

        /* Private Internal methods */
        private void Build()
        {
            foreach (SqlParameter Param in Parameters)
            {
                StoredProc.Parameters.Add(Param);

                if (Param.Direction == ParameterDirection.Output) OutputParameters.Push(Param);
            }

        }
    }
}
