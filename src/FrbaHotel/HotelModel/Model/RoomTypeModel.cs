﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelModel.DB_Conn_DSL;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace HotelModel.Model
{
    public static class RoomTypeModel
    {
        /* Defining sql accessors: Snippet Autogenerated */
        private static DataSet _roomtype;
        private static SqlDataAdapter _roomtype_adapter;
        public static SqlDataAdapter roomtype_adapter { get { if ((roomtype == null) || true); return _roomtype_adapter; } }
        public static DataSet roomtype
        {
            get
            {
                if (_roomtype == null)
                {
                    _roomtype_adapter = (SqlDataAdapter)new SqlQuery("SELECT id_roomtype, descr FROM BOBBY_TABLES.ROOM_TYPE;").AsDataAdapter().Execute()["ReturnedValues"];
                    _roomtype = new DataSet();
                    _roomtype_adapter.Fill(_roomtype);
                }
                return _roomtype;
            }
        }

        public static void BindTo(ComboBox ctrl)
        {
            ctrl.DataSource = roomtype.Tables[0];
            ctrl.ValueMember = "id_roomtype";
            ctrl.DisplayMember = "descr";
        }
    }
}