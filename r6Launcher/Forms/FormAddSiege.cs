using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace r6Launcher.Forms
{
    public partial class FormAddSiege : Form
    {
        

        
        public FormAddSiege(/*int value*/)
        {
            InitializeComponent();
            

        }

        private void FormAddSiege_Load(object sender, EventArgs e)
        {

            
        }

        private void comboBoxAddSiege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAddSiege.SelectedIndex != -1)
            {
                int indx = comboBoxAddSiege.SelectedIndex;
                Log.WriteLog("Add: " + comboBoxAddSiege.SelectedItem);
                var settings = new Properties.Settings();
                settings.OperationSelect += comboBoxAddSiege.SelectedItem.ToString() + ",";
                settings.Save();
            }

        }

        /*public sealed class FolderBrowserDialog : System.Windows.Forms.CommonDialog
        {
            private FolderBrowserDialog folderBrowserDialog1;
            private OpenFileDialog openFileDialog1;
        }*/
    }
}
