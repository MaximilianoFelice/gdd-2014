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

namespace FrbaHotel
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.CreateGuest frm = new ABM_de_Cliente.CreateGuest();
            frm.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.Statistics frm = new FrbaHotel.Listado_Estadistico.Statistics();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.CreateHotel frm = new FrbaHotel.ABM_de_Hotel.CreateHotel();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.Manteinance frm = new FrbaHotel.ABM_de_Hotel.Manteinance();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Generar_Modificar_Reserva.CreateBooking frm = new FrbaHotel.Generar_Modificar_Reserva.CreateBooking();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Registrar_Consumible.CreateExtra frm = new FrbaHotel.Registrar_Consumible.CreateExtra();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.CreateRoom frm = new FrbaHotel.ABM_de_Habitacion.CreateRoom();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Registrar_Estadia.Stay frm = new FrbaHotel.Registrar_Estadia.Stay();
            frm.Show();

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
    }
}
