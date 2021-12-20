using System;
using System.Windows.Forms;

namespace r6Launcher.Forms
{
    public partial class FormAddSiege : Form
    {
        public FormAddSiege()
        {
            InitializeComponent();
        }

        private void comboBoxAddSiege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAddSiege.SelectedIndex != -1)
            {
                var settings = new Properties.Settings();
                settings.OperationSelect += comboBoxAddSiege.SelectedItem.ToString() + ",";
                settings.Save();
                Log.WriteLog("Adding to Select: " + comboBoxAddSiege.SelectedItem);
            }
        }
    }
}
