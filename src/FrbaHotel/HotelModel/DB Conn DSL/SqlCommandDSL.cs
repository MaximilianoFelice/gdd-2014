﻿using System;
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

        private DataRetrieverBuilder OutputMode = new DataSetRetriever();

        public SqlResults Execute()
        {
            this.Build();

            ConnectionManager.OpenConnection();

            object QueryResults = OutputMode.Execute(StoredCommand);

            SqlResults RetValues = AnalyzeResults();

            if (QueryResults != null) RetValues.Add("ReturnedValues", QueryResults);

            return RetValues;
        }

        public void AsDataSet()
        {
            OutputMode = new DataSetRetriever();
        }

        public void AsDataReader()
        {
            OutputMode = new DataReaderRetriever();
        }

        public void AsDataTable()
        {
            OutputMode = new DataTableRetriever();
        }

        /* Private methods for internal use */
        virtual public SqlResults AnalyzeResults()
        {
            return new SqlResults();
        }

        virtual public void Build() {}

    }
}
