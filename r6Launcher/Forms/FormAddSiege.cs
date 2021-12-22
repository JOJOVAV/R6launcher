using System;
using System.Windows.Forms;

namespace r6Launcher.Forms
{
    public partial class FormAddSiege : Form
    {
        private string Path;
        private bool isCancelled;
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
        //little changes
        private void buttonAddr6_Click(object sender, EventArgs e)
        {
            GetPaths(Path);
        }
        private void GetPaths(string season)
        {
            // IF no Select download Path
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.Description = "Select your " + season + " Siege Folder";
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK & result != DialogResult.Cancel)
            {
                // Set Starting Path
                Path = folderDlg.SelectedPath;
                Log.WriteLog(Path);
                isCancelled = false;
            }
            else
            {
                Log.WriteLog("Folder Selection cancelled");
                isCancelled = true;
            }

        }
    }
}
