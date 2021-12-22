using System;
using System.Windows.Forms;

namespace r6Launcher.Forms
{
    public partial class FormAddSiege : Form
    {
        private string _season;
        public FormAddSiege()
        {
            InitializeComponent();
        }
        private void comboBoxAddSiege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAddSiege.SelectedIndex != -1)
            {
                _season = comboBoxAddSiege.SelectedItem.ToString();
            }
        }
        private void buttonAddr6_Click(object sender, EventArgs e)
        {
            GetPaths(_season,0, _season);
        }
        private void GetPaths(string season,int lvl,string old_season)
        {
            var settings = new Properties.Settings();
            if (!settings.SavedPathOps.Contains(season))
            {
                // IF no Select download Path
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.Description = "Select your " + season + " Siege Folder";
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK & result != DialogResult.Cancel)
                {
                    // Set Starting Path
                    settings.OperationSelect += season + ",";
                    Log.WriteLog("Adding to Select: " + season);
                    string Path = folderDlg.SelectedPath;
                    settings.Saved_Path = Path;
                    settings.SavedPathOps += Path + "*" + season + "|";
                    Log.WriteLog(season + " is on this folder: " + Path);
                    Public.isCancelled = false;
                    settings.Save();
                }
                else
                {
                    Log.WriteLog("Folder Selection cancelled");
                    Public.isCancelled = true;
                }
            }
            else
            {
                Log.WriteLog(old_season + "-" + 1 + " lvl:" + 1 + " old:" + old_season);
                GetPaths(old_season + "-" + lvl, lvl + 1, old_season);

            }
        }
    }
}
