using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelModel;
using HotelModel.DB_Conn_DSL;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;
using HotelModel.User_Permissions.UFR;
using System.Windows.Forms;
using HotelModel.User_Permissions.Exceptions;
using HotelModel.User_Permissions.UI;

namespace HotelModel.User_Permissions
{
    public static class ActiveUser
    {
        public static int Active_Hotel;

        public static int ChooseHotel()
        {
            Action<object> callback = delegate(object row) { Active_Hotel = (int) row; };
            DataSet hotels_for_user = (DataSet) new SqlQuery("SELECT h.id_hotel, h.name FROM BOBBY_TABLES.USER_HOTELS AS uh "+
                                                                "INNER JOIN BOBBY_TABLES.USERS AS u ON (u.id_user = uh.id_user) "+
                                                                "INNER JOIN BOBBY_TABLES.HOTELS AS h ON (h.id_hotel = uh.id_hotel) "+
                                                                "WHERE u.username = '" + User + "';").Execute()["ReturnedValues"];

            if (hotels_for_user.Tables[0].Rows.Count == 1) { Active_Hotel = (int) hotels_for_user.Tables[0].Rows[0]["id_hotel"]; }
            else if (hotels_for_user.Tables[0].Rows.Count == 0) { MessageBox.Show("This user has no active hotel to work with."); Active_Hotel = -1; }
            else
            {
                Form chooseHotel = new ChooseOption(hotels_for_user.Tables[0], "id_hotel", "name", callback);
                chooseHotel.ShowDialog();
            }

            return Active_Hotel;
        }

        public static String User;

        public static List<Role> User_Roles = new List<Role>();

        private static Role _Active_Role = null;

        public static Role Active_Role
        {
            get {
                if (_Active_Role != null) { return _Active_Role; }
                else {throw new ActiveRoleNotSetException();}
                }
        }

        public static void LoadUser(String Username, DataSet Roles)
        {
            User = Username;
            if (Roles.Tables.Count <= 0) {
                MessageBox.Show("This user has no current active roles");
                return;
            }

            for (int i = 0; Roles.Tables[0].Rows.Count > i; i++)
            {
                User_Roles.Add( Role.getRoles[(String)Roles.Tables[0].Rows[i]["name"]] );
            }
        }

        public static void LoadUser(String Username, String[] Roles)
        {
            User = Username;

            foreach (String r in Roles)
            {
                User_Roles.Add(Role.getRoles[r]);
            }
        }

        public static void ActivateRole(String RoleName)
        {
            Role aRole;
            try{
                aRole = Role.getRoles[RoleName];
            } catch (KeyNotFoundException e){
                throw new RoleNotFoundException("Role " + RoleName + " doesn't exist in current context");
            }

            if (!User_Roles.Contains(aRole)) throw new UserHasNoRoleException("User " + User + " has not role " + RoleName);

            _Active_Role = aRole;

            aRole.Activate();
        }

        public static Boolean HasAccess(Control control) { return Active_Role.HasAccess(control); }

        public static Boolean HasVisibility(Control control) { return Active_Role.HasVisibility(control); }

        public static Boolean HasAccess(ToolStripItem tools) { return Active_Role.HasAccess(tools); }

        public static Boolean HasVisibility(ToolStripItem tools) { return Active_Role.HasVisibility(tools); }

        public static void RefreshPermissions() { Active_Role.Activate(); }
    }
}
