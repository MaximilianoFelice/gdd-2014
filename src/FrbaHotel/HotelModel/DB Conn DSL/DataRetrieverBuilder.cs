﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ExtensionMethods;


namespace HotelModel.DB_Conn_DSL
{
    public interface DataRetrieverBuilder
    {
        object Execute(SqlCommand Command);
    }
}
