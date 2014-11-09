using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelModel;
using HotelModel.DB_Conn_DSL;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace HotelModel.User_Permissions
{
    public static class PermissionManager
    {
        private static List<Control> _ManagedObjects = null;

        public static List<Control> ManagedObjects
        {
            get
            {
                if (_ManagedObjects != null) return getManagedObjects();
                else return _ManagedObjects;
            }
        }

        private static Control _BaseControl;

        public static Control BaseControl{
            get { return _BaseControl; }
        }

        public static void Login(String Username, String Password)
        {
            /* Validating login */
            // TODO: Convert password to SHA_256
            SqlResults results = new SqlStoredProcedure("[BOBBY_TABLES].validateUserPass")
                                    .WithParam("@User").As(SqlDbType.VarChar).Value(Username.ToString())
                                    .WithParam("@Pass").As(SqlDbType.VarChar).Value(Password.ToString())
                                    .WithParam("@RESULT").As(SqlDbType.Bit).AsOutput()
                                    .Execute();

            if (!(Boolean)results["@RESULT"]) throw new NotImplementedException(); // TODO: Create new exception here

            /* Loading Active User */
            ActiveUser.LoadUser(Username, (DataSet) results["ReturnedValues"]); // Returned Values containing user roles
            
        }

        public static void LoadPermissions()
        {
            throw new NotImplementedException();
        }

        public static void StartPoint(Control BaseForm)
        {
            _BaseControl = BaseForm;

            getManagedObjects();
        }

        private static List<Control> getManagedObjects()
        {
            _ManagedObjects = new List<Control>();

            IEnumerable<System.Type> CurrentTypes = from c in Assembly.GetExecutingAssembly().GetTypes()
                                                      where c.IsClass && c.Namespace == typeof(PermissionManager).Namespace + ".HandledControls"
                                                      select c;

            LoadHandledControls(BaseControl, CurrentTypes);

            return _ManagedObjects;
        }

        private static void LoadHandledControls(Control ParentControl, IEnumerable<System.Type> CurrentTypes)
        {
            _ManagedObjects.Add(ParentControl);

            List<Control> ParentControls = new List<Control>();

            foreach (Control child in ParentControl.Controls)
                if (CurrentTypes.Contains(child.GetType())) LoadHandledControls(child, CurrentTypes);

        }



    }
}
