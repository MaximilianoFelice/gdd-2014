﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Data;
using ExtensionMethods;
using HotelModel.DB_Conn_DSL;

namespace HotelModel.DB_Conn_DSL.tests
{
    [TestFixture]
    public class SqlQuery_tests
    {
        [Test]
        public void ExecutesValidQuery()
        {
            SqlResults results = new SqlQuery("SELECT * FROM [BOBBY_TABLES].USERS;").Execute();

            DataSet ReturnedSet = (DataSet) results["ReturnedValues"];
            Assert.True(ReturnedSet.Tables[0].Rows.Count > 0);
        }
    }
}
