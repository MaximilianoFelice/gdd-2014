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
using ExtensionMethods;
using HotelModel.User_Permissions.UFR;

namespace HotelModel.User_Permissions
{
    public static class PermissionManager
    {
        private static HashSet<Control> _ManagedVisibleObjects = null;

        private static HashSet<Control> _ManagedAccessibleObjects = null;

        #region Accessors

        public static HashSet<Control> ManagedVisibleObjects
        {
            get
            {
                if (_ManagedVisibleObjects == null || _ManagedAccessibleObjects == null) return getManagedObjects();
                else return _ManagedVisibleObjects;
            }
        }

        public static HashSet<Control> ManagedAccessibleObjects
        {
            get
            {
                if (_ManagedVisibleObjects == null || _ManagedAccessibleObjects == null) return getManagedObjects();
                else return _ManagedAccessibleObjects;
            }
        }

        public static HashSet<Control> ManagedObjects
        {
            get
            {
                if (_ManagedVisibleObjects == null || _ManagedAccessibleObjects == null) return getManagedObjects();
                else return _ManagedVisibleObjects.IUnionWith(_ManagedAccessibleObjects);
            }
        }

    #endregion

        public static void addVisibleControl(Control ctrl) { 
            /* Sets default Not Visible permission */
            ctrl.Visible = false;
            /* Hook to change visibility event */
            ctrl.VisibleChanged += new EventHandler(ControlEvents.VisibilityChanged);
            _ManagedVisibleObjects.Add(ctrl); 
        }

        public static void addAccessibleControl(Control ctrl) { 
            /* Sets default Not Accessible permission */
            ctrl.Enabled = false;
            /* TODO: Hook to change accessibility event */
            ctrl.EnabledChanged += new EventHandler(ControlEvents.AccessibilityChanged);
            _ManagedAccessibleObjects.Add(ctrl); 
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

            Feature.LoadFeatures();
            Role.LoadRoles();

            getManagedObjects();
        }

        private static HashSet<Control> getManagedObjects()
        {
            _ManagedVisibleObjects = new HashSet<Control>();

            _ManagedAccessibleObjects = new HashSet<Control>();

            IEnumerable<System.Type> CurrentTypes = from c in Assembly.GetExecutingAssembly().GetTypes()
                                                      where c.IsClass && c.Namespace == typeof(PermissionManager).Namespace + ".HandledControls"
                                                      select c;

            LoadHandledControls(BaseControl, CurrentTypes);

            return _ManagedVisibleObjects;
        }

        /* Getting all Handled Controls recursively and then setting its handling */
        private static void LoadHandledControls(Control ParentControl, IEnumerable<System.Type> CurrentTypes)
        {
            if (ParentControl.getPropertyValueOrDefault<Boolean>("HandlesVisibility") == true) addVisibleControl(ParentControl);
            if (ParentControl.getPropertyValueOrDefault<Boolean>("HandlesAccess") == true) addAccessibleControl(ParentControl);

            foreach (Control child in ParentControl.Controls) LoadHandledControls(child, CurrentTypes);

        }



    }

    public static class ExtenionControl
    {
        public static T getPropertyValueOrDefault<T>(this Object obj, String prop)
        {
            var res = obj.GetType().GetProperty(prop);
            if (res != null) return (T) res.GetValue(obj, null);
            else return default(T);
        }
    }
}
