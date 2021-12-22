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
        private void Select_Clicked(object sender, EventArgs e)
        {
            if (comboBoxSelectSiege.SelectedIndex != -1 && comboBoxSelectSiege.SelectedItem.ToString() != "")
            {
                var settings = new Properties.Settings();
                string selitem = comboBoxSelectSiege.SelectedItem.ToString();
                settings.Currently_Op = selitem;
                string[] splitted = settings.SavedPathOps.Split('|');
                foreach (string file in splitted)
                {
                    string[] splittedfile = file.Split('*');
                    string Path = splittedfile.First();
                    string season = splittedfile.Last();
                    if (season == selitem)
                    {
                        Log.WriteLog(Path + " " + season);
                        settings.Saved_Path = Path;
                    }
                }
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
