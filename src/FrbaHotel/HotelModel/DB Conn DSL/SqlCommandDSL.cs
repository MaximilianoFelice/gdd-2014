using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ExtensionMethods;

namespace HotelModel.DB_Conn_DSL
{
    /* Used as alias */
    public class SqlResults : System.Collections.Generic.Dictionary<System.String, object> { }

    public abstract class SqlCommandDSL
    {
        public SqlCommand StoredCommand;

        public SqlResults Execute()
        {

            this.Build();

            ConnectionManager.OpenConnection();

            SqlDataReader QueryResults = StoredCommand.ExecuteReader();

            SqlResults RetValues = AnalyzeResults();

            if (QueryResults.HasRows) RetValues.Add("ReturnedValues", QueryResults);

            ConnectionManager.CloseConnection();

            return RetValues;
        }


        virtual public SqlResults AnalyzeResults()
        {
            return new SqlResults();
        }

        virtual public void Build() {}
    }
}
