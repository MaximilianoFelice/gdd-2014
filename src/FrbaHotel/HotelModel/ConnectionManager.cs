using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace HotelModel
{
    public static class ConnectionManager
    {
        public static SqlConnection sqlConn;
        public static String connectionString;

        public static void OpenConnection()
        {
            connectionString = generateConnString();
            sqlConn = new SqlConnection(connectionString);

            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public static void CloseConnection()
        {
            sqlConn.Close();
        }

        public static SqlDataReader ExecuteQuery(String query)
        {
            SqlCommand newCommand = new SqlCommand(query);
            return newCommand.ExecuteReader();
        }

        static String generateConnString()
        {
            return "user id=gd; Password=gd2014; Server=localhost/SQLSERVER2008; Trusted_Connection=yes; database=database; connection timeout=10; Database=GD2C2014";
        }
    }
}
