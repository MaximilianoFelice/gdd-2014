﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel;
using HotelModel.User_Permissions.ControlManager;

namespace FrbaHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Correct_Login_Click(object sender, EventArgs e)
        {
            // Correct
            Boolean ret = User.ValidateLogin("MaximilianoFelice", "53acbedaad48d8d482fe1a9bf8cd8b8e329ff8033c5c1dc81dcccdff38dd197f");

            if (ret) MessageBox.Show("Logged In!");
            else MessageBox.Show("Login Failed");
        }

        private void Incorrect_Login_Click(object sender, EventArgs e)
        {
            // Incorrect
            Boolean ret = User.ValidateLogin("MaximilianoFelice", "53acbedaad4IJUSTWANNADANCENOWc1dc81dcccdff38dd197f");

            if (ret) MessageBox.Show("Logged In!");
            else MessageBox.Show("Login Failed");
        }

        private void cmdTests_Click(object sender, EventArgs e)
        {
            new HotelModel.DB_Conn_DSL.tests.StoredProcedureConnection_tests().ReturnValuesWorks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
