using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace HotelModel.Home
{
   public class FormHandler
    {
        public static void groupBoxCleaner(GroupBox g) { 
             foreach (var c in g.Controls)
            {
                
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
               
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedItem=null;
                }
                
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        
        }

        public static void formCleaner(Control c) {
            foreach (var f in c.Controls)
            {
                
                if (f is TextBox)
                {
                    ((TextBox)f).Clear();
                }
              
                else if (f is ComboBox)
                {
                    ((ComboBox)f).SelectedItem = null;
                }
          
                else if (f is CheckBox)
                {
                    ((CheckBox)f).Checked = false;
                }
            }
        }

        public static void clearItemCheckList(CheckedListBox check)
        {
            for (int item = 0; item < check.Items.Count; item++)
            {
                check.SetItemChecked(item, false);
            }
        }

        public static void clearDataGridViewDT(DataGridView dgv, DataTable tabla)
        {
            tabla.Clear();
            dgv.DataSource = tabla;
        }
        public static void clearDataGridView(DataGridView dgv)
        {
            DataTable tabla = new DataTable();
            dgv.DataSource = tabla;
        }
    }
}


