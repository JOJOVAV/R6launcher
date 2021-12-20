using System;
using System.Linq;
using System.Windows.Forms;

namespace r6Launcher.Forms
{
    public partial class FormSelectSiege : Form
    {
        #region Start/Load
        public FormSelectSiege()
        {
            InitializeComponent();
        }
        private void FormLoad(object sender, EventArgs e)
        {
            var settings = new Properties.Settings();
            var arrayopselect = settings.OperationSelect.Split(',').ToArray();
            comboBoxSelectSiege.Items.AddRange(arrayopselect);
        }
        #endregion
        #region changed/Clicked Events
        private void ResetClicked(object sender, EventArgs e)
        {
            var settings = new Properties.Settings();
            settings.Reset();
            settings.Save();
            comboBoxSelectSiege.Items.Clear();
        }

        private void comboBoxSelectSiege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectSiege.SelectedIndex != -1)
            {
                var settings = new Properties.Settings();
                string selitem = comboBoxSelectSiege.SelectedItem.ToString();
                settings.Currently_Op = selitem;
                settings.Save();
                Log.WriteLog(selitem + " is selected!");
            }
        }
        private void VulkanCheckChanged(object sender, EventArgs e)
        {
            Public.useVulkan = useVulkanCheckBox.Checked;
        }
        #endregion
    }
}
