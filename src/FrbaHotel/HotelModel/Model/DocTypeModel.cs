using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelModel.DB_Conn_DSL;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HotelModel.Model
{
    public static class DocTypeModel
    {
        
        private static DataSet _doctype;
        private static SqlDataAdapter _doctype_adapter;
        public static SqlDataAdapter doctype_adapter { get { if ((doctype == null) || true); return _doctype_adapter; } }
        public static DataSet doctype
        {
            get
            {
                if (_doctype == null)
                {
                    _doctype_adapter = (SqlDataAdapter)new SqlQuery("SELECT doc_type FROM BOBBY_TABLES.DOC_TYPE;").AsDataAdapter().Execute()["ReturnedValues"];
                    _doctype = new DataSet();
                    _doctype_adapter.Fill(_doctype);
                }
                return _doctype;
            }
        }

        public static void BindTo(ComboBox ctrl)
        {
            ctrl.DataSource = doctype.Tables[0];
            ctrl.ValueMember = "doc_type";
            ctrl.DisplayMember = "doc_type";
        }
        
    }
}
