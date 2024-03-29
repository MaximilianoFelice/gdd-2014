﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExtensionMethods;
using HotelModel.User_Permissions.UI;
using System.Data.SqlClient;
using HotelModel.DB_Conn_DSL;
using HotelModel.User_Permissions;
using FrbaHotel.Registrar_Estadia;
using FrbaHotel.ABM_de_Cliente;
using FrbaHotel.ABM_de_Habitacion;
using FrbaHotel.Registrar_Consumible;
using FrbaHotel.Listado_Estadistico;
using FrbaHotel.Generar_Modificar_Reserva;
using FrbaHotel.ABM_de_Hotel;
using FrbaHotel.Cancelar_Reserva;
using HotelModel.Home;

namespace FrbaHotel
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            PermissionManager.StartPoint(this);

            Form login = new HotelModel.User_Permissions.UI.frmLogin();
            login.Owner = this;
            login.ShowDialog();

            setPermissions();

            setUpActions();
        }

        private void setUpActions()
        {
            HotelHandler.CheckHotelStates();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void LoadNewFormAsChild(Form child)
        {
            child.MdiParent = this;
            child.Show();
        }

        private void manageRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new frmRoles());
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        /* Defining sql accessors: Snippet Autogenerated */
        DataSet _user;
        SqlDataAdapter _user_adapter;
        _user_adapter = (SqlDataAdapter) new SqlQuery("SELECT id_user, username, inactive FROM BOBBY_TABLES.USERS;").AsDataAdapter().Execute()["ReturnedValues"];
        _user = new DataSet();
        _user_adapter.Fill(_user);
        
            LoadNewFormAsChild(new RehabForm(_user_adapter, _user, "inactive", "username", "id_user"));
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        /* Defining sql accessors: Snippet Autogenerated */
        DataSet _roles;
        SqlDataAdapter _roles_adapter;
        _roles_adapter = (SqlDataAdapter) new SqlQuery("SELECT id_role, name, inactive FROM BOBBY_TABLES.ROLES;").AsDataAdapter().Execute()["ReturnedValues"];
        _roles = new DataSet();
        _roles_adapter.Fill(_roles);
        
            LoadNewFormAsChild(new RehabForm(_roles_adapter, _roles, "inactive", "name", "id_role"));
        }

        private void featuresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        /* Defining sql accessors: Snippet Autogenerated */
        DataSet _features;
        SqlDataAdapter _features_adapter;
        _features_adapter = (SqlDataAdapter) new SqlQuery("SELECT id_feature, descr, inactive FROM BOBBY_TABLES.FEATURES;").AsDataAdapter().Execute()["ReturnedValues"];
        _features = new DataSet();
        _features_adapter.Fill(_features);
        
            LoadNewFormAsChild(new RehabForm(_features_adapter, _features, "inactive", "descr", "id_feature"));
        }

        private void setPermissions() 
        {
            adminToolStripMenuItem.HandleAccess(new String[] {"Admin"});
            adminToolStripMenuItem.HandleVisibility(new String[] {"Admin"});
            newGuestToolStripMenuItem.HandleAccess(new String[] {"Admin", "Receptionist"});
            newGuestToolStripMenuItem.HandleVisibility(new String[] { "Admin", "Receptionist" });
            bookingsToolStripMenuItem.HandleAccess(new String[] { "Admin", "Receptionist", "Guest" });
            bookingsToolStripMenuItem.HandleVisibility(new String[] { "Admin", "Receptionist", "Guest" });
            staysToolStripMenuItem.HandleAccess(new String[] { "Admin", "Receptionist" });
            staysToolStripMenuItem.HandleVisibility(new String[] { "Admin", "Receptionist" });
            peopleToolStripMenuItem.HandleAccess(new String[] { "Admin", "Receptionist" });
            peopleToolStripMenuItem.HandleVisibility(new String[] { "Admin", "Receptionist" });
            hotelsToolStripMenuItem.HandleAccess(new String[] { "Admin", "Receptionist" });
            hotelsToolStripMenuItem.HandleVisibility(new String[] { "Admin", "Receptionist" });
            servicesToolStripMenuItem.HandleAccess(new String[] { "Admin", "Receptionist" });
            servicesToolStripMenuItem.HandleVisibility(new String[] { "Admin", "Receptionist" });
            cancelToolStripMenuItem.HandleAccess(new String[] { "Admin", "Receptionist" });
            cancelToolStripMenuItem.HandleVisibility(new String[] { "Admin", "Receptionist" });
        }

        private void staysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new Stay());
        }

        private void newGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new CreateGuest());
        }

        private void extrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new CreateExtra());
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new Statistics());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new HotelModel.User_Permissions.UI.frmLogin();
            login.Owner = this;
            login.ShowDialog();

            setPermissions();
        }

        private void addHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new HotelModifier(HotelHandler.newHotel()));
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new CreateRoom());
        }

        private void manageRegimensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createOrModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new CreateBooking());
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new DeleteBooking());
        }

        private void findGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild(new FilterGuest());
        }

        private void deleteHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifyHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNewFormAsChild( new FilterHotel() );
        }
    }
}
