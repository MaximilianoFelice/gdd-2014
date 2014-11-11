using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelModel.Home;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class CreateRole : Form
    {
        String roleName;
        List<String> features;
        Boolean insertable=true;
        Boolean featureOk = true;

        public CreateRole()
        {
            InitializeComponent();
            
        }

        private void loadFeatures() {
        
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            while (checkedListBoxFeatures.CheckedIndices.Count > 0) {
                checkedListBoxFeatures.SetItemChecked(checkedListBoxFeatures.CheckedIndices[0], false);
            }



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.validateInput();
            if (insertable) {
                RoleHandler newRole = new RoleHandler();
                Boolean result = newRole.insertRole(roleName);
                if(result){
                    MessageBox.Show("Role Inserted correctly.Assigning feaures");
                    FeatureHandler fh = new FeatureHandler();
                    foreach(String feat in features){
                        featureOk = FeatureHandler.assignFeature(roleName, feat);
                    }

                }else{
                    MessageBox.Show("Error while inserting role.");
                }
            }

        }

        private void validateInput() {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                insertable = false;
                MessageBox.Show("Enter a role name. Mandatory Field.");

            }
            else {
                roleName = textBoxName.Text;
            }
        
        }

        private void CreateRole_Load(object sender, EventArgs e)
        {
            FeatureHandler role = new FeatureHandler();
           checkedListBoxFeatures.DataSource = FeatureHandler.getFeatures();
               
        }

            
        }
    }

